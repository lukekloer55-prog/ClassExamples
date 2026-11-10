using System.IO.Ports;

namespace HVACSmartHomeController
{
    public partial class Form1 : Form
    {
        // Handles the serial commands used to communicate with the board.
        QyAtBoard board = new QyAtBoard();

        // Tracks the connection state used by the form's timer.
        bool boardConnected = false;

        // Prevents repeated connection attempts from filling the fault log
        // with the same communication error.
        bool commFaultLogged = false;

        // The timer may attempt a connection once this time is reached.
        DateTime nextConnectTry = DateTime.Now;

        // Group the input indicators so they can be updated with a loop.
        Label[] inputLabels = new Label[5];

        // These demand flags preserve their values between timer ticks.
        // Keeping the previous state within the temperature deadband
        // prevents rapid switching near a setpoint.
        bool wantHeat = false;
        bool wantCool = false;

        // Requested output states sent to the board.
        // These are software states, not feedback from the physical equipment.
        bool heating = false;
        bool cooling = false;
        bool fanOn = false;

        // Used to detect when heating or cooling demand ends.
        bool elementWasWanted = false;

        // Log an open interlock once until it closes again.
        bool interlockFaultLogged = false;

        // Start time for the fan's five-second startup delay.
        DateTime fanOnSince = DateTime.Now;

        // End time for the fan's five-second run-on period.
        DateTime fanKeepUntil = DateTime.MinValue;

        public Form1()
        {
            // Create the controls declared in the Designer file.
            InitializeComponent();

            // Restore settings and prepare the initial display.
            SetDefaults();

            // Apply the shared colors and button styling.
            ISUTheme();
        }

        void SetDefaults()
        {
            // Attempt to restore the port and temperature setpoints.
            if (!HvacSettings.Load())
            {
                MessageBox.Show(
                    "Could not read the settings file. Using the default settings.");
            }

            // Array order matches digital inputs 1 through 5.
            inputLabels = new Label[]
            {
                Input1Label,
                Input2Label,
                Input3Label,
                Input4Label,
                Input5Label
            };

            // Restrict selection to ports currently listed in the dropdown.
            PortToolStripComboBox.DropDownStyle =
                ComboBoxStyle.DropDownList;

            LoadPortList();

            // Show a twelve-hour clock with an AM/PM indicator.
            TimeLabel.Text = DateTime.Now.ToString("hh:mm tt");

            ShowSetpoints();

            // No sensor readings are available until the board connects.
            ShowDisconnected();
            ShowFaultState(false);
            ShowCommStatus("Searching for QY@ board...", false);
        }

        void ISUTheme()
        {
            BackColor = IsuColors.GrowlGreyLight;
            ForeColor = IsuColors.BengalBlack;

            TopMenuStrip.BackColor = IsuColors.Roarange;
            TopMenuStrip.ForeColor = IsuColors.BengalBlack;

            // Apply the same appearance to all four setpoint buttons.
            Button[] buttons =
            {
                HighUpButton,
                HighDownButton,
                LowUpButton,
                LowDownButton
            };

            foreach (Button button in buttons)
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.BackColor = IsuColors.Roarange;
                button.ForeColor = IsuColors.BengalBlack;
            }

            FaultListBox.BackColor = IsuColors.GrowlGreyMed;
            FaultListBox.ForeColor = IsuColors.BengalBlack;
            FaultListBox.BorderStyle = BorderStyle.None;
        }

        void LoadPortList()
        {
            // Rebuild the list so disconnected ports are removed.
            PortToolStripComboBox.Items.Clear();

            foreach (string name in SerialPort.GetPortNames())
            {
                PortToolStripComboBox.Items.Add(name);
            }

            // Prefer the active connection; otherwise use the saved port.
            string wanted = boardConnected
                ? board.PortName
                : HvacSettings.PortName;

            // Select it only if Windows currently lists that port.
            if (PortToolStripComboBox.Items.Contains(wanted))
            {
                PortToolStripComboBox.SelectedItem = wanted;
            }
        }

        void ShowSetpoints()
        {
            // F1 displays one digit after the decimal point.
            HighSetpointLabel.Text =
                "Cool to " +
                HvacSettings.HighSetpoint.ToString("F1") +
                " °F";

            LowSetpointLabel.Text =
                "Heat to " +
                HvacSettings.LowSetpoint.ToString("F1") +
                " °F";
        }

        void ShowCommStatus(string text, bool ok)
        {
            // Update both the message and its connection indicator.
            CommStatusLabel.Text = text;
            SetIndicator(CommStatusLabel, ok);
        }

        void ShowDisconnected()
        {
            // Replace old sensor values so stale data is not displayed
            // as though it were a current reading.
            CurrentTempLabel.Text = "***°F";
            UnitTempLabel.Text = "***°F";
            ModeLabel.Text = "Mode: ***";
            FanModeLabel.Text = "Fan mode: ***";
            FanStatusLabel.Text = "Fan: OFF";

            foreach (Label label in inputLabels)
            {
                SetIndicator(label, false);
            }

            // These changes reset the display only.
            // They do not send commands to the board.
            SetIndicator(Output1Label, false);
            SetIndicator(Output2Label, false);
            SetIndicator(Output3Label, false);
            SetIndicator(Output4Label, false);
            SetIndicator(Output5Label, false);
            SetIndicator(InterlockLabel, false);
            SetIndicator(PressureLabel, false);
            SetIndicator(FanStatusLabel, false);
        }

        void ShowReading(BoardReading reading)
        {
            // Convert the two raw ADC readings to temperatures.
            double homeTemp = Hvac.AdcToFahrenheit(reading.Analog1);
            double unitTemp = Hvac.AdcToFahrenheit(reading.Analog2);

            CurrentTempLabel.Text = homeTemp.ToString("F1") + " °F";
            UnitTempLabel.Text = unitTemp.ToString("F1") + " °F";

            // Each bit in this byte represents one digital input.
            byte inputs = reading.DigitalInputs;

            for (int i = 0; i < inputLabels.Length; i++)
            {
                // Array indexes start at zero, but input numbers start at one.
                SetIndicator(
                    inputLabels[i],
                    QyAtBoard.IsHigh(inputs, i + 1));
            }

            SetIndicator(
                InterlockLabel,
                QyAtBoard.IsHigh(inputs, IoMap.InterlockInput));

            // Pressure is displayed here but is not used by RunControl().
            SetIndicator(
                PressureLabel,
                QyAtBoard.IsHigh(inputs, IoMap.PressureInput));

            // Show the physical mode switch inputs.
            // RunControl() later updates this with the operating status.
            if (QyAtBoard.IsHigh(inputs, IoMap.HeatInput))
            {
                ModeLabel.Text = "Mode: HEAT";
            }
            else if (QyAtBoard.IsHigh(inputs, IoMap.CoolInput))
            {
                ModeLabel.Text = "Mode: COOL";
            }
            else
            {
                ModeLabel.Text = "Mode: OFF";
            }

            FanModeLabel.Text =
                QyAtBoard.IsHigh(inputs, IoMap.FanInput)
                ? "Fan mode: ON"
                : "Fan mode: AUTO";
        }

        void ReportFault(string description)
        {
            // Store a persistent copy of the fault.
            ErrorLog.Write(description);

            // Also display the fault with a timestamp for this session.
            FaultListBox.Items.Add(
                DateTime.Now.ToString("HH:mm:ss") +
                "  " + description);

            // Keep the newest fault visible.
            FaultListBox.TopIndex = FaultListBox.Items.Count - 1;

            ShowFaultState(true);
        }

        void ConnectToBoard()
        {
            ShowCommStatus("Searching for QY@ board...", false);

            // Repaint the message before the synchronous port search starts.
            CommStatusLabel.Refresh();

            // The board helper tries the preferred port before other ports.
            if (board.Connect(HvacSettings.PortName))
            {
                boardConnected = true;

                // A future communication failure should be logged again.
                commFaultLogged = false;

                // Remember the port that actually answered.
                HvacSettings.PortName = board.PortName;

                LoadPortList();

                ShowCommStatus(
                    "QY@ connected on " + board.PortName,
                    true);

                ShowFaultState(false);
            }
            else
            {
                ConnectionFailed(
                    "QY@ board not found - Attempting reconnect");
            }
        }

        void ReadBoard()
        {
            try
            {
                // Check both the open port and whether Windows still lists it.
                if (!board.IsConnected)
                {
                    throw new IOException(
                        "The QY@ board was unplugged.");
                }

                // Use one set of input readings for both display and control.
                BoardReading reading = board.ReadInputs();

                ShowReading(reading);
                RunControl(reading);
            }
            catch (Exception)
            {
                // Read failures and output-command failures reach this path.
                ConnectionFailed(
                    "Communication lost with QY@ board - Attempting reconnect");
            }
        }

        void ConnectionFailed(string description)
        {
            // Clear the controller's remembered demand and output states.
            // StopAll() does not itself transmit an output-off command.
            StopAll();

            interlockFaultLogged = false;
            boardConnected = false;
            board.Disconnect();

            // Avoid repeatedly scanning the ports on every timer tick.
            nextConnectTry = DateTime.Now.AddSeconds(10);

            ShowDisconnected();
            ShowCommStatus("COMM ERROR - retrying every 10 s", false);

            // Log once per communication outage.
            if (!commFaultLogged)
            {
                ReportFault(description);
                commFaultLogged = true;
            }
        }

        void ChangeHighSetpoint(double change)
        {
            // Apply the requested adjustment within the allowed 50–90°F range.
            HvacSettings.HighSetpoint = Hvac.ClampSetpoint(
                HvacSettings.HighSetpoint + change);

            ShowSetpoints();
        }

        void ChangeLowSetpoint(double change)
        {
            HvacSettings.LowSetpoint = Hvac.ClampSetpoint(
                HvacSettings.LowSetpoint + change);

            ShowSetpoints();
        }

        void SetIndicator(Label label, bool on)
        {
            // Ignore an unassigned label rather than dereferencing null.
            if (label == null)
                return;

            // Orange represents an active signal; grey represents inactive.
            label.BackColor = on
                ? IsuColors.Roarange
                : IsuColors.GrowlGreyMed;

            label.ForeColor = IsuColors.BengalBlack;
        }

        void ShowFaultState(bool hasFault)
        {
            FaultLabel.Text = hasFault ? "FAULT" : "OK";
            SetIndicator(FaultLabel, hasFault);
        }

        void StopAll()
        {
            // Reset software state only.
            // Actual output commands are sent separately.
            wantHeat = false;
            wantCool = false;
            heating = false;
            cooling = false;
            fanOn = false;
            elementWasWanted = false;

            // Cancel any remaining fan run-on period.
            fanKeepUntil = DateTime.MinValue;
        }

        void RunControl(BoardReading reading)
        {
            byte inputs = reading.DigitalInputs;

            // Decode the individual switch inputs from the input byte.
            bool interlockOk =
                QyAtBoard.IsHigh(inputs, IoMap.InterlockInput);

            bool heatEnabled =
                QyAtBoard.IsHigh(inputs, IoMap.HeatInput);

            bool coolEnabled =
                QyAtBoard.IsHigh(inputs, IoMap.CoolInput);

            bool fanOnlyMode =
                QyAtBoard.IsHigh(inputs, IoMap.FanInput);

            // Conflicting heat and cool selections disable both demands.
            // The fan is still handled by the fan logic below.
            if (heatEnabled && coolEnabled)
            {
                heatEnabled = false;
                coolEnabled = false;
            }

            // The home temperature controls heating and cooling demand.
            double homeTemp =
                Hvac.AdcToFahrenheit(reading.Analog1);

            if (!interlockOk)
            {
                // An open interlock clears heat, cool, and fan requests.
                // The resulting states are sent to the board below.
                StopAll();

                // Record the fault once while the interlock remains open.
                if (!interlockFaultLogged)
                {
                    ReportFault(
                        "Safety interlock switch LOW - Heating/Cooling disabled");

                    interlockFaultLogged = true;
                }
            }
            else
            {
                // Allow a new fault entry if the interlock opens again.
                interlockFaultLogged = false;

                if (heatEnabled)
                {
                    // Heating mode cannot request cooling.
                    wantCool = false;

                    // Start heating demand below the heating setpoint.
                    if (homeTemp < HvacSettings.LowSetpoint)
                    {
                        wantHeat = true;
                    }
                    // End demand at the setpoint plus the hysteresis value.
                    else if (
                        homeTemp >=
                        HvacSettings.LowSetpoint + Hvac.Hysteresis)
                    {
                        wantHeat = false;
                    }

                    // Between these thresholds, retain the previous demand.
                }
                else if (coolEnabled)
                {
                    // Cooling mode cannot request heating.
                    wantHeat = false;

                    // Start cooling demand above the cooling setpoint.
                    if (homeTemp > HvacSettings.HighSetpoint)
                    {
                        wantCool = true;
                    }
                    // End demand at the setpoint minus the hysteresis value.
                    else if (
                        homeTemp <=
                        HvacSettings.HighSetpoint - Hvac.Hysteresis)
                    {
                        wantCool = false;
                    }

                    // Between these thresholds, retain the previous demand.
                }
                else
                {
                    // Neither heating nor cooling mode is enabled.
                    wantHeat = false;
                    wantCool = false;
                }

                bool elementWanted = wantHeat || wantCool;

                // Detect the transition from demand to no demand.
                // Keep the fan running for five more seconds.
                if (elementWasWanted && !elementWanted)
                {
                    fanKeepUntil = DateTime.Now.AddSeconds(5);
                }

                // Save this tick's demand for comparison on the next tick.
                elementWasWanted = elementWanted;

                // Run the fan for manual fan mode, temperature demand,
                // or an unfinished run-on period.
                bool fanNeeded =
                    fanOnlyMode ||
                    elementWanted ||
                    DateTime.Now < fanKeepUntil;

                // Record the startup time only when the fan changes to ON.
                if (fanNeeded && !fanOn)
                {
                    fanOnSince = DateTime.Now;
                }

                fanOn = fanNeeded;

                // Heat and cool outputs require five seconds of commanded
                // fan operation. This does not measure physical airflow.
                bool fanReady =
                    fanOn &&
                    (DateTime.Now - fanOnSince).TotalSeconds >= 5;

                heating = wantHeat && fanReady;
                cooling = wantCool && fanReady;
            }

            // Send the requested states to the board.
            // SetOutput() avoids transmitting an unchanged output state.
            board.SetOutput(IoMap.WarningOutput, !interlockOk);
            board.SetOutput(IoMap.HeatOutput, heating);
            board.SetOutput(IoMap.CoolOutput, cooling);
            board.SetOutput(IoMap.FanOutput, fanOn);

            // Display the commanded output states.
            SetIndicator(Output1Label, !interlockOk);
            SetIndicator(Output2Label, heating);
            SetIndicator(Output3Label, cooling);
            SetIndicator(Output4Label, fanOn);

            FanStatusLabel.Text = fanOn ? "Fan: ON" : "Fan: OFF";
            SetIndicator(FanStatusLabel, fanOn);

            string mode = heatEnabled
                ? "HEAT"
                : (coolEnabled ? "COOL" : "OFF");

            if (!interlockOk)
            {
                ModeLabel.Text = "Mode: DISABLED";
            }
            else if (heating || cooling)
            {
                ModeLabel.Text = "Mode: " + mode + " - ON";
            }
            else if (mode != "OFF")
            {
                // Idle includes waiting for demand or the fan startup delay.
                ModeLabel.Text = "Mode: " + mode + " - idle";
            }
            else
            {
                ModeLabel.Text = "Mode: OFF";
            }

            SetIndicator(ModeLabel, heating || cooling);

            // During a successful control cycle, this reflects the interlock.
            // Previous fault entries remain in the list.
            ShowFaultState(!interlockOk);
        }

        // Event-handler names match the hookups in the Designer file.

        private void HighUpButton_Click(object sender, EventArgs e)
        {
            // Increase the cooling setpoint by one configured step.
            ChangeHighSetpoint(+Hvac.SetpointStep);
        }

        private void HighDownButton_Click(object sender, EventArgs e)
        {
            ChangeHighSetpoint(-Hvac.SetpointStep);
        }

        private void LowUpButton_Click(object sender, EventArgs e)
        {
            // Increase the heating setpoint by one configured step.
            ChangeLowSetpoint(+Hvac.SetpointStep);
        }

        private void LowDownButton_Click(object sender, EventArgs e)
        {
            ChangeLowSetpoint(-Hvac.SetpointStep);
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("hh:mm tt");

            if (boardConnected)
            {
                // Read sensors, update the display, and run the controller.
                ReadBoard();
            }
            else if (DateTime.Now >= nextConnectTry)
            {
                // Search again after the connection retry delay expires.
                ConnectToBoard();
            }
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            // Closing the form also invokes OnFormClosed().
            Close();
        }

        private void SaveSettingsMenuItem_Click(object sender, EventArgs e)
        {
            // Settings changes remain in memory until explicitly saved.
            if (HvacSettings.Save())
                MessageBox.Show("Settings saved.");
            else
                MessageBox.Show("Could not save settings.");
        }

        private void RescanPortsMenuItem_Click(object sender, EventArgs e)
        {
            // Refresh the available-port dropdown.
            LoadPortList();
        }

        private void PortToolStripComboBox_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            // Clearing or rebuilding the list may leave no selected item.
            if (PortToolStripComboBox.SelectedItem == null)
                return;

            string chosen = PortToolStripComboBox.Text;

            // Do not reconnect when the active port is selected again.
            if (chosen == "" ||
                (boardConnected && chosen == board.PortName))
            {
                return;
            }

            HvacSettings.PortName = chosen;

            // Close the old connection and let the timer start a new search.
            board.Disconnect();
            boardConnected = false;
            nextConnectTry = DateTime.Now;

            ShowDisconnected();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Stop polling before releasing the connection.
            MainTimer.Stop();

            try
            {
                if (boardConnected)
                {
                    // Attempt to switch all outputs off before disconnecting.
                    board.AllOutputsOff();
                }
            }
            catch (Exception)
            {
                // The command may fail if the board is already unavailable.
            }

            board.Disconnect();

            // Allow the base Form class to complete its close handling.
            base.OnFormClosed(e);
        }

        // Shared colors keep the interface styling in one place.
        public static class IsuColors
        {
            public static Color GrowlGreyLight =
                Color.FromArgb(230, 231, 232);

            public static Color GrowlGreyMed =
                Color.FromArgb(167, 167, 167);

            public static Color GrowlGrey =
                Color.FromArgb(130, 130, 130);

            public static Color Roarange =
                Color.FromArgb(244, 121, 32);

            public static Color RoarangeL =
                Color.FromArgb(246, 146, 64);

            public static Color BengalBlack =
                Color.FromArgb(0, 0, 0);
        }

        public static class HvacSettings
        {
            // Initial values used before a settings file is loaded.
            public static string PortName = "COM6";
            public static double HighSetpoint = 75.0;
            public static double LowSetpoint = 68.0;

            // This relative path starts from the process working directory.
            const string FileName = "..\\..\\..\\HVAC Settings.txt";

            public static bool Load()
            {
                try
                {
                    // A missing file is normal on the first run.
                    if (!File.Exists(FileName))
                        return true;

                    foreach (string line in File.ReadAllLines(FileName))
                    {
                        // Read the text after each setting's prefix.
                        if (line.StartsWith("Port="))
                        {
                            PortName = line.Substring(5).Trim();
                        }

                        if (line.StartsWith("High="))
                        {
                            // Clamp loaded values to the supported range.
                            HighSetpoint = Hvac.ClampSetpoint(
                                double.Parse(line.Substring(5)));
                        }

                        if (line.StartsWith("Low="))
                        {
                            LowSetpoint = Hvac.ClampSetpoint(
                                double.Parse(line.Substring(4)));
                        }
                    }

                    return true;
                }
                catch
                {
                    // Report a read or parsing failure.
                    // Values loaded before the failure remain assigned.
                    return false;
                }
            }

            public static bool Save()
            {
                try
                {
                    // Replace the settings file with the current values.
                    File.WriteAllLines(FileName, new[]
                    {
                        "Port=" + PortName,
                        "High=" + HighSetpoint.ToString("F1"),
                        "Low=" + LowSetpoint.ToString("F1")
                    });

                    return true;
                }
                catch
                {
                    // The caller displays a message if saving fails.
                    return false;
                }
            }
        }

        public static class ErrorLog
        {
            public static void Write(string description)
            {
                try
                {
                    // Each calendar date gets its own log filename.
                    string fileName =
                        "..\\..\\..\\HVACSystem-" +
                        DateTime.Now.ToString("yyMMdd") +
                        ".log";

                    string line =
                        DateTime.Now.ToString("yyMMdd-HHmmss") +
                        ": " + description;

                    // Append preserves earlier faults already in the file.
                    File.AppendAllText(
                        fileName,
                        line + Environment.NewLine);
                }
                catch
                {
                    // A logging failure does not interrupt the controller.
                }
            }
        }

        public static class Hvac
        {
            // Each setpoint button changes its value by half a degree.
            public const double SetpointStep = 0.5;

            // Separation between the demand-on and demand-off thresholds.
            public const double Hysteresis = 2.0;

            public static double AdcToFahrenheit(int adc)
            {
                // Apply this program's linear temperature mapping:
                // ADC 0 = 40°F and ADC 1023 = 100°F.
                return 40.0 + (adc * 60.0 / 1023.0);
            }

            public static double ClampSetpoint(double value)
            {
                // Limit each setpoint independently.
                // This does not enforce spacing between heat and cool settings.
                if (value < 50)
                    return 50;

                if (value > 90)
                    return 90;

                return value;
            }
        }

        public static class IoMap
        {
            // Hardware input numbers are one-based.
            public const int InterlockInput = 1;
            public const int HeatInput = 2;
            public const int FanInput = 3;
            public const int PressureInput = 4;
            public const int CoolInput = 5;

            // Named output assignments avoid repeated numeric literals.
            public const int WarningOutput = 1;
            public const int HeatOutput = 2;
            public const int CoolOutput = 3;
            public const int FanOutput = 4;
        }

        public class BoardReading
        {
            // One input transaction returns two ADC values
            // and a byte containing the digital input states.
            public int Analog1;
            public int Analog2;
            public byte DigitalInputs;
        }

        public class QyAtBoard
        {
            SerialPort port = new SerialPort();

            // Store all requested digital outputs in one byte.
            // Bit 0 corresponds to output 1, bit 1 to output 2, and so on.
            byte outputs = 0;

            // Invert the transmitted byte if the hardware requires
            // active-low output signals.
            public bool OutputsInverted = false;

            public string PortName
            {
                get { return port.PortName; }
            }

            public bool IsConnected
            {
                get
                {
                    // An open SerialPort alone may not reveal an unplugged
                    // device, so also check the ports Windows currently lists.
                    return port.IsOpen &&
                        Array.IndexOf(
                            SerialPort.GetPortNames(),
                            port.PortName) >= 0;
                }
            }

            public bool Connect(string preferredPort)
            {
                Disconnect();

                // Take a snapshot of the ports available for this search.
                List<string> ports =
                    new List<string>(SerialPort.GetPortNames());

                // Move the saved port to the front without duplicating it.
                if (preferredPort != "" && ports.Contains(preferredPort))
                {
                    ports.Remove(preferredPort);
                    ports.Insert(0, preferredPort);
                }

                foreach (string name in ports)
                {
                    if (TryPort(name))
                    {
                        // Stop searching after a matching board responds.
                        return true;
                    }
                }

                return false;
            }

            bool TryPort(string name)
            {
                try
                {
                    port.PortName = name;
                    port.BaudRate = 9600;
                    port.Open();

                    // Discard stale bytes before requesting identification.
                    port.DiscardInBuffer();

                    // Command 0xF0 requests the board's settings block.
                    port.Write(new byte[] { 0xF0 }, 0, 1);

                    byte[] settings = ReadBytes(64, 300);

                    // Look for ASCII "Qy@" at offsets 58, 59, and 60.
                    if (settings[58] == 81 &&
                        settings[59] == 121 &&
                        settings[60] == 64)
                    {
                        // Initialize the board with all logical outputs off.
                        outputs = 0;
                        SendOutputs();

                        return true;
                    }
                }
                catch (Exception)
                {
                    // A busy port, missing response, or other serial error
                    // makes this candidate unsuccessful.
                }

                Disconnect();
                return false;
            }

            public void Disconnect()
            {
                try
                {
                    // Closing the port releases it for another connection.
                    if (port.IsOpen)
                    {
                        port.Close();
                    }
                }
                catch (Exception)
                {
                    // The device may already have been unplugged.
                }
            }

            public BoardReading ReadInputs()
            {
                // 0x53 requests analog inputs 1 and 2.
                // 0x30 requests the digital input byte.
                Send(new byte[] { 0x53, 0x30 });

                // Expected response:
                // AN1: two bytes, AN2: two bytes, digital inputs: one byte.
                byte[] reply = ReadBytes(5, 300);

                BoardReading reading = new BoardReading();

                // Reconstruct each ten-bit ADC value.
                // The first byte supplies eight bits.
                // The upper two bits of the second byte supply the rest.
                reading.Analog1 =
                    (reply[0] << 2) | (reply[1] >> 6);

                reading.Analog2 =
                    (reply[2] << 2) | (reply[3] >> 6);

                reading.DigitalInputs = reply[4];

                return reading;
            }

            public void SetOutput(int number, bool on)
            {
                // Convert the one-based output number to a bit mask.
                // Example: output 3 becomes binary 00000100.
                byte mask = (byte)(1 << (number - 1));

                // OR sets the selected bit.
                // AND with the inverted mask clears only that bit.
                byte newState = on
                    ? (byte)(outputs | mask)
                    : (byte)(outputs & ~mask);

                // Skip serial traffic when the requested state is unchanged.
                if (newState == outputs)
                {
                    return;
                }

                outputs = newState;
                SendOutputs();
            }

            public void AllOutputsOff()
            {
                // Send the complete off state even if the cached byte is zero.
                outputs = 0;
                SendOutputs();
            }

            public static bool IsHigh(byte inputs, int bitNumber)
            {
                // Isolate the requested input bit.
                // A nonzero result means that input is HIGH.
                return (inputs & (1 << (bitNumber - 1))) != 0;
            }

            void SendOutputs()
            {
                // Apply optional inversion only to the transmitted value.
                // The cached outputs byte always uses logical ON/OFF states.
                byte data = OutputsInverted
                    ? (byte)~outputs
                    : outputs;

                // 0x20 is followed by the complete digital output byte.
                Send(new byte[] { 0x20, data });
            }

            void Send(byte[] data)
            {
                if (!port.IsOpen)
                {
                    throw new InvalidOperationException(
                        "Not connected to the QY@ board.");
                }

                // Remove unread bytes before starting the next transaction.
                port.DiscardInBuffer();

                port.Write(data, 0, data.Length);
            }

            byte[] ReadBytes(int count, int timeoutMilliseconds)
            {
                DateTime deadline =
                    DateTime.Now.AddMilliseconds(timeoutMilliseconds);

                // Wait until the expected number of bytes is available.
                // This is synchronous and blocks the calling thread.
                while (port.BytesToRead < count)
                {
                    if (DateTime.Now > deadline)
                    {
                        throw new TimeoutException(
                            "The QY@ board did not answer.");
                    }

                    // Briefly yield between checks instead of busy-spinning.
                    System.Threading.Thread.Sleep(1);
                }

                byte[] data = new byte[count];

                // Request the expected response bytes from the serial buffer.
                port.Read(data, 0, count);

                return data;
            }
        }
    }
}