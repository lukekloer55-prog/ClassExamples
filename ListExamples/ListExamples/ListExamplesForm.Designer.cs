namespace ListExamples
{
    partial class ListExamplesForm
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
            ClearButton = new Button();
            SubmitButton = new Button();
            FirstNameLabel = new Label();
            FirstNameTextBox1 = new TextBox();
            InputGroupBox = new GroupBox();
            CompanyTextBox = new TextBox();
            ComapnyLabel = new Label();
            LastNameTextBox = new TextBox();
            LastNameLabel = new Label();
            OutputGroupBox = new GroupBox();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            InputGroupBox.SuspendLayout();
            OutputGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(676, 391);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(112, 48);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(558, 391);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(112, 48);
            ClearButton.TabIndex = 4;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(440, 391);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(112, 48);
            SubmitButton.TabIndex = 3;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(16, 29);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(36, 20);
            FirstNameLabel.TabIndex = 3;
            FirstNameLabel.Text = "First";
            // 
            // FirstNameTextBox1
            // 
            FirstNameTextBox1.Location = new Point(121, 26);
            FirstNameTextBox1.Name = "FirstNameTextBox1";
            FirstNameTextBox1.Size = new Size(125, 27);
            FirstNameTextBox1.TabIndex = 4;
            // 
            // InputGroupBox
            // 
            InputGroupBox.Controls.Add(CompanyTextBox);
            InputGroupBox.Controls.Add(ComapnyLabel);
            InputGroupBox.Controls.Add(LastNameTextBox);
            InputGroupBox.Controls.Add(LastNameLabel);
            InputGroupBox.Controls.Add(FirstNameTextBox1);
            InputGroupBox.Controls.Add(FirstNameLabel);
            InputGroupBox.Location = new Point(12, 12);
            InputGroupBox.Name = "InputGroupBox";
            InputGroupBox.Size = new Size(309, 175);
            InputGroupBox.TabIndex = 1;
            InputGroupBox.TabStop = false;
            // 
            // CompanyTextBox
            // 
            CompanyTextBox.Location = new Point(121, 92);
            CompanyTextBox.Name = "CompanyTextBox";
            CompanyTextBox.Size = new Size(125, 27);
            CompanyTextBox.TabIndex = 8;
            // 
            // ComapnyLabel
            // 
            ComapnyLabel.AutoSize = true;
            ComapnyLabel.Location = new Point(16, 95);
            ComapnyLabel.Name = "ComapnyLabel";
            ComapnyLabel.Size = new Size(72, 20);
            ComapnyLabel.TabIndex = 7;
            ComapnyLabel.Text = "Company";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(121, 59);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(125, 27);
            LastNameTextBox.TabIndex = 6;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(16, 62);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(35, 20);
            LastNameLabel.TabIndex = 5;
            LastNameLabel.Text = "Last";
            // 
            // OutputGroupBox
            // 
            OutputGroupBox.Controls.Add(listBox1);
            OutputGroupBox.Controls.Add(comboBox1);
            OutputGroupBox.Location = new Point(327, 12);
            OutputGroupBox.Name = "OutputGroupBox";
            OutputGroupBox.Size = new Size(461, 373);
            OutputGroupBox.TabIndex = 2;
            OutputGroupBox.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(15, 73);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(437, 284);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(108, 28);
            comboBox1.TabIndex = 0;
            // 
            // ListExamplesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OutputGroupBox);
            Controls.Add(InputGroupBox);
            Controls.Add(SubmitButton);
            Controls.Add(ClearButton);
            Controls.Add(ExitButton);
            Name = "ListExamplesForm";
            Text = "Form1";
            InputGroupBox.ResumeLayout(false);
            InputGroupBox.PerformLayout();
            OutputGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button ExitButton;
        private Button ClearButton;
        private Button SubmitButton;
        private Label FirstNameLabel;
        private TextBox FirstNameTextBox1;
        private GroupBox InputGroupBox;
        private TextBox CompanyTextBox;
        private Label ComapnyLabel;
        private TextBox LastNameTextBox;
        private Label LastNameLabel;
        private GroupBox OutputGroupBox;
        private ListBox listBox1;
        private ComboBox comboBox1;
    }
}
