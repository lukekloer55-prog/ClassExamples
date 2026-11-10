namespace HVACSmartHomeController
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            TopMenuStrip = new System.Windows.Forms.MenuStrip();
            FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            SaveSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ConnectionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            RescanPortsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            PortToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();

            MainTimer = new System.Windows.Forms.Timer(components);

            TitleLabel = new System.Windows.Forms.Label();
            TimeLabel = new System.Windows.Forms.Label();
            CommStatusLabel = new System.Windows.Forms.Label();

            TemperatureGroupBox = new System.Windows.Forms.GroupBox();
            HomeCaptionLabel = new System.Windows.Forms.Label();
            UnitCaptionLabel = new System.Windows.Forms.Label();
            CurrentTempLabel = new System.Windows.Forms.Label();
            UnitTempLabel = new System.Windows.Forms.Label();

            SetpointsGroupBox = new System.Windows.Forms.GroupBox();
            HighSetpointLabel = new System.Windows.Forms.Label();
            LowSetpointLabel = new System.Windows.Forms.Label();
            HighUpButton = new System.Windows.Forms.Button();
            HighDownButton = new System.Windows.Forms.Button();
            LowUpButton = new System.Windows.Forms.Button();
            LowDownButton = new System.Windows.Forms.Button();

            OperationGroupBox = new System.Windows.Forms.GroupBox();
            ModeLabel = new System.Windows.Forms.Label();
            FanModeLabel = new System.Windows.Forms.Label();
            FanStatusLabel = new System.Windows.Forms.Label();
            InterlockLabel = new System.Windows.Forms.Label();
            PressureLabel = new System.Windows.Forms.Label();
            FaultLabel = new System.Windows.Forms.Label();

            InputsGroupBox = new System.Windows.Forms.GroupBox();
            Input1Label = new System.Windows.Forms.Label();
            Input2Label = new System.Windows.Forms.Label();
            Input3Label = new System.Windows.Forms.Label();
            Input4Label = new System.Windows.Forms.Label();
            Input5Label = new System.Windows.Forms.Label();

            OutputsGroupBox = new System.Windows.Forms.GroupBox();
            Output1Label = new System.Windows.Forms.Label();
            Output2Label = new System.Windows.Forms.Label();
            Output3Label = new System.Windows.Forms.Label();
            Output4Label = new System.Windows.Forms.Label();
            Output5Label = new System.Windows.Forms.Label();

            FaultLogCaptionLabel = new System.Windows.Forms.Label();
            FaultListBox = new System.Windows.Forms.ListBox();

            TopMenuStrip.SuspendLayout();
            TemperatureGroupBox.SuspendLayout();
            SetpointsGroupBox.SuspendLayout();
            OperationGroupBox.SuspendLayout();
            InputsGroupBox.SuspendLayout();
            OutputsGroupBox.SuspendLayout();
            SuspendLayout();

            // TopMenuStrip
            TopMenuStrip.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    FileMenuItem,
                    ConnectionMenuItem
                });
            TopMenuStrip.Location = new System.Drawing.Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Size = new System.Drawing.Size(940, 24);
            TopMenuStrip.TabIndex = 0;

            // FileMenuItem
            FileMenuItem.Name = "FileMenuItem";
            FileMenuItem.Text = "&File";
            FileMenuItem.DropDownItems.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    SaveSettingsMenuItem,
                    ExitMenuItem
                });

            // SaveSettingsMenuItem
            SaveSettingsMenuItem.Name = "SaveSettingsMenuItem";
            SaveSettingsMenuItem.Text = "&Save Settings";
            SaveSettingsMenuItem.Click += SaveSettingsMenuItem_Click;

            // ExitMenuItem
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Text = "E&xit";
            ExitMenuItem.Click += ExitMenuItem_Click;

            // ConnectionMenuItem
            ConnectionMenuItem.Name = "ConnectionMenuItem";
            ConnectionMenuItem.Text = "&Connection";
            ConnectionMenuItem.DropDownItems.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    RescanPortsMenuItem,
                    PortToolStripComboBox
                });

            // RescanPortsMenuItem
            RescanPortsMenuItem.Name = "RescanPortsMenuItem";
            RescanPortsMenuItem.Text = "&Rescan Ports";
            RescanPortsMenuItem.Click += RescanPortsMenuItem_Click;

            // PortToolStripComboBox
            PortToolStripComboBox.Name = "PortToolStripComboBox";
            PortToolStripComboBox.Size = new System.Drawing.Size(150, 23);
            PortToolStripComboBox.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            PortToolStripComboBox.SelectedIndexChanged +=
                PortToolStripComboBox_SelectedIndexChanged;

            // MainTimer
            MainTimer.Interval = 250;
            MainTimer.Tick += MainTimer_Tick;
            MainTimer.Enabled = true;

            // TitleLabel
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new System.Drawing.Font(
                "Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            TitleLabel.Location = new System.Drawing.Point(16, 38);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Text = "HVAC Smart Home Controller";

            // TimeLabel
            TimeLabel.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;
            TimeLabel.Font = new System.Drawing.Font(
                "Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            TimeLabel.Location = new System.Drawing.Point(764, 42);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new System.Drawing.Size(160, 32);
            TimeLabel.Text = "--:--";
            TimeLabel.TextAlign =
                System.Drawing.ContentAlignment.MiddleRight;

            // CommStatusLabel
            CommStatusLabel.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            CommStatusLabel.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            CommStatusLabel.Location = new System.Drawing.Point(16, 84);
            CommStatusLabel.Name = "CommStatusLabel";
            CommStatusLabel.Size = new System.Drawing.Size(908, 32);
            CommStatusLabel.Text = "Searching for QY@ board...";
            CommStatusLabel.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // TemperatureGroupBox
            TemperatureGroupBox.Controls.Add(HomeCaptionLabel);
            TemperatureGroupBox.Controls.Add(UnitCaptionLabel);
            TemperatureGroupBox.Controls.Add(CurrentTempLabel);
            TemperatureGroupBox.Controls.Add(UnitTempLabel);
            TemperatureGroupBox.Location = new System.Drawing.Point(16, 130);
            TemperatureGroupBox.Name = "TemperatureGroupBox";
            TemperatureGroupBox.Size = new System.Drawing.Size(440, 148);
            TemperatureGroupBox.TabIndex = 1;
            TemperatureGroupBox.TabStop = false;
            TemperatureGroupBox.Text = "Temperatures";

            // HomeCaptionLabel
            HomeCaptionLabel.Location = new System.Drawing.Point(16, 28);
            HomeCaptionLabel.Name = "HomeCaptionLabel";
            HomeCaptionLabel.Size = new System.Drawing.Size(195, 24);
            HomeCaptionLabel.Text = "Home temperature";
            HomeCaptionLabel.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // UnitCaptionLabel
            UnitCaptionLabel.Location = new System.Drawing.Point(229, 28);
            UnitCaptionLabel.Name = "UnitCaptionLabel";
            UnitCaptionLabel.Size = new System.Drawing.Size(195, 24);
            UnitCaptionLabel.Text = "Unit temperature";
            UnitCaptionLabel.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // CurrentTempLabel
            CurrentTempLabel.Font = new System.Drawing.Font(
                "Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            CurrentTempLabel.Location = new System.Drawing.Point(16, 60);
            CurrentTempLabel.Name = "CurrentTempLabel";
            CurrentTempLabel.Size = new System.Drawing.Size(195, 64);
            CurrentTempLabel.Text = "***°F";
            CurrentTempLabel.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // UnitTempLabel
            UnitTempLabel.Font = new System.Drawing.Font(
                "Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            UnitTempLabel.Location = new System.Drawing.Point(229, 60);
            UnitTempLabel.Name = "UnitTempLabel";
            UnitTempLabel.Size = new System.Drawing.Size(195, 64);
            UnitTempLabel.Text = "***°F";
            UnitTempLabel.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // SetpointsGroupBox
            SetpointsGroupBox.Controls.Add(HighSetpointLabel);
            SetpointsGroupBox.Controls.Add(LowSetpointLabel);
            SetpointsGroupBox.Controls.Add(HighUpButton);
            SetpointsGroupBox.Controls.Add(HighDownButton);
            SetpointsGroupBox.Controls.Add(LowUpButton);
            SetpointsGroupBox.Controls.Add(LowDownButton);
            SetpointsGroupBox.Location = new System.Drawing.Point(472, 130);
            SetpointsGroupBox.Name = "SetpointsGroupBox";
            SetpointsGroupBox.Size = new System.Drawing.Size(452, 148);
            SetpointsGroupBox.TabIndex = 2;
            SetpointsGroupBox.TabStop = false;
            SetpointsGroupBox.Text = "Temperature setpoints";

            // HighSetpointLabel
            HighSetpointLabel.Font = new System.Drawing.Font(
                "Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            HighSetpointLabel.Location = new System.Drawing.Point(16, 34);
            HighSetpointLabel.Name = "HighSetpointLabel";
            HighSetpointLabel.Size = new System.Drawing.Size(240, 32);
            HighSetpointLabel.Text = "Cool to 75.0 °F";
            HighSetpointLabel.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            // LowSetpointLabel
            LowSetpointLabel.Font = new System.Drawing.Font(
                "Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            LowSetpointLabel.Location = new System.Drawing.Point(16, 90);
            LowSetpointLabel.Name = "LowSetpointLabel";
            LowSetpointLabel.Size = new System.Drawing.Size(240, 32);
            LowSetpointLabel.Text = "Heat to 68.0 °F";
            LowSetpointLabel.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            // HighDownButton
            HighDownButton.Location = new System.Drawing.Point(278, 32);
            HighDownButton.Name = "HighDownButton";
            HighDownButton.Size = new System.Drawing.Size(72, 36);
            HighDownButton.TabIndex = 0;
            HighDownButton.Text = "− 0.5";
            HighDownButton.UseVisualStyleBackColor = true;
            HighDownButton.Click += HighDownButton_Click;

            // HighUpButton
            HighUpButton.Location = new System.Drawing.Point(362, 32);
            HighUpButton.Name = "HighUpButton";
            HighUpButton.Size = new System.Drawing.Size(72, 36);
            HighUpButton.TabIndex = 1;
            HighUpButton.Text = "+ 0.5";
            HighUpButton.UseVisualStyleBackColor = true;
            HighUpButton.Click += HighUpButton_Click;

            // LowDownButton
            LowDownButton.Location = new System.Drawing.Point(278, 88);
            LowDownButton.Name = "LowDownButton";
            LowDownButton.Size = new System.Drawing.Size(72, 36);
            LowDownButton.TabIndex = 2;
            LowDownButton.Text = "− 0.5";
            LowDownButton.UseVisualStyleBackColor = true;
            LowDownButton.Click += LowDownButton_Click;

            // LowUpButton
            LowUpButton.Location = new System.Drawing.Point(362, 88);
            LowUpButton.Name = "LowUpButton";
            LowUpButton.Size = new System.Drawing.Size(72, 36);
            LowUpButton.TabIndex = 3;
            LowUpButton.Text = "+ 0.5";
            LowUpButton.UseVisualStyleBackColor = true;
            LowUpButton.Click += LowUpButton_Click;

            // OperationGroupBox
            OperationGroupBox.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            OperationGroupBox.Controls.Add(ModeLabel);
            OperationGroupBox.Controls.Add(FanModeLabel);
            OperationGroupBox.Controls.Add(FanStatusLabel);
            OperationGroupBox.Controls.Add(InterlockLabel);
            OperationGroupBox.Controls.Add(PressureLabel);
            OperationGroupBox.Controls.Add(FaultLabel);
            OperationGroupBox.Location = new System.Drawing.Point(16, 292);
            OperationGroupBox.Name = "OperationGroupBox";
            OperationGroupBox.Size = new System.Drawing.Size(908, 120);
            OperationGroupBox.TabIndex = 3;
            OperationGroupBox.TabStop = false;
            OperationGroupBox.Text = "Operating status";

            // ModeLabel
            ModeLabel.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            ModeLabel.Location = new System.Drawing.Point(16, 28);
            ModeLabel.Name = "ModeLabel";
            ModeLabel.Size = new System.Drawing.Size(280, 32);
            ModeLabel.Text = "Mode: ***";
            ModeLabel.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // FanModeLabel
            FanModeLabel.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            FanModeLabel.Location = new System.Drawing.Point(312, 28);
            FanModeLabel.Name = "FanModeLabel";
            FanModeLabel.Size = new System.Drawing.Size(280, 32);
            FanModeLabel.Text = "Fan mode: ***";
            FanModeLabel.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // FanStatusLabel
            FanStatusLabel.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            FanStatusLabel.Location = new System.Drawing.Point(608, 28);
            FanStatusLabel.Name = "FanStatusLabel";
            FanStatusLabel.Size = new System.Drawing.Size(280, 32);
            FanStatusLabel.Text = "Fan: OFF";
            FanStatusLabel.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // InterlockLabel
            InterlockLabel.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            InterlockLabel.Location = new System.Drawing.Point(16, 72);
            InterlockLabel.Name = "InterlockLabel";
            InterlockLabel.Size = new System.Drawing.Size(280, 32);
            InterlockLabel.Text = "Safety interlock";
            InterlockLabel.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // PressureLabel
            PressureLabel.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            PressureLabel.Location = new System.Drawing.Point(312, 72);
            PressureLabel.Name = "PressureLabel";
            PressureLabel.Size = new System.Drawing.Size(280, 32);
            PressureLabel.Text = "Pressure input";
            PressureLabel.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // FaultLabel
            FaultLabel.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            FaultLabel.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            FaultLabel.Location = new System.Drawing.Point(608, 72);
            FaultLabel.Name = "FaultLabel";
            FaultLabel.Size = new System.Drawing.Size(280, 32);
            FaultLabel.Text = "OK";
            FaultLabel.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // InputsGroupBox
            InputsGroupBox.Controls.Add(Input1Label);
            InputsGroupBox.Controls.Add(Input2Label);
            InputsGroupBox.Controls.Add(Input3Label);
            InputsGroupBox.Controls.Add(Input4Label);
            InputsGroupBox.Controls.Add(Input5Label);
            InputsGroupBox.Location = new System.Drawing.Point(16, 426);
            InputsGroupBox.Name = "InputsGroupBox";
            InputsGroupBox.Size = new System.Drawing.Size(440, 96);
            InputsGroupBox.TabIndex = 4;
            InputsGroupBox.TabStop = false;
            InputsGroupBox.Text = "Digital inputs — orange = HIGH";

            // Input1Label
            Input1Label.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            Input1Label.Location = new System.Drawing.Point(12, 28);
            Input1Label.Name = "Input1Label";
            Input1Label.Size = new System.Drawing.Size(78, 52);
            Input1Label.Text = "IN 1\r\nInterlock";
            Input1Label.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // Input2Label
            Input2Label.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            Input2Label.Location = new System.Drawing.Point(96, 28);
            Input2Label.Name = "Input2Label";
            Input2Label.Size = new System.Drawing.Size(78, 52);
            Input2Label.Text = "IN 2\r\nHeat";
            Input2Label.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // Input3Label
            Input3Label.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            Input3Label.Location = new System.Drawing.Point(180, 28);
            Input3Label.Name = "Input3Label";
            Input3Label.Size = new System.Drawing.Size(78, 52);
            Input3Label.Text = "IN 3\r\nFan";
            Input3Label.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // Input4Label
            Input4Label.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            Input4Label.Location = new System.Drawing.Point(264, 28);
            Input4Label.Name = "Input4Label";
            Input4Label.Size = new System.Drawing.Size(78, 52);
            Input4Label.Text = "IN 4\r\nPressure";
            Input4Label.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // Input5Label
            Input5Label.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            Input5Label.Location = new System.Drawing.Point(348, 28);
            Input5Label.Name = "Input5Label";
            Input5Label.Size = new System.Drawing.Size(78, 52);
            Input5Label.Text = "IN 5\r\nCool";
            Input5Label.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // OutputsGroupBox
            OutputsGroupBox.Controls.Add(Output1Label);
            OutputsGroupBox.Controls.Add(Output2Label);
            OutputsGroupBox.Controls.Add(Output3Label);
            OutputsGroupBox.Controls.Add(Output4Label);
            OutputsGroupBox.Controls.Add(Output5Label);
            OutputsGroupBox.Location = new System.Drawing.Point(472, 426);
            OutputsGroupBox.Name = "OutputsGroupBox";
            OutputsGroupBox.Size = new System.Drawing.Size(452, 96);
            OutputsGroupBox.TabIndex = 5;
            OutputsGroupBox.TabStop = false;
            OutputsGroupBox.Text = "Commanded outputs — orange = ON";

            // Output1Label
            Output1Label.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            Output1Label.Location = new System.Drawing.Point(12, 28);
            Output1Label.Name = "Output1Label";
            Output1Label.Size = new System.Drawing.Size(80, 52);
            Output1Label.Text = "OUT 1\r\nWarning";
            Output1Label.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // Output2Label
            Output2Label.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            Output2Label.Location = new System.Drawing.Point(99, 28);
            Output2Label.Name = "Output2Label";
            Output2Label.Size = new System.Drawing.Size(80, 52);
            Output2Label.Text = "OUT 2\r\nHeat";
            Output2Label.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // Output3Label
            Output3Label.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            Output3Label.Location = new System.Drawing.Point(186, 28);
            Output3Label.Name = "Output3Label";
            Output3Label.Size = new System.Drawing.Size(80, 52);
            Output3Label.Text = "OUT 3\r\nCool";
            Output3Label.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // Output4Label
            Output4Label.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            Output4Label.Location = new System.Drawing.Point(273, 28);
            Output4Label.Name = "Output4Label";
            Output4Label.Size = new System.Drawing.Size(80, 52);
            Output4Label.Text = "OUT 4\r\nFan";
            Output4Label.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // Output5Label
            Output5Label.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            Output5Label.Location = new System.Drawing.Point(360, 28);
            Output5Label.Name = "Output5Label";
            Output5Label.Size = new System.Drawing.Size(80, 52);
            Output5Label.Text = "OUT 5\r\nUnused";
            Output5Label.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // FaultLogCaptionLabel
            FaultLogCaptionLabel.AutoSize = true;
            FaultLogCaptionLabel.Location = new System.Drawing.Point(16, 538);
            FaultLogCaptionLabel.Name = "FaultLogCaptionLabel";
            FaultLogCaptionLabel.Text = "Fault history";

            // FaultListBox
            FaultListBox.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            FaultListBox.FormattingEnabled = true;
            FaultListBox.HorizontalScrollbar = true;
            FaultListBox.IntegralHeight = false;
            FaultListBox.Location = new System.Drawing.Point(16, 562);
            FaultListBox.Name = "FaultListBox";
            FaultListBox.Size = new System.Drawing.Size(908, 132);
            FaultListBox.TabIndex = 6;

            // HVACcontroller
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(940, 710);
            MinimumSize = new System.Drawing.Size(956, 749);
            Controls.Add(TopMenuStrip);
            Controls.Add(TitleLabel);
            Controls.Add(TimeLabel);
            Controls.Add(CommStatusLabel);
            Controls.Add(TemperatureGroupBox);
            Controls.Add(SetpointsGroupBox);
            Controls.Add(OperationGroupBox);
            Controls.Add(InputsGroupBox);
            Controls.Add(OutputsGroupBox);
            Controls.Add(FaultLogCaptionLabel);
            Controls.Add(FaultListBox);
            MainMenuStrip = TopMenuStrip;
            Name = "HVACcontroller";
            StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "HVAC Smart Home Controller";

            TopMenuStrip.ResumeLayout(false);
            TopMenuStrip.PerformLayout();
            TemperatureGroupBox.ResumeLayout(false);
            SetpointsGroupBox.ResumeLayout(false);
            OperationGroupBox.ResumeLayout(false);
            InputsGroupBox.ResumeLayout(false);
            OutputsGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip TopMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveSettingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConnectionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RescanPortsMenuItem;
        private System.Windows.Forms.ToolStripComboBox PortToolStripComboBox;

        private System.Windows.Forms.Timer MainTimer;

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label CommStatusLabel;

        private System.Windows.Forms.GroupBox TemperatureGroupBox;
        private System.Windows.Forms.Label HomeCaptionLabel;
        private System.Windows.Forms.Label UnitCaptionLabel;
        private System.Windows.Forms.Label CurrentTempLabel;
        private System.Windows.Forms.Label UnitTempLabel;

        private System.Windows.Forms.GroupBox SetpointsGroupBox;
        private System.Windows.Forms.Label HighSetpointLabel;
        private System.Windows.Forms.Label LowSetpointLabel;
        private System.Windows.Forms.Button HighUpButton;
        private System.Windows.Forms.Button HighDownButton;
        private System.Windows.Forms.Button LowUpButton;
        private System.Windows.Forms.Button LowDownButton;

        private System.Windows.Forms.GroupBox OperationGroupBox;
        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.Label FanModeLabel;
        private System.Windows.Forms.Label FanStatusLabel;
        private System.Windows.Forms.Label InterlockLabel;
        private System.Windows.Forms.Label PressureLabel;
        private System.Windows.Forms.Label FaultLabel;

        private System.Windows.Forms.GroupBox InputsGroupBox;
        private System.Windows.Forms.Label Input1Label;
        private System.Windows.Forms.Label Input2Label;
        private System.Windows.Forms.Label Input3Label;
        private System.Windows.Forms.Label Input4Label;
        private System.Windows.Forms.Label Input5Label;

        private System.Windows.Forms.GroupBox OutputsGroupBox;
        private System.Windows.Forms.Label Output1Label;
        private System.Windows.Forms.Label Output2Label;
        private System.Windows.Forms.Label Output3Label;
        private System.Windows.Forms.Label Output4Label;
        private System.Windows.Forms.Label Output5Label;

        private System.Windows.Forms.Label FaultLogCaptionLabel;
        private System.Windows.Forms.ListBox FaultListBox;
    }
}