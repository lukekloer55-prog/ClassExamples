namespace WinFormsExample_1
{
    partial class AddressLabel
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
            DisplayLabelButton = new Button();
            FirstNameLabel = new Label();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            LastNameLabel = new Label();
            CityTextBox = new TextBox();
            CityLabel = new Label();
            AddressTextBox = new TextBox();
            StreetAddressLabel = new Label();
            ClearButton = new Button();
            MailingAddressGroupBox = new GroupBox();
            ZipCodeBox = new TextBox();
            ZipCodeLabel = new Label();
            StateTextBox = new TextBox();
            StateLabel = new Label();
            groupBox2 = new GroupBox();
            FinalAddressLabel = new Label();
            AddressLabelFinalGroupBox = new GroupBox();
            MailingAddressGroupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            AddressLabelFinalGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(250, 20);
            ExitButton.Margin = new Padding(3, 2, 3, 2);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(111, 37);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // DisplayLabelButton
            // 
            DisplayLabelButton.Location = new Point(5, 20);
            DisplayLabelButton.Margin = new Padding(3, 2, 3, 2);
            DisplayLabelButton.Name = "DisplayLabelButton";
            DisplayLabelButton.Size = new Size(117, 36);
            DisplayLabelButton.TabIndex = 4;
            DisplayLabelButton.Text = "&Display Label";
            DisplayLabelButton.UseVisualStyleBackColor = true;
            DisplayLabelButton.Click += SubmitButton_Click;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.CausesValidation = false;
            FirstNameLabel.Location = new Point(6, 36);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(64, 15);
            FirstNameLabel.TabIndex = 2;
            FirstNameLabel.Text = "First Name";
           
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(6, 53);
            FirstNameTextBox.Margin = new Padding(3, 2, 3, 2);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(247, 23);
            FirstNameTextBox.TabIndex = 0;
            FirstNameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(6, 95);
            LastNameTextBox.Margin = new Padding(3, 2, 3, 2);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(247, 23);
            LastNameTextBox.TabIndex = 1;
            LastNameTextBox.Tag = "";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.CausesValidation = false;
            LastNameLabel.Location = new Point(5, 78);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(63, 15);
            LastNameLabel.TabIndex = 4;
            LastNameLabel.Text = "Last Name";
            
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(6, 179);
            CityTextBox.Margin = new Padding(3, 2, 3, 2);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(247, 23);
            CityTextBox.TabIndex = 3;
            
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.CausesValidation = false;
            CityLabel.Location = new Point(6, 162);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(28, 15);
            CityLabel.TabIndex = 6;
            CityLabel.Text = "City";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(5, 137);
            AddressTextBox.Margin = new Padding(3, 2, 3, 2);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(248, 23);
            AddressTextBox.TabIndex = 2;
            // 
            // StreetAddressLabel
            // 
            StreetAddressLabel.AutoSize = true;
            StreetAddressLabel.CausesValidation = false;
            StreetAddressLabel.Location = new Point(6, 120);
            StreetAddressLabel.Name = "StreetAddressLabel";
            StreetAddressLabel.Size = new Size(82, 15);
            StreetAddressLabel.TabIndex = 8;
            StreetAddressLabel.Text = "Street Address";
            
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(128, 20);
            ClearButton.Margin = new Padding(3, 2, 3, 2);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(117, 36);
            ClearButton.TabIndex = 5;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // MailingAddressGroupBox
            // 
            MailingAddressGroupBox.Controls.Add(ZipCodeBox);
            MailingAddressGroupBox.Controls.Add(ZipCodeLabel);
            MailingAddressGroupBox.Controls.Add(StateTextBox);
            MailingAddressGroupBox.Controls.Add(StateLabel);
            MailingAddressGroupBox.Controls.Add(FirstNameTextBox);
            MailingAddressGroupBox.Controls.Add(CityTextBox);
            MailingAddressGroupBox.Controls.Add(FirstNameLabel);
            MailingAddressGroupBox.Controls.Add(CityLabel);
            MailingAddressGroupBox.Controls.Add(AddressTextBox);
            MailingAddressGroupBox.Controls.Add(LastNameTextBox);
            MailingAddressGroupBox.Controls.Add(StreetAddressLabel);
            MailingAddressGroupBox.Controls.Add(LastNameLabel);
            MailingAddressGroupBox.Location = new Point(10, 9);
            MailingAddressGroupBox.Margin = new Padding(3, 2, 3, 2);
            MailingAddressGroupBox.Name = "MailingAddressGroupBox";
            MailingAddressGroupBox.Padding = new Padding(3, 2, 3, 2);
            MailingAddressGroupBox.Size = new Size(313, 326);
            MailingAddressGroupBox.TabIndex = 1;
            MailingAddressGroupBox.TabStop = false;
            MailingAddressGroupBox.Text = "Mailing Address";
            MailingAddressGroupBox.Enter += groupBox1_Enter;
            // 
            // ZipCodeBox
            // 
            ZipCodeBox.Location = new Point(6, 273);
            ZipCodeBox.Margin = new Padding(3, 2, 3, 2);
            ZipCodeBox.Name = "ZipCodeBox";
            ZipCodeBox.Size = new Size(111, 23);
            ZipCodeBox.TabIndex = 11;
            // 
            // ZipCodeLabel
            // 
            ZipCodeLabel.AutoSize = true;
            ZipCodeLabel.CausesValidation = false;
            ZipCodeLabel.Location = new Point(6, 256);
            ZipCodeLabel.Name = "ZipCodeLabel";
            ZipCodeLabel.Size = new Size(55, 15);
            ZipCodeLabel.TabIndex = 12;
            ZipCodeLabel.Text = "Zip Code";
            // 
            // StateTextBox
            // 
            StateTextBox.Location = new Point(6, 231);
            StateTextBox.Margin = new Padding(3, 2, 3, 2);
            StateTextBox.Name = "StateTextBox";
            StateTextBox.Size = new Size(111, 23);
            StateTextBox.TabIndex = 9;
            
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.CausesValidation = false;
            StateLabel.Location = new Point(6, 214);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(33, 15);
            StateLabel.TabIndex = 10;
            StateLabel.Text = "State";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DisplayLabelButton);
            groupBox2.Controls.Add(ClearButton);
            groupBox2.Controls.Add(ExitButton);
            groupBox2.Location = new Point(329, 272);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(368, 63);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // FinalAddressLabel
            // 
            FinalAddressLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FinalAddressLabel.Location = new Point(6, 19);
            FinalAddressLabel.Name = "FinalAddressLabel";
            FinalAddressLabel.Size = new Size(347, 253);
            FinalAddressLabel.TabIndex = 9;
            FinalAddressLabel.Text = "label1";
            // 
            // AddressLabelFinalGroupBox
            // 
            AddressLabelFinalGroupBox.Controls.Add(FinalAddressLabel);
            AddressLabelFinalGroupBox.Location = new Point(329, 12);
            AddressLabelFinalGroupBox.Name = "AddressLabelFinalGroupBox";
            AddressLabelFinalGroupBox.Size = new Size(359, 275);
            AddressLabelFinalGroupBox.TabIndex = 10;
            AddressLabelFinalGroupBox.TabStop = false;
            AddressLabelFinalGroupBox.Text = "AddressLabel";
            // 
            // WinFormExampleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(AddressLabelFinalGroupBox);
            Controls.Add(groupBox2);
            Controls.Add(MailingAddressGroupBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "WinFormExampleForm";
            MailingAddressGroupBox.ResumeLayout(false);
            MailingAddressGroupBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            AddressLabelFinalGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button ExitButton;
        private Button DisplayLabelButton;
        private Label FirstNameLabel;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private Label LastNameLabel;
        private TextBox CityTextBox;
        private Label CityLabel;
        private TextBox AddressTextBox;
        private Label StreetAddressLabel;
        private Button ClearButton;
        private GroupBox MailingAddressGroupBox;
        private GroupBox groupBox2;
        private TextBox ZipCodeBox;
        private Label ZipCodeLabel;
        private TextBox StateTextBox;
        private Label StateLabel;
        private Label FinalAddressLabel;
        private GroupBox AddressLabelFinalGroupBox;
    }
}
