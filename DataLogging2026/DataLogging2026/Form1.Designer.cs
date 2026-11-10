namespace DataLogging2026
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            StartButton = new Button();
            StopButton = new Button();
            SaveButton = new Button();
            SampleRateComboBox = new ComboBox();
            HistoryComboBox = new ComboBox();
            PortsComboBox = new ComboBox();
            SampleRateLabel = new Label();
            HistoryLabel = new Label();
            PortsLabel = new Label();
            GraphPictureBox = new PictureBox();
            GraphContextMenuStrip = new ContextMenuStrip(components);
            StartContextMenuItem = new ToolStripMenuItem();
            StopContextMenuItem = new ToolStripMenuItem();
            SaveContextMenuItem = new ToolStripMenuItem();
            ComListBox = new ListBox();
            MainTimer = new System.Windows.Forms.Timer(components);
            MainMenuStrip = new MenuStrip();
            SettingsMenuItem = new ToolStripMenuItem();
            ExitMenuItem = new ToolStripMenuItem();
            MainStatusStrip = new StatusStrip();
            LogPathStatusLabel = new ToolStripStatusLabel();
            SampleRateStatusLabel = new ToolStripStatusLabel();
            ComPortsStatusLabel = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)GraphPictureBox).BeginInit();
            GraphContextMenuStrip.SuspendLayout();
            MainMenuStrip.SuspendLayout();
            MainStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Location = new Point(12, 40);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(85, 30);
            StartButton.TabIndex = 1;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(103, 40);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(85, 30);
            StopButton.TabIndex = 2;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(194, 40);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(85, 30);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // SampleRateComboBox
            // 
            SampleRateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SampleRateComboBox.FormattingEnabled = true;
            SampleRateComboBox.Location = new Point(304, 47);
            SampleRateComboBox.Name = "SampleRateComboBox";
            SampleRateComboBox.Size = new Size(155, 23);
            SampleRateComboBox.TabIndex = 4;
            SampleRateComboBox.SelectedIndexChanged += SampleRateComboBox_SelectedIndexChanged;
            // 
            // HistoryComboBox
            // 
            HistoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            HistoryComboBox.FormattingEnabled = true;
            HistoryComboBox.Location = new Point(480, 47);
            HistoryComboBox.Name = "HistoryComboBox";
            HistoryComboBox.Size = new Size(175, 23);
            HistoryComboBox.TabIndex = 5;
            HistoryComboBox.SelectedIndexChanged += HistoryComboBox_SelectedIndexChanged;
            // 
            // PortsComboBox
            // 
            PortsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PortsComboBox.FormattingEnabled = true;
            PortsComboBox.Location = new Point(676, 47);
            PortsComboBox.Name = "PortsComboBox";
            PortsComboBox.Size = new Size(150, 23);
            PortsComboBox.TabIndex = 6;
            // 
            // SampleRateLabel
            // 
            SampleRateLabel.AutoSize = true;
            SampleRateLabel.Location = new Point(301, 28);
            SampleRateLabel.Name = "SampleRateLabel";
            SampleRateLabel.Size = new Size(69, 15);
            SampleRateLabel.TabIndex = 4;
            SampleRateLabel.Text = "Sample rate";
            // 
            // HistoryLabel
            // 
            HistoryLabel.AutoSize = true;
            HistoryLabel.Location = new Point(477, 28);
            HistoryLabel.Name = "HistoryLabel";
            HistoryLabel.Size = new Size(78, 15);
            HistoryLabel.TabIndex = 5;
            HistoryLabel.Text = "Graph history";
            // 
            // PortsLabel
            // 
            PortsLabel.AutoSize = true;
            PortsLabel.Location = new Point(673, 28);
            PortsLabel.Name = "PortsLabel";
            PortsLabel.Size = new Size(90, 15);
            PortsLabel.TabIndex = 6;
            PortsLabel.Text = "Connected port";
            // 
            // GraphPictureBox
            // 
            GraphPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GraphPictureBox.BackColor = Color.White;
            GraphPictureBox.BorderStyle = BorderStyle.FixedSingle;
            GraphPictureBox.ContextMenuStrip = GraphContextMenuStrip;
            GraphPictureBox.Location = new Point(12, 88);
            GraphPictureBox.Name = "GraphPictureBox";
            GraphPictureBox.Size = new Size(876, 300);
            GraphPictureBox.TabIndex = 7;
            GraphPictureBox.TabStop = false;
            // 
            // GraphContextMenuStrip
            // 
            GraphContextMenuStrip.Items.AddRange(new ToolStripItem[] { StartContextMenuItem, StopContextMenuItem, SaveContextMenuItem });
            GraphContextMenuStrip.Name = "GraphContextMenuStrip";
            GraphContextMenuStrip.Size = new Size(181, 92);
            // 
            // StartContextMenuItem
            // 
            StartContextMenuItem.Name = "StartContextMenuItem";
            StartContextMenuItem.Size = new Size(180, 22);
            StartContextMenuItem.Text = "Start";
            StartContextMenuItem.Click += StartContextMenuItem_Click;
            // 
            // StopContextMenuItem
            // 
            StopContextMenuItem.Name = "StopContextMenuItem";
            StopContextMenuItem.Size = new Size(180, 22);
            StopContextMenuItem.Text = "Stop";
            StopContextMenuItem.Click += StopContextMenuItem_Click;
            // 
            // SaveContextMenuItem
            // 
            SaveContextMenuItem.Name = "SaveContextMenuItem";
            SaveContextMenuItem.Size = new Size(180, 22);
            SaveContextMenuItem.Text = "Save";
            SaveContextMenuItem.Click += SaveContextMenuItem_Click;
            // 
            // ComListBox
            // 
            ComListBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ComListBox.FormattingEnabled = true;
            ComListBox.HorizontalScrollbar = true;
            ComListBox.IntegralHeight = false;
            ComListBox.Location = new Point(12, 400);
            ComListBox.Name = "ComListBox";
            ComListBox.Size = new Size(876, 160);
            ComListBox.TabIndex = 8;
            // 
            // MainTimer
            // 
            MainTimer.Interval = 200;
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { SettingsMenuItem, ExitMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new Size(900, 24);
            MainMenuStrip.TabIndex = 0;
            // 
            // SettingsMenuItem
            // 
            SettingsMenuItem.Name = "SettingsMenuItem";
            SettingsMenuItem.Size = new Size(61, 20);
            SettingsMenuItem.Text = "Settings";
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(37, 20);
            ExitMenuItem.Text = "Exit";
            ExitMenuItem.Click += ExitMenuItem_Click;
            // 
            // MainStatusStrip
            // 
            MainStatusStrip.Items.AddRange(new ToolStripItem[] { LogPathStatusLabel, SampleRateStatusLabel, ComPortsStatusLabel });
            MainStatusStrip.Location = new Point(0, 576);
            MainStatusStrip.Name = "MainStatusStrip";
            MainStatusStrip.Size = new Size(900, 24);
            MainStatusStrip.TabIndex = 9;
            // 
            // LogPathStatusLabel
            // 
            LogPathStatusLabel.Name = "LogPathStatusLabel";
            LogPathStatusLabel.Size = new Size(708, 19);
            LogPathStatusLabel.Spring = true;
            LogPathStatusLabel.Text = "Log: None";
            LogPathStatusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SampleRateStatusLabel
            // 
            SampleRateStatusLabel.BorderSides = ToolStripStatusLabelBorderSides.Left;
            SampleRateStatusLabel.Name = "SampleRateStatusLabel";
            SampleRateStatusLabel.Size = new Size(55, 19);
            SampleRateStatusLabel.Text = "Rate: ---";
            // 
            // ComPortsStatusLabel
            // 
            ComPortsStatusLabel.BorderSides = ToolStripStatusLabelBorderSides.Left;
            ComPortsStatusLabel.Name = "ComPortsStatusLabel";
            ComPortsStatusLabel.Size = new Size(122, 19);
            ComPortsStatusLabel.Text = "COM: not connected";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(StartButton);
            Controls.Add(StopButton);
            Controls.Add(SaveButton);
            Controls.Add(SampleRateLabel);
            Controls.Add(SampleRateComboBox);
            Controls.Add(HistoryLabel);
            Controls.Add(HistoryComboBox);
            Controls.Add(PortsLabel);
            Controls.Add(PortsComboBox);
            Controls.Add(GraphPictureBox);
            Controls.Add(ComListBox);
            Controls.Add(MainStatusStrip);
            Controls.Add(MainMenuStrip);
            MinimumSize = new Size(880, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PIC Data Logger";
            ((System.ComponentModel.ISupportInitialize)GraphPictureBox).EndInit();
            GraphContextMenuStrip.ResumeLayout(false);
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            MainStatusStrip.ResumeLayout(false);
            MainStatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button SaveButton;

        private System.Windows.Forms.ComboBox SampleRateComboBox;
        private System.Windows.Forms.ComboBox HistoryComboBox;
        private System.Windows.Forms.ComboBox PortsComboBox;

        private System.Windows.Forms.Label SampleRateLabel;
        private System.Windows.Forms.Label HistoryLabel;
        private System.Windows.Forms.Label PortsLabel;

        private System.Windows.Forms.PictureBox GraphPictureBox;
        private System.Windows.Forms.ListBox ComListBox;
        private System.Windows.Forms.Timer MainTimer;

        private new System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;

        private System.Windows.Forms.ContextMenuStrip GraphContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem StartContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveContextMenuItem;

        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel LogPathStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel SampleRateStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ComPortsStatusLabel;
    }
}