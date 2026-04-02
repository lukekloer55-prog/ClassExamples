namespace RollTheDiceListBox
{
    partial class RollOfTheDice
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
            ResultsListBox = new ListBox();
            ExitButton = new Button();
            ClearButton = new Button();
            RollButton = new Button();
            SuspendLayout();
            // 
            // ResultsListBox
            // 
            ResultsListBox.Font = new Font("Source Code Pro", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResultsListBox.FormattingEnabled = true;
            ResultsListBox.Location = new Point(12, 18);
            ResultsListBox.Name = "ResultsListBox";
            ResultsListBox.Size = new Size(775, 324);
            ResultsListBox.TabIndex = 0;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(637, 360);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(151, 78);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(480, 360);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(151, 78);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // RollButton
            // 
            RollButton.Location = new Point(323, 360);
            RollButton.Name = "RollButton";
            RollButton.Size = new Size(151, 78);
            RollButton.TabIndex = 3;
            RollButton.Text = "Roll";
            RollButton.UseVisualStyleBackColor = true;
            RollButton.Click += RollButton_Click;
            // 
            // RollOfTheDice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RollButton);
            Controls.Add(ClearButton);
            Controls.Add(ExitButton);
            Controls.Add(ResultsListBox);
            Name = "RollOfTheDice";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox ResultsListBox;
        private Button ExitButton;
        private Button ClearButton;
        private Button RollButton;
    }
}
