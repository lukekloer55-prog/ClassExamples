namespace DinnerMenu
{
    partial class DinnerMenu
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
            ItemDisplayLabel = new Label();
            DescItemLabel = new Label();
            SuspendLayout();
            // 
            // MainMenuLabel
            // 
            MainMenuLabel.AutoSize = true;
            MainMenuLabel.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            MainMenuLabel.Location = new Point(211, 7);
            MainMenuLabel.Name = "MainMenuLabel";
            MainMenuLabel.Size = new Size(214, 39);
            MainMenuLabel.TabIndex = 0;
            MainMenuLabel.Text = "Dinner Menu";
            // 
            // SoupButton
            // 
            SoupButton.Location = new Point(10, 268);
            SoupButton.Margin = new Padding(3, 2, 3, 2);
            SoupButton.Name = "SoupButton";
            SoupButton.Size = new Size(160, 61);
            SoupButton.TabIndex = 1;
            SoupButton.Text = "Soup";
            SoupButton.UseVisualStyleBackColor = true;
            SoupButton.Click += SoupButton_Click;
            // 
            // SaladButton
            // 
            SaladButton.Location = new Point(176, 268);
            SaladButton.Margin = new Padding(3, 2, 3, 2);
            SaladButton.Name = "SaladButton";
            SaladButton.Size = new Size(160, 61);
            SaladButton.TabIndex = 2;
            SaladButton.Text = "Salad";
            SaladButton.UseVisualStyleBackColor = true;
            SaladButton.Click += SaladButton_Click;
            // 
            // FishButton
            // 
            FishButton.Location = new Point(341, 268);
            FishButton.Margin = new Padding(3, 2, 3, 2);
            FishButton.Name = "FishButton";
            FishButton.Size = new Size(160, 61);
            FishButton.TabIndex = 3;
            FishButton.Text = "Fish";
            FishButton.UseVisualStyleBackColor = true;
            FishButton.Click += FishButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(529, 268);
            ExitButton.Margin = new Padding(3, 2, 3, 2);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(160, 61);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ItemDisplayLabel
            // 
            ItemDisplayLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemDisplayLabel.Location = new Point(211, 82);
            ItemDisplayLabel.Name = "ItemDisplayLabel";
            ItemDisplayLabel.Size = new Size(214, 27);
            ItemDisplayLabel.TabIndex = 5;
            ItemDisplayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DescItemLabel
            // 
            DescItemLabel.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescItemLabel.Location = new Point(190, 109);
            DescItemLabel.Name = "DescItemLabel";
            DescItemLabel.Size = new Size(283, 134);
            DescItemLabel.TabIndex = 6;
            // 
            // DinnerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(DescItemLabel);
            Controls.Add(ItemDisplayLabel);
            Controls.Add(ExitButton);
            Controls.Add(FishButton);
            Controls.Add(SaladButton);
            Controls.Add(SoupButton);
            Controls.Add(MainMenuLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DinnerMenu";
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
        private Label ItemDisplayLabel;
        private Label DescItemLabel;
    }
}
