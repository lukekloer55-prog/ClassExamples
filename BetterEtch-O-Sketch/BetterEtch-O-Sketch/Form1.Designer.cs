namespace BetterEtch_O_Sketch
{
    partial class EtchASketch
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PenColorDialog = new ColorDialog();
            MouseRadioButton = new RadioButton();
            ExternalRadioButton = new RadioButton();
            DisplayPictureBox = new PictureBox();
            ContextMenuStrip = new ContextMenuStrip(components);
            fileToolStripMenuItem = new ToolStripMenuItem();
            ExitStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            SelectColorStripMenuItem = new ToolStripMenuItem();
            DrawWaveformStripMenuItem = new ToolStripMenuItem();
            ClearStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            SelectColorButton = new Button();
            DrawWaveformsButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            GetMousePoistionTimer = new System.Windows.Forms.Timer(components);
            StatusStrip = new StatusStrip();
            PicStatuslabel = new ToolStripStatusLabel();
            PicTimer = new System.Windows.Forms.Timer(components);
            DisplayMainMenuStrip = new MenuStrip();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            ExitMainStripItem = new ToolStripMenuItem();
            SelectColorMainStripItem = new ToolStripMenuItem();
            DrawWaveformMainStripItem = new ToolStripMenuItem();
            ClearMainStripItem = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            AboutMainStripItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            ContextMenuStrip.SuspendLayout();
            StatusStrip.SuspendLayout();
            DisplayMainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MouseRadioButton
            // 
            MouseRadioButton.AutoSize = true;
            MouseRadioButton.Location = new Point(23, 372);
            MouseRadioButton.Name = "MouseRadioButton";
            MouseRadioButton.Size = new Size(125, 19);
            MouseRadioButton.TabIndex = 0;
            MouseRadioButton.TabStop = true;
            MouseRadioButton.Text = "Mouse Draw Mode";
            MouseRadioButton.UseVisualStyleBackColor = true;
            MouseRadioButton.CheckedChanged += MouseRadioButton_CheckedChanged;
            // 
            // ExternalRadioButton
            // 
            ExternalRadioButton.AutoSize = true;
            ExternalRadioButton.Location = new Point(23, 397);
            ExternalRadioButton.Name = "ExternalRadioButton";
            ExternalRadioButton.Size = new Size(130, 19);
            ExternalRadioButton.TabIndex = 1;
            ExternalRadioButton.TabStop = true;
            ExternalRadioButton.Text = "External Draw Mode";
            ExternalRadioButton.UseVisualStyleBackColor = true;
            ExternalRadioButton.CheckedChanged += ExternalRadioButton_CheckedChanged;
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.BackColor = SystemColors.Window;
            DisplayPictureBox.Location = new Point(12, 24);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(765, 342);
            DisplayPictureBox.TabIndex = 2;
            DisplayPictureBox.TabStop = false;
            DisplayPictureBox.Click += DisplayPictureBox_Click;
            // 
            // ContextMenuStrip
            // 
            ContextMenuStrip.AllowClickThrough = true;
            ContextMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            ContextMenuStrip.Name = "contextMenuStrip1";
            ContextMenuStrip.Size = new Size(100, 70);
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ExitStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(99, 22);
            fileToolStripMenuItem.Text = "File";
            // 
            // ExitStripMenuItem
            // 
            ExitStripMenuItem.Name = "ExitStripMenuItem";
            ExitStripMenuItem.Size = new Size(92, 22);
            ExitStripMenuItem.Text = "Exit";
            ExitStripMenuItem.Click += ExitStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SelectColorStripMenuItem, DrawWaveformStripMenuItem, ClearStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(99, 22);
            editToolStripMenuItem.Text = "Edit";
            // 
            // SelectColorStripMenuItem
            // 
            SelectColorStripMenuItem.Name = "SelectColorStripMenuItem";
            SelectColorStripMenuItem.Size = new Size(164, 22);
            SelectColorStripMenuItem.Text = "Select Color";
            SelectColorStripMenuItem.Click += SelectColorStripMenuItem_Click;
            // 
            // DrawWaveformStripMenuItem
            // 
            DrawWaveformStripMenuItem.Name = "DrawWaveformStripMenuItem";
            DrawWaveformStripMenuItem.Size = new Size(164, 22);
            DrawWaveformStripMenuItem.Text = "Draw Waveforms";
            DrawWaveformStripMenuItem.Click += DrawWaveformStripMenuItem_Click;
            // 
            // ClearStripMenuItem
            // 
            ClearStripMenuItem.Name = "ClearStripMenuItem";
            ClearStripMenuItem.Size = new Size(164, 22);
            ClearStripMenuItem.Text = "Clear";
            ClearStripMenuItem.Click += ClearStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(99, 22);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // SelectColorButton
            // 
            SelectColorButton.Location = new Point(291, 372);
            SelectColorButton.Name = "SelectColorButton";
            SelectColorButton.Size = new Size(117, 35);
            SelectColorButton.TabIndex = 4;
            SelectColorButton.Text = "Select Color";
            SelectColorButton.UseVisualStyleBackColor = true;
            SelectColorButton.Click += SelectColorButton_Click;
            // 
            // DrawWaveformsButton
            // 
            DrawWaveformsButton.Location = new Point(414, 372);
            DrawWaveformsButton.Name = "DrawWaveformsButton";
            DrawWaveformsButton.Size = new Size(117, 35);
            DrawWaveformsButton.TabIndex = 5;
            DrawWaveformsButton.Text = "Draw Waveforms";
            DrawWaveformsButton.UseVisualStyleBackColor = true;
            DrawWaveformsButton.Click += DrawWaveformsButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(537, 372);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(117, 35);
            ClearButton.TabIndex = 6;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(660, 372);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(117, 35);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // StatusStrip
            // 
            StatusStrip.Items.AddRange(new ToolStripItem[] { PicStatuslabel });
            StatusStrip.Location = new Point(0, 422);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Size = new Size(789, 22);
            StatusStrip.TabIndex = 8;
            StatusStrip.Text = "statusStrip1";
            // 
            // PicStatuslabel
            // 
            PicStatuslabel.Name = "PicStatuslabel";
            PicStatuslabel.Size = new Size(118, 17);
            PicStatuslabel.Text = "toolStripStatusLabel1";
            // 
            // PicTimer
            // 
            PicTimer.Tick += PicTimer_Tick;
            // 
            // DisplayMainMenuStrip
            // 
            DisplayMainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem1 });
            DisplayMainMenuStrip.Location = new Point(0, 0);
            DisplayMainMenuStrip.Name = "DisplayMainMenuStrip";
            DisplayMainMenuStrip.Size = new Size(789, 24);
            DisplayMainMenuStrip.TabIndex = 9;
            DisplayMainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { ExitMainStripItem, SelectColorMainStripItem, DrawWaveformMainStripItem, ClearMainStripItem, helpToolStripMenuItem1 });
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(37, 20);
            fileToolStripMenuItem1.Text = "File";
            // 
            // ExitMainStripItem
            // 
            ExitMainStripItem.Name = "ExitMainStripItem";
            ExitMainStripItem.Size = new Size(180, 22);
            ExitMainStripItem.Text = "Exit";
            // 
            // SelectColorMainStripItem
            // 
            SelectColorMainStripItem.Name = "SelectColorMainStripItem";
            SelectColorMainStripItem.Size = new Size(180, 22);
            SelectColorMainStripItem.Text = "Select Color";
            // 
            // DrawWaveformMainStripItem
            // 
            DrawWaveformMainStripItem.Name = "DrawWaveformMainStripItem";
            DrawWaveformMainStripItem.Size = new Size(180, 22);
            DrawWaveformMainStripItem.Text = "Draw WaveForm";
            // 
            // ClearMainStripItem
            // 
            ClearMainStripItem.Name = "ClearMainStripItem";
            ClearMainStripItem.Size = new Size(180, 22);
            ClearMainStripItem.Text = "Clear";
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { AboutMainStripItem });
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(180, 22);
            helpToolStripMenuItem1.Text = "Help";
            // 
            // AboutMainStripItem
            // 
            AboutMainStripItem.Name = "AboutMainStripItem";
            AboutMainStripItem.Size = new Size(180, 22);
            AboutMainStripItem.Text = "About";
            AboutMainStripItem.Click += AboutMainStripItem_Click;
            // 
            // EtchASketch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 444);
            Controls.Add(StatusStrip);
            Controls.Add(DisplayMainMenuStrip);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(DrawWaveformsButton);
            Controls.Add(SelectColorButton);
            Controls.Add(DisplayPictureBox);
            Controls.Add(ExternalRadioButton);
            Controls.Add(MouseRadioButton);
            MainMenuStrip = DisplayMainMenuStrip;
            Name = "EtchASketch";
            Text = "Etch-A-Sketch";
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            ContextMenuStrip.ResumeLayout(false);
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
            DisplayMainMenuStrip.ResumeLayout(false);
            DisplayMainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ColorDialog PenColorDialog;
        private RadioButton MouseRadioButton;
        private RadioButton ExternalRadioButton;
        private PictureBox DisplayPictureBox;
        private ContextMenuStrip ContextMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem ExitStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem SelectColorStripMenuItem;
        private ToolStripMenuItem DrawWaveformStripMenuItem;
        private ToolStripMenuItem ClearStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button SelectColorButton;
        private Button DrawWaveformsButton;
        private Button ClearButton;
        private Button ExitButton;
        private System.Windows.Forms.Timer GetMousePoistionTimer;
        private StatusStrip StatusStrip;
        private ToolStripStatusLabel PicStatuslabel;
        private System.Windows.Forms.Timer PicTimer;
        private MenuStrip DisplayMainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem ExitMainStripItem;
        private ToolStripMenuItem SelectColorMainStripItem;
        private ToolStripMenuItem DrawWaveformMainStripItem;
        private ToolStripMenuItem ClearMainStripItem;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private ToolStripMenuItem AboutMainStripItem;
    }
}
