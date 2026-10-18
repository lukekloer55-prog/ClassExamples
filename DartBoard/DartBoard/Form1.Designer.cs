namespace DartBoard
{
    partial class Form1
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
            ExitButton = new Button();
            ReviewButton = new Button();
            DisplaypictureBox = new PictureBox();
            StartRoundButton = new Button();
            LogFileComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DisplaypictureBox).BeginInit();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(688, 390);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(100, 48);
            ExitButton.TabIndex = 0;
            ExitButton.TabStop = false;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ReviewButton
            // 
            ReviewButton.Location = new Point(582, 390);
            ReviewButton.Name = "ReviewButton";
            ReviewButton.Size = new Size(100, 48);
            ReviewButton.TabIndex = 1;
            ReviewButton.TabStop = false;
            ReviewButton.Text = "Review";
            ReviewButton.UseVisualStyleBackColor = true;
            ReviewButton.Click += ReviewButton_Click;
            // 
            // DisplaypictureBox
            // 
            DisplaypictureBox.Location = new Point(8, 5);
            DisplaypictureBox.Name = "DisplaypictureBox";
            DisplaypictureBox.Size = new Size(788, 379);
            DisplaypictureBox.TabIndex = 2;
            DisplaypictureBox.TabStop = false;
            // 
            // StartRoundButton
            // 
            StartRoundButton.Location = new Point(476, 390);
            StartRoundButton.Name = "StartRoundButton";
            StartRoundButton.Size = new Size(100, 48);
            StartRoundButton.TabIndex = 3;
            StartRoundButton.TabStop = false;
            StartRoundButton.Text = "Start Round";
            StartRoundButton.UseVisualStyleBackColor = true;
            StartRoundButton.Click += StartRoundButton_Click;
            // 
            // LogFileComboBox
            // 
            LogFileComboBox.FormattingEnabled = true;
            LogFileComboBox.Location = new Point(17, 399);
            LogFileComboBox.Name = "LogFileComboBox";
            LogFileComboBox.Size = new Size(187, 23);
            LogFileComboBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 450);
            Controls.Add(LogFileComboBox);
            Controls.Add(StartRoundButton);
            Controls.Add(DisplaypictureBox);
            Controls.Add(ReviewButton);
            Controls.Add(ExitButton);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DisplaypictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ExitButton;
        private Button ReviewButton;
        private PictureBox DisplaypictureBox;
        private Button StartRoundButton;
        private ComboBox LogFileComboBox;
    }
}
