using System.IO.Ports;

namespace DataLogging2026
{
    public partial class Form1 : Form
    {
        // Carries commands and replies between the computer and PIC.
        SerialPort picPort = new SerialPort();

        // Holds incoming bytes until a complete packet is available.
        List<byte> pendingBytes = new List<byte>();

        // Tracks whether the PIC has passed the identification check.
        bool deviceConnected = false;
        string connectedPortName = "";

        // Prevents another request while a reply is still outstanding.
        bool awaitingReply = false;
        DateTime responseDeadline;

        // Controls when another connection attempt is allowed.
        DateTime nextConnectionAttempt = DateTime.Now;

        // Each reading contains an ADC value and its collection time.
        List<(int adc, DateTime time)> recordedSamples =
            new List<(int, DateTime)>();

        bool samplingEnabled = false;
        string lastSavedFile = "";

        // Only the most recent 2000 readings are retained and saved.
        const int SampleCapacity = 2000;

        public Form1()
        {
            // Create the controls declared in Form1.Designer.cs.
            InitializeComponent();

            // Fill dropdowns and connect the runtime events.
            ConfigureInterface();
        }

        void ConfigureInterface()
        {
            // These options match the order used in ReadSampleInterval().
            SampleRateComboBox.Items.AddRange(new object[]
            {
                "10 Minutes", "5 Minutes", "1 Minute", "30 Seconds",
                "10 Seconds", "5 Seconds", "1 Second", "500 ms",
                "200 ms", "100 ms"
            });

            // Start with one reading per second selected.
            SampleRateComboBox.SelectedIndex = 6;

            HistoryComboBox.Items.AddRange(new object[]
            {
                "Full History", "Last 30 Seconds"
            });

            // Initially show all retained readings.
            HistoryComboBox.SelectedIndex = 0;

            GraphPictureBox.BackColor = Color.White;
            GraphPictureBox.BorderStyle = BorderStyle.FixedSingle;

            // Windows calls this handler when the graph needs repainting.
            GraphPictureBox.Paint += GraphPictureBox_Paint;

            // Attach the graph's right-click menu.
            GraphPictureBox.ContextMenuStrip = GraphContextMenuStrip;

            // Initially check for a connection every 200 milliseconds.
            // Starting recording changes this to the chosen sample interval.
            MainTimer.Interval = 200;
            MainTimer.Tick += MainTimer_Tick;
            MainTimer.Start();

            RefreshStatus();
        }

        void RefreshStatus()
        {
            // Display only the filename rather than its full folder path.
            LogPathStatusLabel.Text = string.IsNullOrEmpty(lastSavedFile)
                ? "Log: None"
                : "Log: " + Path.GetFileName(lastSavedFile);

            // Use a placeholder if no sampling interval is selected.
            SampleRateStatusLabel.Text = "Rate: " +
                (SampleRateComboBox.SelectedItem?.ToString() ?? "---");

            ComPortsStatusLabel.Text = deviceConnected
                ? "COM: " + connectedPortName
                : "COM: not connected";
        }

        void WriteActivity(string message)
        {
            // Timestamp activity messages to help follow serial exchanges.
            string line =
                DateTime.Now.ToString("HH:mm:ss.fff") + "  " + message;

            ComListBox.Items.Add(line);

            // Scroll to the newest entry.
            ComListBox.TopIndex = ComListBox.Items.Count - 1;
        }

        void ExportReadings()
        {
            // Avoid creating an empty log.
            if (recordedSamples.Count == 0)
            {
                MessageBox.Show("Nothing to save yet.");
                return;
            }

            // Save beside the application's executable.
            string folder = Application.StartupPath;

            int number = 1;
            string fileName;

            // Find an unused numbered filename so earlier logs remain intact.
            do
            {
                fileName = Path.Combine(
                    folder,
                    "datalogged" + number + ".log");

                number++;
            }
            while (File.Exists(fileName));

            try
            {
                // The using block closes the file when writing finishes.
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(
                        "PIC Datalogger - " +
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                    writer.WriteLine(
                        "Format: $$AN1,HighByte,LowByte,Timestamp");

                    writer.WriteLine();

                    // Write one text record for every retained sample.
                    foreach (var s in recordedSamples)
                    {
                        // A ten-bit ADC reading is split into two bytes.
                        // The high byte contains only the upper two bits.
                        byte high = (byte)((s.adc >> 8) & 0x03);

                        // Mask off everything except the lower eight bits.
                        byte low = (byte)(s.adc & 0xFF);

                        // Include the sample time to hundredths of a second.
                        string stamp =
                            s.time.ToString("yy:MM:dd:HH:mm:ss:ff");

                        writer.WriteLine($"$$AN1,{high},{low},{stamp}");
                    }
                }

                // Remember the saved file for the status bar.
                lastSavedFile = fileName;

                WriteActivity("Saved → " + Path.GetFileName(fileName));
                RefreshStatus();

                MessageBox.Show(
                    "Saved as " + Path.GetFileName(fileName));
            }
            catch (Exception ex)
            {
                // Report file-access errors instead of closing the program.
                MessageBox.Show("Save failed: " + ex.Message);
            }
        }

        void BeginRecording()
        {
            // Sampling is allowed only after the PIC has been verified.
            if (!deviceConnected)
            {
                MessageBox.Show("No PIC connected.");
                return;
            }

            int ms = ReadSampleInterval();

            if (ms <= 0)
            {
                MessageBox.Show("Pick a sample rate first.");
                return;
            }

            // This timer handles both sampling and serial processing.
            MainTimer.Interval = ms;
            samplingEnabled = true;

            WriteActivity("Sampling started");
            RefreshStatus();
        }

        void PauseRecording()
        {
            // Preserve existing readings so they can still be graphed or saved.
            samplingEnabled = false;

            WriteActivity("Sampling stopped");
            RefreshStatus();
        }

        int ReadSampleInterval()
        {
            // Millisecond values correspond to the dropdown options in order.
            int[] intervals =
            {
                600000, 300000, 60000, 30000, 10000,
                5000, 1000, 500, 200, 100
            };

            int index = SampleRateComboBox.SelectedIndex;

            // SelectedIndex is -1 when nothing is selected.
            return index >= 0 && index < intervals.Length
                ? intervals[index]
                : 0;
        }

        void MainTimer_Tick(object sender, EventArgs e)
        {
            // Retry the connection when the scheduled retry time arrives.
            if (!deviceConnected)
            {
                if (DateTime.Now >= nextConnectionAttempt)
                    ConnectToDevice();

                return;
            }

            // Detect removal of the serial adapter.
            if (!ConnectedPortIsAvailable())
            {
                ResetConnection("COM port gone");
                return;
            }

            // Process received data before sending another request.
            ReceiveSerialData();

            // Keep only one reading request outstanding at a time.
            if (samplingEnabled && !awaitingReply)
                RequestReading();

            // The deadline is checked whenever this timer runs.
            if (awaitingReply && DateTime.Now > responseDeadline)
                ResetConnection("PIC timeout");
        }

        void ConnectToDevice()
        {
            // This version is configured to use COM6.
            string port = "COM6";

            WriteActivity("Trying " + port + "...");

            if (VerifyDevice(port))
            {
                deviceConnected = true;
                connectedPortName = port;

                // Display the port that successfully identified the PIC.
                PortsComboBox.Items.Clear();
                PortsComboBox.Items.Add(port);
                PortsComboBox.SelectedIndex = 0;

                WriteActivity("PIC found on " + port);
                RefreshStatus();
            }
            else
            {
                // Wait before trying again to avoid continuous retries.
                WriteActivity("COM6 failed");
                nextConnectionAttempt = DateTime.Now.AddSeconds(2);
            }
        }

        bool VerifyDevice(string portName)
        {
            try
            {
                // Close the previous connection before opening another.
                CloseSerialConnection();

                // Match the PIC's UART settings:
                // 9600 baud, no parity, eight data bits, one stop bit.
                picPort = new SerialPort(
                    portName,
                    9600,
                    Parity.None,
                    8,
                    StopBits.One);

                picPort.ReadTimeout = 300;
                picPort.WriteTimeout = 300;
                picPort.Open();

                // Remove stale data before the identification exchange.
                picPort.DiscardInBuffer();
                picPort.DiscardOutBuffer();

                // Identification request:
                // 0x24 = start marker
                // 0x49 = identification command
                // 0x00 = no payload
                picPort.Write(
                    new byte[] { 0x24, 0x49, 0x00 },
                    0,
                    3);

                // Allow time for the reply.
                // This also pauses the UI thread for 250 milliseconds.
                System.Threading.Thread.Sleep(250);

                int available = picPort.BytesToRead;

                // The expected identification response is five bytes long.
                if (available < 5)
                {
                    WriteActivity(
                        portName + " - only " + available + " bytes");

                    return false;
                }

                byte[] buf = new byte[available];
                picPort.Read(buf, 0, available);

                // Show raw hexadecimal bytes for troubleshooting.
                WriteActivity(
                    portName + " RX: " + BitConverter.ToString(buf));

                // Search for the response expected by LAB_8_Part_4_UART.
                // Searching every position allows for preceding extra bytes.
                for (int i = 0; i <= buf.Length - 5; i++)
                {
                    if (buf[i] == 0x24 &&
                        buf[i + 1] == 0x49 &&
                        buf[i + 2] == 0x02 &&
                        buf[i + 3] == 0x33 &&
                        buf[i + 4] == 0x75)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                // A missing or busy COM port can cause opening to fail.
                WriteActivity(portName + " error: " + ex.Message);
            }

            CloseSerialConnection();
            return false;
        }

        void RequestReading()
        {
            // Do not write unless the connection is available.
            if (!deviceConnected || picPort == null || !picPort.IsOpen)
                return;

            try
            {
                // Send the ADC request:
                // start marker, ADC command, payload length, channel payload.
                picPort.Write(
                    new byte[] { 0x24, 0x41, 0x01, 0x00 },
                    0,
                    4);

                awaitingReply = true;

                // Mark the request as overdue after 400 milliseconds.
                // MainTimer_Tick performs the actual timeout check.
                responseDeadline = DateTime.Now.AddMilliseconds(400);

                WriteActivity("TX ADC request");
            }
            catch
            {
                ResetConnection("Send failed");
            }
        }

        void ReceiveSerialData()
        {
            if (picPort == null || !picPort.IsOpen)
                return;

            try
            {
                // Append currently available bytes to the receive buffer.
                // A reply may arrive across more than one timer tick.
                while (picPort.BytesToRead > 0)
                {
                    int count = picPort.BytesToRead;
                    byte[] data = new byte[count];

                    picPort.Read(data, 0, count);
                    pendingBytes.AddRange(data);
                }

                // The buffer may contain more than one complete packet.
                while (TryExtractPacket(out byte[] packet))
                {
                    awaitingReply = false;
                    ProcessPacket(packet);
                }
            }
            catch
            {
                ResetConnection("Receive failed");
            }
        }

        bool TryExtractPacket(out byte[] packet)
        {
            packet = null;

            // Discard leading bytes until the start marker is found.
            while (pendingBytes.Count > 0 && pendingBytes[0] != 0x24)
                pendingBytes.RemoveAt(0);

            // A header requires a start marker, command, and payload length.
            if (pendingBytes.Count < 3)
                return false;

            // The third byte specifies how many payload bytes follow.
            int total = 3 + pendingBytes[2];

            // Leave incomplete packets buffered for a later read.
            // This version also rejects packet sizes above 64 bytes.
            if (total > 64 || pendingBytes.Count < total)
                return false;

            // Copy one complete packet out of the buffer.
            packet = pendingBytes.GetRange(0, total).ToArray();

            // Leave any following bytes for the next extraction.
            pendingBytes.RemoveRange(0, total);

            return true;
        }

        void ProcessPacket(byte[] packet)
        {
            WriteActivity("RX " + BitConverter.ToString(packet));

            // The expected ADC reply is: 24 41 03 00 HH LL.
            if (packet.Length == 6 && packet[1] == 0x41)
            {
                // Keep the upper two ADC bits and shift them into place.
                // Combine them with the lower eight bits to get 0–1023.
                int adc = ((packet[4] & 0x03) << 8) | packet[5];

                RecordReading(adc);
            }
        }

        void RecordReading(int adc)
        {
            // Ignore replies received after recording has been paused.
            if (!samplingEnabled)
                return;

            recordedSamples.Add((adc, DateTime.Now));

            // Remove the oldest reading when the storage limit is reached.
            if (recordedSamples.Count > SampleCapacity)
                recordedSamples.RemoveAt(0);

            ComListBox.Items.Add(
                DateTime.Now.ToString("HH:mm:ss.fff") +
                "  ADC = " + adc);

            ComListBox.TopIndex = ComListBox.Items.Count - 1;

            // Schedule a repaint using the updated readings.
            GraphPictureBox.Invalidate();
        }

        void ResetConnection(string reason)
        {
            deviceConnected = false;
            connectedPortName = "";
            awaitingReply = false;

            // Old partial packets must not carry into a new connection.
            pendingBytes.Clear();
            CloseSerialConnection();

            nextConnectionAttempt = DateTime.Now.AddSeconds(1);

            WriteActivity("Disconnected: " + reason);
            RefreshStatus();
        }

        void CloseSerialConnection()
        {
            try
            {
                if (picPort != null && picPort.IsOpen)
                    picPort.Close();
            }
            catch
            {
                // Ignore close errors if the connection is already unusable.
            }
        }

        bool ConnectedPortIsAvailable()
        {
            // Ask Windows whether the connected port is still listed.
            // Ignore capitalization differences in COM port names.
            return SerialPort.GetPortNames().Any(
                p => string.Equals(
                    p,
                    connectedPortName,
                    StringComparison.OrdinalIgnoreCase));
        }

        void GraphPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Clear the previous graph before drawing the current readings.
            g.Clear(Color.White);

            // At least two readings are needed to draw a connecting line.
            if (recordedSamples.Count < 2)
                return;

            List<(int adc, DateTime time)> points;

            if (HistoryComboBox.SelectedIndex == 1)
            {
                // Include only readings collected within the last 30 seconds.
                DateTime cutoff = DateTime.Now.AddSeconds(-30);

                points = recordedSamples
                    .Where(s => s.time >= cutoff)
                    .ToList();
            }
            else
            {
                // Full History means all readings currently retained.
                points = recordedSamples;
            }

            if (points.Count < 2)
                return;

            int w = GraphPictureBox.Width;
            int h = GraphPictureBox.Height;

            // Use the displayed readings to determine the vertical scale.
            int min = points.Min(p => p.adc);
            int max = points.Max(p => p.adc);

            // Prevent division by zero when all ADC values are identical.
            if (max == min)
                max = min + 1;

            // Release the pen's drawing resources after this repaint.
            using (Pen pen = new Pen(Color.Blue, 2))
            {
                Point prev = Point.Empty;

                for (int i = 0; i < points.Count; i++)
                {
                    // Space points evenly by index across the graph.
                    // Horizontal spacing does not use actual time differences.
                    int x = i * (w - 1) / (points.Count - 1);

                    // Scale the ADC value into the graph's pixel height.
                    // Invert Y because screen coordinates increase downward.
                    int y = h - 1 -
                        (points[i].adc - min) * (h - 1) / (max - min);

                    Point cur = new Point(x, y);

                    // The first point has no previous point to connect to.
                    if (i > 0)
                        g.DrawLine(pen, prev, cur);

                    prev = cur;
                }
            }
        }

        // These names match the event hookups in Form1.Designer.cs.
        // Buttons and context-menu items share the same recording methods.

        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Use the Sample Rate and History boxes on the form.");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            BeginRecording();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            PauseRecording();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ExportReadings();
        }

        private void SampleRateComboBox_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            // Apply a changed interval immediately during recording.
            if (samplingEnabled)
                MainTimer.Interval = ReadSampleInterval();

            RefreshStatus();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StartContextMenuItem_Click(object sender, EventArgs e)
        {
            BeginRecording();
        }

        private void StopContextMenuItem_Click(object sender, EventArgs e)
        {
            PauseRecording();
        }

        private void SaveContextMenuItem_Click(object sender, EventArgs e)
        {
            ExportReadings();
        }

        private void HistoryComboBox_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            // Redraw immediately when the visible history selection changes.
            GraphPictureBox.Invalidate();
        }
    }
}