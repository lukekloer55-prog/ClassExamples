using System.IO.Ports;
using System.Media;

namespace BetterEtch_O_Sketch
{
    public partial class EtchASketch : Form
    {
        private Color penColor = Color.Black;
        private Color BackGround = Color.White;
        private int penWidth = 3;
        bool ExternalControlEnabled = false;
        bool MouseControlEnabled = false;
        int oldX, oldY;
        private ToolTip tips = new ToolTip();
        private SerialPort? picPort;
        private System.Windows.Forms.Timer picTimer = new System.Windows.Forms.Timer();
        private List<byte> receivedBytes = new List<byte>();
        private bool picScanning = false, picWaiting = false;
        private volatile bool picClosing = false;
        private bool picPointReady = false;
        private bool picErrorShown = false;   // so the popup appears once per problem
        private int adcX = -1, adcY = -1;
        private int nextChannel = 0, requestedChannel = -1;
        private DateTime picRequestTime, nextPICScan = DateTime.MinValue;
        private int adcFailures = 0;

        static readonly byte[] IdRequest = { 0x24, 0x49, 0x00 };
        static readonly byte[] IdReply = { 0x24, 0x49, 0x02, 0x33, 0x75 };
        static readonly byte[] AN0Request = { 0x24, 0x41, 0x01, 0x00 };
        static readonly byte[] AN1Request = { 0x24, 0x41, 0x01, 0x01 };

        public EtchASketch()
        {
            InitializeComponent();
            DisplayPictureBox.MouseMove += MainDisplayPictureBox_MouseStuff;
            MouseRadioButton.Enabled = true;
            PicStatuslabel.Text = "Mouse Mode";

            // Event handlers for Context Menu items
            ExitStripMenuItem.Click += ExitButton_Click;
            ClearStripMenuItem.Click += ClearButton_Click;
            DrawWaveformStripMenuItem.Click += DrawWaveformsButton_Click;
            SelectColorStripMenuItem.Click += SelectColorButton_Click;

            // Event handler for the Main Menu items
            ExitMainStripItem.Click += ExitButton_Click;
            ClearMainStripItem.Click += ClearButton_Click;
            DrawWaveformMainStripItem.Click += DrawWaveformsButton_Click;
            SelectColorMainStripItem.Click += SelectColorButton_Click;
            AboutMainStripItem.Click += AboutMainStripItem_Click;

            // Tooltips
            tips.SetToolTip(DisplayPictureBox, "Hold the left mouse button to draw; middle-click to select a color.");
            tips.SetToolTip(SelectColorButton, "Choose a pen color.");
            tips.SetToolTip(DrawWaveformsButton, "Draw a grid, sine, cosine, and tangent waves.");
            tips.SetToolTip(ClearButton, "Shake and clear the drawing.");
            tips.SetToolTip(ExitButton, "Close Etch-O-Sketch.");
            tips.SetToolTip(MouseRadioButton, "Draw using the mouse.");
            tips.SetToolTip(ExternalRadioButton, "Draw using two PIC potentiometers.");

            // PIC timer (automatic device identification)
            picTimer.Interval = 50;
            picTimer.Tick += PicTimer_Tick;
            picTimer.Start();

            // Close the PIC connection when the form closes
            this.FormClosing += BetterEtchOSketch_FormClosing;
        }

        async void SearchForPIC()
        {
            if (picScanning || picClosing || !ExternalRadioButton.Checked) return;
            picScanning = true;
            SerialPort? found = null;
            try
            {
                found = await Task.Run(FindPIC);
                if (picClosing || IsDisposed || !ExternalRadioButton.Checked)
                {
                    found?.Dispose();
                    return;
                }
                if (found == null)
                {
                    PicStatuslabel.Text = "PIC: Disconnected - searching...";
                    ShowPicError("No PIC was found. Check the USB cable, COM port, and firmware.\n" +
                                 "The program will keep searching in the background.");
                    nextPICScan = DateTime.Now.AddSeconds(2);
                }
                else
                {
                    picPort = found;
                    picWaiting = false;
                    requestedChannel = -1;
                    nextChannel = 0;
                    receivedBytes.Clear();
                    PicStatuslabel.Text = "PIC: Connected (" + found.PortName + ")";
                }
            }
            catch (Exception ex)
            {
                found?.Dispose();
                PicStatuslabel.Text = "PIC connection error: " + ex.Message;
                ShowPicError("Could not connect to the PIC:\n" + ex.Message);
                nextPICScan = DateTime.Now.AddSeconds(2);
            }
            finally { picScanning = false; }
        }

        // Check exact device ID before sending ADC requests
        SerialPort? FindPIC()
        {
            string[] ports;
            try { ports = SerialPort.GetPortNames(); }
            catch (Exception) { return null; }

            foreach (string name in ports)
            {
                if (picClosing) return null;
                SerialPort candidate = new SerialPort(name, 9600, Parity.None, 8, StopBits.One);
                bool accepted = false;
                try
                {
                    candidate.ReadTimeout = 50;
                    candidate.WriteTimeout = 500;
                    candidate.Open();
                    System.Threading.Thread.Sleep(100);
                    for (int attempt = 0; attempt < 2 && !accepted && !picClosing; attempt++)
                    {
                        candidate.DiscardInBuffer();
                        candidate.Write(IdRequest, 0, IdRequest.Length);
                        List<byte> reply = new List<byte>();
                        DateTime stop = DateTime.UtcNow.AddMilliseconds(500);
                        while (DateTime.UtcNow < stop && reply.Count < 5 && !picClosing)
                        {
                            try { reply.Add((byte)candidate.ReadByte()); }
                            catch (TimeoutException) { }
                        }
                        if (reply.Count == 5)
                        {
                            System.Threading.Thread.Sleep(50);
                            while (candidate.BytesToRead > 0 && reply.Count < 11)
                                reply.Add((byte)candidate.ReadByte());
                        }
                        accepted = reply.Count == IdReply.Length &&
                            reply.ToArray().AsSpan().SequenceEqual(IdReply);
                    }
                    if (accepted && !picClosing) return candidate;
                }
                catch (Exception) { }
                candidate.Dispose();
            }
            return null;
        }

        // Packet format: 24 command payloadLength payload...
        void ReceiveByte(byte value)
        {
            if (receivedBytes.Count == 0 && value != 0x24) return;
            receivedBytes.Add(value);
            if (receivedBytes.Count == 3 && receivedBytes[2] > 8)
            {
                receivedBytes.Clear();
                return;
            }
            if (receivedBytes.Count < 3 || receivedBytes.Count < receivedBytes[2] + 3) return;

            byte[] reply = receivedBytes.ToArray();
            receivedBytes.Clear();

            if (reply[1] == 0x45)
            {
                ClosePIC();
                PicStatuslabel.Text = "PIC: Disconnected - searching...";
                ShowPicError("The PIC reported a serial (UART) error. Reconnecting...");
                nextPICScan = DateTime.Now.AddSeconds(2);
                return;
            }
            if (!picWaiting || reply[1] != 0x41 || reply[2] != 3 ||
                reply[3] != requestedChannel) return;

            int adc = reply[4] * 256 + reply[5];
            if (adc > 1023) return;

            if (requestedChannel == 0) adcX = adc;
            else adcY = adc;
            picWaiting = false;
            adcFailures = 0;
            nextChannel = 1 - requestedChannel;
            if (requestedChannel == 1)
            {
                picErrorShown = false;
                DrawFromPIC();
            }
        }

        void DrawFromPIC()
        {
            if (!ExternalRadioButton.Checked || adcX < 0 || adcY < 0)
                return;

            int newX = adcX * (DisplayPictureBox.Width - 1) / 1023;
            int newY = adcY * (DisplayPictureBox.Height - 1) / 1023;

            if (picPointReady)
            {
                DrawLineSegment(newX, newY);
            }

            oldX = newX;
            oldY = newY;
            picPointReady = true;
        }

        // Request the next ADC value from the PIC, alternating between AN0 and AN1 channels
        void RequestADC()
        {
            if (picPort == null || !picPort.IsOpen || picWaiting) return;
            byte[] request = nextChannel == 0 ? AN0Request : AN1Request;
            requestedChannel = nextChannel;
            picPort.Write(request, 0, request.Length);
            picWaiting = true;
            picRequestTime = DateTime.Now;
        }

        // Close the serial port and reset variables when the PIC is disconnected or an error occurs
        void ClosePIC()
        {
            try { picPort?.Close(); picPort?.Dispose(); } catch (Exception) { }
            picPort = null;
            picWaiting = false;
            picPointReady = false;
            adcX = -1;
            adcY = -1;
            requestedChannel = -1;
            nextChannel = 0;
            receivedBytes.Clear();
        }

        // Shows a message box once per connection problem
        void ShowPicError(string message)
        {
            if (picErrorShown || picClosing || IsDisposed) return;
            picErrorShown = true;

            // BeginInvoke posts the box after the current handler finishes, so the
            // modal box can't re-enter the timer tick while it is open
            BeginInvoke(new Action(() =>
                MessageBox.Show(this, message, "PIC Connection Problem",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning)));
        }

        // Close the serial port when the application exits
        private void BetterEtchOSketch_FormClosing(object? sender, FormClosingEventArgs e)
        {
            picClosing = true;
            picTimer.Stop();
            ClosePIC();
        }
        void DrawLineSegment(int newx, int newy)
        {
            Graphics g = DisplayPictureBox.CreateGraphics();
            Pen thePen = new Pen(this.penColor);
            thePen.Width = this.penWidth;
            g.DrawLine(thePen, oldX, oldY, newx, newy);
            g.Dispose();
            thePen.Dispose();

        }

        void DrawSineWave()
        {
            //create a graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            //create a pen to draw with
            Pen thePen = new Pen(Color.Lime);
            int lastX = 0, lastY = 0, currentY = 0;
            float scaleX = DisplayPictureBox.Width / 360f;
            float scaleY = (DisplayPictureBox.Height / 200f) * -1;

            g.TranslateTransform(0, DisplayPictureBox.Height / 2);

            g.ScaleTransform(scaleX, scaleY);

            for (int currentX = 0; currentX < 360; currentX++)
            {
                currentY = (int)(Math.Round(100 * Math.Sin((Math.PI / 180) * currentX)));
                g.DrawLine(thePen, lastX, lastY, currentX, currentY);
                lastX = currentX;
                lastY = currentY;
            }

            //free up resorces
            g.Dispose();
            thePen.Dispose();
        }

        // Draws a cosine wave on the picture box
        void DrawCosineWave()
        {
            //create a graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            //create a pen to draw with
            Pen thePen = new Pen(Color.Red);
            int lastX = 0, lastY = 0, currentY = 0;
            float scaleX = DisplayPictureBox.Width / 360f;
            float scaleY = (DisplayPictureBox.Height / 200f) * -1;
            g.TranslateTransform(0, DisplayPictureBox.Height / 2);
            g.ScaleTransform(scaleX, scaleY);
            for (int currentX = 0; currentX < 360; currentX++)
            {
                currentY = (int)(Math.Round(100 * Math.Cos((Math.PI / 180) * currentX)));
                g.DrawLine(thePen, lastX, lastY, currentX, currentY);
                lastX = currentX;
                lastY = currentY;
            }
            //free up resorces
            g.Dispose();
            thePen.Dispose();
        }

        // Draws a tangent wave on the picture box
        void DrawTangentWave()
        {
            //create a graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            //create a pen to draw with
            Pen thePen = new Pen(Color.Blue);
            int lastX = 0, lastY = 0, currentY = 0;
            float scaleX = DisplayPictureBox.Width / 360f;
            float scaleY = (DisplayPictureBox.Height / 200f) * -1;
            g.TranslateTransform(0, DisplayPictureBox.Height / 2);
            g.ScaleTransform(scaleX, scaleY);
            for (int currentX = 0; currentX < 360; currentX++)
            {
                currentY = (int)(Math.Round(100 * Math.Tan((Math.PI / 180) * currentX)));
                if (Math.Abs(currentY) < DisplayPictureBox.Height / 2)
                {
                    g.DrawLine(thePen, lastX, lastY, currentX, currentY);
                }
                lastX = currentX;
                lastY = currentY;
            }
            //free up resorces
            g.Dispose();
            thePen.Dispose();
        }

        // Draws a grid on the picture box
        void DrawGrid()
        {
            int xDiv = DisplayPictureBox.Width / 10;
            int yDiv = DisplayPictureBox.Height / 10;

            this.oldX = 0;
            this.oldY = 0;
            for (int x = 0; x < DisplayPictureBox.Width; x += xDiv)
            {
                oldX = x;
                DrawLineSegment(x, DisplayPictureBox.Height);
            }

            this.oldX = 0;
            this.oldY = 0;
            for (int y = 0; y < DisplayPictureBox.Height; y += yDiv)
            {
                oldY = y;
                DrawLineSegment(DisplayPictureBox.Width, y);
            }
        }

        void ClearDrawing()
        {
            // create a graphics object named g that draws on the PictureBox
            Graphics g = DisplayPictureBox.CreateGraphics();

            // Shake the form
            var original = this.Location; // save the original position of the form
            var random = new Random(); // create a random number generator
            int shake_amplitude = 75; // how far the form should shake in pixels
            // play sound effect 
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("..\\..\\..\\Resources_shaker.wav");
            player.Play();

            for (int i = 0; i < 15; i++) // shake the form 15 times
            {
                // Randomly offset the form's position
                this.Location = new Point(
                    original.X + random.Next(-shake_amplitude, shake_amplitude), // shake horizontally
                    original.Y + random.Next(-shake_amplitude, shake_amplitude));// shake vertically
                System.Threading.Thread.Sleep(150); // Small pause for visibility
            }
            // clear the drawing by filling the picture box
            g.Clear(Color.White);
            // Reset to original position
            this.Location = original;

            // free up resources
            g.Dispose();
        }

        private void UpdatePenColor()
        {
            PenColorDialog.ShowDialog();
            this.penColor = PenColorDialog.Color;
        }


        //Event Handlers Start Here .......................................................
        private void SelectColorButton_Click(object sender, EventArgs e)
        {
            UpdatePenColor();
        }

        private void DrawWaveformsButton_Click(object sender, EventArgs e)
        {
            DisplayPictureBox.Refresh();
            DrawSineWave();
            DrawCosineWave();
            DrawTangentWave();
            DrawGrid();
            picPointReady = false;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearDrawing();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MouseRadioButton.Checked)
            {
                MouseControlEnabled = true;
                ExternalControlEnabled = false;
            }
        }

        private void ExternalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ExternalRadioButton.Checked)
            {
                ExternalControlEnabled = true;
                MouseControlEnabled = false;
            }
        }



        private void MainDisplayPictureBox_MouseStuff(object sender, MouseEventArgs e)
        {

            switch (e.Button)
            {
                case MouseButtons.Left:
                    DrawLineSegment(e.X, e.Y); // only draw when the left mouse button is down
                    break;
                case MouseButtons.Right:
                    // Save for context menu
                    break;
                case MouseButtons.Middle:
                    // TODO open color picker dialogue
                    break;
                default:
                    //MessageBox.Show($"{e.Button}");
                    break;
            }
            // save the current mouse position for the next time we draw a line segment
            this.oldX = e.X;
            this.oldY = e.Y;
        }

        private void DisplayPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void PicTimer_Tick(object sender, EventArgs e)
        {
            if (!ExternalRadioButton.Checked || picClosing) return;
            if (picPort == null || !picPort.IsOpen)
            {
                if (!picScanning && DateTime.Now >= nextPICScan) SearchForPIC();
                return;
            }
            try
            {
                while (picPort != null && picPort.IsOpen && picPort.BytesToRead > 0)
                {
                    ReceiveByte((byte)picPort.ReadByte());
                }

                if (picPort == null) return;

                // If the PIC is waiting for a reply and it has been more than 500 ms, consider it a failure
                if (picWaiting && (DateTime.Now - picRequestTime).TotalMilliseconds > 500)
                {
                    adcFailures++;
                    ClosePIC();
                    PicStatuslabel.Text = "PIC: Disconnected - searching...";
                    ShowPicError("The PIC stopped responding (ADC timeout). " +
                        "Check the AN0/AN1 wiring and firmware.");
                    nextPICScan = DateTime.Now.AddSeconds(2);
                    return;
                }

                if (!picWaiting)
                {
                    RequestADC();
                }
            }
            catch (Exception)
            {
                ClosePIC();
                PicStatuslabel.Text = "PIC: Disconnected - searching...";
                ShowPicError("The PIC was disconnected. Reconnecting...");
                nextPICScan = DateTime.Now.AddSeconds(2);
            }
        }

        private void SelectColorStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DrawWaveformStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ClearStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ExitStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AboutMainStripItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an EtchOSketch application, with basic drawing functionalities. \n" +
                "You can draw lines, select colors, and clear the screen. \n" +
                "This also allows a Sine, Cosine, and Tangent waves are drawn in different colors.");
        }
    }
}
