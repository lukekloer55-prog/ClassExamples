namespace WinFormsExample_1
{
    partial class WinFormExampleForm
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
            SubmitButton = new Button();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            AgeTextBox = new TextBox();
            AgeLabel = new Label();
            CityTextBox = new TextBox();
            CityLabel = new Label();
            PhoneTextBox = new TextBox();
            PhoneLabel = new Label();
            ClearButton = new Button();
            UserInputBox = new GroupBox();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            groupBox2 = new GroupBox();
            ReverseRadio = new RadioButton();
            LowerCaseRadio = new RadioButton();
            UpperCaseRadio = new RadioButton();
            UserInputBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(286, 26);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(127, 49);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(6, 26);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(134, 48);
            SubmitButton.TabIndex = 4;
            SubmitButton.Text = "&Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.CausesValidation = false;
            NameLabel.Location = new Point(8, 39);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 20);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(69, 36);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(209, 27);
            NameTextBox.TabIndex = 0;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(69, 69);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(209, 27);
            AgeTextBox.TabIndex = 1;
            AgeTextBox.Tag = "";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.CausesValidation = false;
            AgeLabel.Location = new Point(13, 72);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(36, 20);
            AgeLabel.TabIndex = 4;
            AgeLabel.Text = "Age";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(69, 135);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(209, 27);
            CityTextBox.TabIndex = 3;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.CausesValidation = false;
            CityLabel.Location = new Point(15, 138);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(34, 20);
            CityLabel.TabIndex = 6;
            CityLabel.Text = "City";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(69, 102);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(209, 27);
            PhoneTextBox.TabIndex = 2;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.CausesValidation = false;
            PhoneLabel.Location = new Point(7, 105);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(50, 20);
            PhoneLabel.TabIndex = 8;
            PhoneLabel.Text = "Phone";
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(146, 26);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(134, 48);
            ClearButton.TabIndex = 5;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // UserInputBox
            // 
            UserInputBox.Controls.Add(NameTextBox);
            UserInputBox.Controls.Add(CityTextBox);
            UserInputBox.Controls.Add(NameLabel);
            UserInputBox.Controls.Add(CityLabel);
            UserInputBox.Controls.Add(PhoneTextBox);
            UserInputBox.Controls.Add(AgeTextBox);
            UserInputBox.Controls.Add(PhoneLabel);
            UserInputBox.Controls.Add(AgeLabel);
            UserInputBox.Location = new Point(12, 12);
            UserInputBox.Name = "UserInputBox";
            UserInputBox.Size = new Size(295, 174);
            UserInputBox.TabIndex = 1;
            UserInputBox.TabStop = false;
            UserInputBox.Text = "UserInput";
            UserInputBox.Enter += groupBox1_Enter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Location = new Point(469, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 220);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(18, 165);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(117, 24);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(18, 135);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 24);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(18, 105);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(18, 69);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(101, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(18, 39);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(101, 24);
            checkBox4.TabIndex = 1;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(SubmitButton);
            groupBox2.Controls.Add(ClearButton);
            groupBox2.Controls.Add(ExitButton);
            groupBox2.Location = new Point(376, 363);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(421, 84);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // ReverseRadio
            // 
            ReverseRadio.AutoSize = true;
            ReverseRadio.Location = new Point(27, 302);
            ReverseRadio.Name = "ReverseRadio";
            ReverseRadio.Size = new Size(81, 24);
            ReverseRadio.TabIndex = 11;
            ReverseRadio.TabStop = true;
            ReverseRadio.Text = "Reverse";
            ReverseRadio.UseVisualStyleBackColor = true;
            // 
            // LowerCaseRadio
            // 
            LowerCaseRadio.AutoSize = true;
            LowerCaseRadio.Location = new Point(27, 272);
            LowerCaseRadio.Name = "LowerCaseRadio";
            LowerCaseRadio.Size = new Size(70, 24);
            LowerCaseRadio.TabIndex = 10;
            LowerCaseRadio.TabStop = true;
            LowerCaseRadio.Text = "Lower";
            LowerCaseRadio.UseVisualStyleBackColor = true;
            // 
            // UpperCaseRadio
            // 
            UpperCaseRadio.AutoSize = true;
            UpperCaseRadio.Location = new Point(27, 242);
            UpperCaseRadio.Name = "UpperCaseRadio";
            UpperCaseRadio.Size = new Size(71, 24);
            UpperCaseRadio.TabIndex = 9;
            UpperCaseRadio.TabStop = true;
            UpperCaseRadio.Text = "Upper";
            UpperCaseRadio.UseVisualStyleBackColor = true;
            
            // 
            // WinFormExampleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReverseRadio);
            Controls.Add(LowerCaseRadio);
            Controls.Add(UpperCaseRadio);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(UserInputBox);
            Name = "WinFormExampleForm";
            UserInputBox.ResumeLayout(false);
            UserInputBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitButton;
        private Button SubmitButton;
        private Label NameLabel;
        private TextBox NameTextBox;
        private TextBox AgeTextBox;
        private Label AgeLabel;
        private TextBox CityTextBox;
        private Label CityLabel;
        private TextBox PhoneTextBox;
        private Label PhoneLabel;
        private Button ClearButton;
        private GroupBox UserInputBox;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private GroupBox groupBox2;
        private RadioButton ReverseRadio;
        private RadioButton LowerCaseRadio;
        private RadioButton UpperCaseRadio;
    }
}
