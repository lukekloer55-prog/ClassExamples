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
            MouseRadioButton = new RadioButton();
            ExternalRadioButton = new RadioButton();
            DisplayPictureBox = new PictureBox();
            ContextMenuStrip = new ContextMenuStrip(components);
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            selectColorToolStripMenuItem = new ToolStripMenuItem();
            drawWaveformsToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            SelectColorButton = new Button();
            DrawWaveformsButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            ContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MouseRadioButton
            // 
            MouseRadioButton.AutoSize = true;
            MouseRadioButton.Location = new Point(25, 388);
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
            ExternalRadioButton.Location = new Point(25, 413);
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
            DisplayPictureBox.Location = new Point(12, 35);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(765, 342);
            DisplayPictureBox.TabIndex = 2;
            DisplayPictureBox.TabStop = false;
            // 
            // ContextMenuStrip
            // 
            ContextMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            ContextMenuStrip.Name = "contextMenuStrip1";
            ContextMenuStrip.Size = new Size(100, 70);
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(99, 22);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(92, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectColorToolStripMenuItem, drawWaveformsToolStripMenuItem, clearToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(99, 22);
            editToolStripMenuItem.Text = "Edit";
            // 
            // selectColorToolStripMenuItem
            // 
            selectColorToolStripMenuItem.Name = "selectColorToolStripMenuItem";
            selectColorToolStripMenuItem.Size = new Size(164, 22);
            selectColorToolStripMenuItem.Text = "Select Color";
            // 
            // drawWaveformsToolStripMenuItem
            // 
            drawWaveformsToolStripMenuItem.Name = "drawWaveformsToolStripMenuItem";
            drawWaveformsToolStripMenuItem.Size = new Size(164, 22);
            drawWaveformsToolStripMenuItem.Text = "Draw Waveforms";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(164, 22);
            clearToolStripMenuItem.Text = "Clear";
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
            // 
            // SelectColorButton
            // 
            SelectColorButton.Location = new Point(291, 397);
            SelectColorButton.Name = "SelectColorButton";
            SelectColorButton.Size = new Size(117, 35);
            SelectColorButton.TabIndex = 4;
            SelectColorButton.Text = "Select Color";
            SelectColorButton.UseVisualStyleBackColor = true;
            SelectColorButton.Click += SelectColorButton_Click;
            // 
            // DrawWaveformsButton
            // 
            DrawWaveformsButton.Location = new Point(414, 397);
            DrawWaveformsButton.Name = "DrawWaveformsButton";
            DrawWaveformsButton.Size = new Size(117, 35);
            DrawWaveformsButton.TabIndex = 5;
            DrawWaveformsButton.Text = "Draw Waveforms";
            DrawWaveformsButton.UseVisualStyleBackColor = true;
            DrawWaveformsButton.Click += DrawWaveformsButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(537, 397);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(117, 35);
            ClearButton.TabIndex = 6;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(660, 397);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(117, 35);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // EtchASketch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 444);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(DrawWaveformsButton);
            Controls.Add(SelectColorButton);
            Controls.Add(DisplayPictureBox);
            Controls.Add(ExternalRadioButton);
            Controls.Add(MouseRadioButton);
            Name = "EtchASketch";
            Text = "Etch-A-Sketch";
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            ContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton MouseRadioButton;
        private RadioButton ExternalRadioButton;
        private PictureBox DisplayPictureBox;
        private ContextMenuStrip ContextMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem selectColorToolStripMenuItem;
        private ToolStripMenuItem drawWaveformsToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button SelectColorButton;
        private Button DrawWaveformsButton;
        private Button ClearButton;
        private Button ExitButton;
    }
}
