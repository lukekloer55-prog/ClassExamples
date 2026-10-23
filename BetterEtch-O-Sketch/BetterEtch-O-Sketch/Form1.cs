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

        public EtchASketch()
        {
            InitializeComponent();
            DisplayPictureBox.MouseMove += MainDisplayPictureBox_MouseStuff;
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

        
        //Event Handlers Start Here .......................................................
        private void SelectColorButton_Click(object sender, EventArgs e)
        {

        }

        private void DrawWaveformsButton_Click(object sender, EventArgs e)
        {

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
    }
}
