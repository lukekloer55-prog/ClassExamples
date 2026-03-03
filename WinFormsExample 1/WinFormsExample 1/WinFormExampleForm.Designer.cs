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
            FirstNameLabel = new Label();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            LastNameLabel = new Label();
            CityTextBox = new TextBox();
            CityLabel = new Label();
            AddressTextBox = new TextBox();
            StreetAddressLabel = new Label();
            ClearButton = new Button();
            UserInputBox = new GroupBox();
            ZipCodeBox = new TextBox();
            ZipCodeLabel = new Label();
            StateTextBox = new TextBox();
            StateLabel = new Label();
            groupBox2 = new GroupBox();
            FinalAddressLabel = new Label();
            UserInputBox.SuspendLayout();
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
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.CausesValidation = false;
            FirstNameLabel.Location = new Point(6, 34);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(80, 20);
            FirstNameLabel.TabIndex = 2;
            FirstNameLabel.Text = "First Name";
            FirstNameLabel.Click += NameLabel_Click;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(6, 54);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(209, 27);
            FirstNameTextBox.TabIndex = 0;
            FirstNameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(6, 107);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(209, 27);
            LastNameTextBox.TabIndex = 1;
            LastNameTextBox.Tag = "";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.CausesValidation = false;
            LastNameLabel.Location = new Point(7, 84);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(79, 20);
            LastNameLabel.TabIndex = 4;
            LastNameLabel.Text = "Last Name";
            LastNameLabel.Click += AgeLabel_Click;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(6, 213);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(209, 27);
            CityTextBox.TabIndex = 3;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.CausesValidation = false;
            CityLabel.Location = new Point(7, 190);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(34, 20);
            CityLabel.TabIndex = 6;
            CityLabel.Text = "City";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(6, 160);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(209, 27);
            AddressTextBox.TabIndex = 2;
            // 
            // StreetAddressLabel
            // 
            StreetAddressLabel.AutoSize = true;
            StreetAddressLabel.CausesValidation = false;
            StreetAddressLabel.Location = new Point(6, 137);
            StreetAddressLabel.Name = "StreetAddressLabel";
            StreetAddressLabel.Size = new Size(105, 20);
            StreetAddressLabel.TabIndex = 8;
            StreetAddressLabel.Text = "Street Address";
            StreetAddressLabel.Click += PhoneLabel_Click;
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
            UserInputBox.Controls.Add(ZipCodeBox);
            UserInputBox.Controls.Add(ZipCodeLabel);
            UserInputBox.Controls.Add(StateTextBox);
            UserInputBox.Controls.Add(StateLabel);
            UserInputBox.Controls.Add(FirstNameTextBox);
            UserInputBox.Controls.Add(CityTextBox);
            UserInputBox.Controls.Add(FirstNameLabel);
            UserInputBox.Controls.Add(CityLabel);
            UserInputBox.Controls.Add(AddressTextBox);
            UserInputBox.Controls.Add(LastNameTextBox);
            UserInputBox.Controls.Add(StreetAddressLabel);
            UserInputBox.Controls.Add(LastNameLabel);
            UserInputBox.Location = new Point(12, 12);
            UserInputBox.Name = "UserInputBox";
            UserInputBox.Size = new Size(302, 371);
            UserInputBox.TabIndex = 1;
            UserInputBox.TabStop = false;
            UserInputBox.Text = "UserInput";
            UserInputBox.Enter += groupBox1_Enter;
            // 
            // ZipCodeBox
            // 
            ZipCodeBox.Location = new Point(6, 319);
            ZipCodeBox.Name = "ZipCodeBox";
            ZipCodeBox.Size = new Size(209, 27);
            ZipCodeBox.TabIndex = 11;
            // 
            // ZipCodeLabel
            // 
            ZipCodeLabel.AutoSize = true;
            ZipCodeLabel.CausesValidation = false;
            ZipCodeLabel.Location = new Point(7, 296);
            ZipCodeLabel.Name = "ZipCodeLabel";
            ZipCodeLabel.Size = new Size(70, 20);
            ZipCodeLabel.TabIndex = 12;
            ZipCodeLabel.Text = "Zip Code";
            // 
            // StateTextBox
            // 
            StateTextBox.Location = new Point(6, 266);
            StateTextBox.Name = "StateTextBox";
            StateTextBox.Size = new Size(209, 27);
            StateTextBox.TabIndex = 9;
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.CausesValidation = false;
            StateLabel.Location = new Point(7, 243);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(43, 20);
            StateLabel.TabIndex = 10;
            StateLabel.Text = "State";
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
            // FinalAddressLabel
            // 
            FinalAddressLabel.Location = new Point(394, 24);
            FinalAddressLabel.Name = "FinalAddressLabel";
            FinalAddressLabel.Size = new Size(381, 318);
            FinalAddressLabel.TabIndex = 9;
            FinalAddressLabel.Text = "label1";
            // 
            // WinFormExampleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FinalAddressLabel);
            Controls.Add(groupBox2);
            Controls.Add(UserInputBox);
            Name = "WinFormExampleForm";
            UserInputBox.ResumeLayout(false);
            UserInputBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button ExitButton;
        private Button SubmitButton;
        private Label FirstNameLabel;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private Label LastNameLabel;
        private TextBox CityTextBox;
        private Label CityLabel;
        private TextBox AddressTextBox;
        private Label StreetAddressLabel;
        private Button ClearButton;
        private GroupBox UserInputBox;
        private GroupBox groupBox2;
        private TextBox ZipCodeBox;
        private Label ZipCodeLabel;
        private TextBox StateTextBox;
        private Label StateLabel;
        private Label FinalAddressLabel;
    }
}
