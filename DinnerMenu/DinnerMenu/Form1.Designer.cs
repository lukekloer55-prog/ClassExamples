namespace DinnerMenu
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
            MainMenuLabel = new Label();
            SoupButton = new Button();
            SaladButton = new Button();
            FishButton = new Button();
            ExitButton = new Button();
            SpecialDisplayLabel = new Label();
            SuspendLayout();
            // 
            // MainMenuLabel
            // 
            MainMenuLabel.AutoSize = true;
            MainMenuLabel.Font = new Font("Vivaldi", 25.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            MainMenuLabel.Location = new Point(241, 9);
            MainMenuLabel.Name = "MainMenuLabel";
            MainMenuLabel.Size = new Size(255, 53);
            MainMenuLabel.TabIndex = 0;
            MainMenuLabel.Text = "Dinner Menu";
            MainMenuLabel.Click += label1_Click;
            // 
            // SoupButton
            // 
            SoupButton.Location = new Point(12, 357);
            SoupButton.Name = "SoupButton";
            SoupButton.Size = new Size(183, 81);
            SoupButton.TabIndex = 1;
            SoupButton.Text = "Soup";
            SoupButton.UseVisualStyleBackColor = true;
            // 
            // SaladButton
            // 
            SaladButton.Location = new Point(201, 357);
            SaladButton.Name = "SaladButton";
            SaladButton.Size = new Size(183, 81);
            SaladButton.TabIndex = 2;
            SaladButton.Text = "Salad";
            SaladButton.UseVisualStyleBackColor = true;
            // 
            // FishButton
            // 
            FishButton.Location = new Point(390, 357);
            FishButton.Name = "FishButton";
            FishButton.Size = new Size(183, 81);
            FishButton.TabIndex = 3;
            FishButton.Text = "Fish";
            FishButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(605, 357);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(183, 81);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // SpecialDisplayLabel
            // 
            SpecialDisplayLabel.AutoSize = true;
            SpecialDisplayLabel.Location = new Point(355, 183);
            SpecialDisplayLabel.Name = "SpecialDisplayLabel";
            SpecialDisplayLabel.Size = new Size(106, 20);
            SpecialDisplayLabel.TabIndex = 5;
            SpecialDisplayLabel.Text = "SpecialDisplay";
            SpecialDisplayLabel.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SpecialDisplayLabel);
            Controls.Add(ExitButton);
            Controls.Add(FishButton);
            Controls.Add(SaladButton);
            Controls.Add(SoupButton);
            Controls.Add(MainMenuLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainMenuLabel;
        private Button SoupButton;
        private Button SaladButton;
        private Button FishButton;
        private Button ExitButton;
        private Label SpecialDisplayLabel;
    }
}
