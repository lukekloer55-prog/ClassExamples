namespace DartBoard
{
    partial class DartGameSimulator
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
            ExitButton = new Button();
            ReviewButton = new Button();
            DisplaypictureBox = new PictureBox();
            StartRoundButton = new Button();
            LogFileComboBox = new ComboBox();
            toolTip1 = new ToolTip(components);
            gameStatusStrip = new StatusStrip();
            GameReviewLabel = new Label();
            statusLabel = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)DisplaypictureBox).BeginInit();
            gameStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(696, 377);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(100, 48);
            ExitButton.TabIndex = 3;
            ExitButton.TabStop = false;
            ExitButton.Text = "&Exit";
            toolTip1.SetToolTip(ExitButton, "Close the game.");
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ReviewButton
            // 
            ReviewButton.Location = new Point(590, 377);
            ReviewButton.Name = "ReviewButton";
            ReviewButton.Size = new Size(100, 48);
            ReviewButton.TabIndex = 2;
            ReviewButton.TabStop = false;
            ReviewButton.Text = "&Review";
            toolTip1.SetToolTip(ReviewButton, "Display the selected game's three darts.");
            ReviewButton.UseVisualStyleBackColor = true;
            ReviewButton.Click += ReviewButton_Click;
            // 
            // DisplaypictureBox
            // 
            DisplaypictureBox.Location = new Point(8, 12);
            DisplaypictureBox.Name = "DisplaypictureBox";
            DisplaypictureBox.Size = new Size(788, 356);
            DisplaypictureBox.TabIndex = 2;
            DisplaypictureBox.TabStop = false;
            // 
            // StartRoundButton
            // 
            StartRoundButton.Location = new Point(484, 377);
            StartRoundButton.Name = "StartRoundButton";
            StartRoundButton.Size = new Size(100, 48);
            StartRoundButton.TabIndex = 0;
            StartRoundButton.TabStop = false;
            StartRoundButton.Text = "&Start Round";
            toolTip1.SetToolTip(StartRoundButton, "Start a new round. Press Space to throw a dart.");
            StartRoundButton.UseVisualStyleBackColor = true;
            StartRoundButton.Click += StartRoundButton_Click;
            // 
            // LogFileComboBox
            // 
            LogFileComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LogFileComboBox.FormattingEnabled = true;
            LogFileComboBox.Location = new Point(14, 402);
            LogFileComboBox.Name = "LogFileComboBox";
            LogFileComboBox.Size = new Size(243, 23);
            LogFileComboBox.TabIndex = 1;
            toolTip1.SetToolTip(LogFileComboBox, "Choose a saved game to review.");
            // 
            // gameStatusStrip
            // 
            gameStatusStrip.Items.AddRange(new ToolStripItem[] { statusLabel });
            gameStatusStrip.Location = new Point(0, 428);
            gameStatusStrip.Name = "gameStatusStrip";
            gameStatusStrip.Size = new Size(808, 22);
            gameStatusStrip.TabIndex = 4;
            gameStatusStrip.Text = "Testing status";
            // 
            // GameReviewLabel
            // 
            GameReviewLabel.AutoSize = true;
            GameReviewLabel.Location = new Point(14, 384);
            GameReviewLabel.Name = "GameReviewLabel";
            GameReviewLabel.Size = new Size(129, 15);
            GameReviewLabel.TabIndex = 6;
            GameReviewLabel.Text = "Game Review Selection";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(118, 17);
            statusLabel.Text = "toolStripStatusLabel1";
            // 
            // DartGameSimulator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 450);
            Controls.Add(GameReviewLabel);
            Controls.Add(gameStatusStrip);
            Controls.Add(LogFileComboBox);
            Controls.Add(StartRoundButton);
            Controls.Add(DisplaypictureBox);
            Controls.Add(ReviewButton);
            Controls.Add(ExitButton);
            KeyPreview = true;
            Name = "DartGameSimulator";
            Text = "Dart Game Simulator";
            ((System.ComponentModel.ISupportInitialize)DisplaypictureBox).EndInit();
            gameStatusStrip.ResumeLayout(false);
            gameStatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitButton;
        private Button ReviewButton;
        private PictureBox DisplaypictureBox;
        private Button StartRoundButton;
        private ComboBox LogFileComboBox;
        private ToolTip toolTip1;
        private StatusStrip gameStatusStrip;
        private Label GameReviewLabel;
        private ToolStripStatusLabel statusLabel;
    }
}
