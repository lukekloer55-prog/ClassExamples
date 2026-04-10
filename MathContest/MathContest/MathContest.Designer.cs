namespace MathContest
{
    partial class MathContest
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
            StudentInformationGroupBox = new GroupBox();
            GradeLabel = new Label();
            AgeLabel = new Label();
            GradeTextBox = new TextBox();
            AgeTextBox = new TextBox();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            CurrentProblemGroupBox = new GroupBox();
            StudentAnswerLabel = new Label();
            StudentTextBox = new TextBox();
            SecondNumberLabel = new Label();
            SecondNumberTextBox = new TextBox();
            FirstNumberLabel = new Label();
            FirstNumberTextBox = new TextBox();
            MathTypeGroupBox = new GroupBox();
            DivideRadioButton = new RadioButton();
            MultiplyRadioButton = new RadioButton();
            SubtractRadioButton = new RadioButton();
            AddRadioButton = new RadioButton();
            ButtonGroupBox = new GroupBox();
            ExitButton = new Button();
            SummaryButton = new Button();
            ClearButton = new Button();
            SubmitButton = new Button();
            StudentInformationGroupBox.SuspendLayout();
            CurrentProblemGroupBox.SuspendLayout();
            MathTypeGroupBox.SuspendLayout();
            ButtonGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // StudentInformationGroupBox
            // 
            StudentInformationGroupBox.Controls.Add(GradeLabel);
            StudentInformationGroupBox.Controls.Add(AgeLabel);
            StudentInformationGroupBox.Controls.Add(GradeTextBox);
            StudentInformationGroupBox.Controls.Add(AgeTextBox);
            StudentInformationGroupBox.Controls.Add(NameLabel);
            StudentInformationGroupBox.Controls.Add(NameTextBox);
            StudentInformationGroupBox.Location = new Point(12, 12);
            StudentInformationGroupBox.Name = "StudentInformationGroupBox";
            StudentInformationGroupBox.Size = new Size(456, 112);
            StudentInformationGroupBox.TabIndex = 0;
            StudentInformationGroupBox.TabStop = false;
            StudentInformationGroupBox.Text = "Student Information";
            // 
            // GradeLabel
            // 
            GradeLabel.AutoSize = true;
            GradeLabel.Location = new Point(384, 46);
            GradeLabel.Name = "GradeLabel";
            GradeLabel.Size = new Size(49, 20);
            GradeLabel.TabIndex = 9;
            GradeLabel.Text = "Grade";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(314, 46);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(36, 20);
            AgeLabel.TabIndex = 8;
            AgeLabel.Text = "Age";
            // 
            // GradeTextBox
            // 
            GradeTextBox.Location = new Point(385, 69);
            GradeTextBox.Name = "GradeTextBox";
            GradeTextBox.Size = new Size(48, 27);
            GradeTextBox.TabIndex = 7;
            GradeTextBox.TextChanged += GradeTextBox_TextChanged;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(314, 69);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(36, 27);
            AgeTextBox.TabIndex = 6;
            AgeTextBox.TextChanged += AgeTextBox_TextChanged;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(6, 46);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 20);
            NameLabel.TabIndex = 5;
            NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(6, 69);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(269, 27);
            NameTextBox.TabIndex = 5;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // CurrentProblemGroupBox
            // 
            CurrentProblemGroupBox.Controls.Add(StudentAnswerLabel);
            CurrentProblemGroupBox.Controls.Add(StudentTextBox);
            CurrentProblemGroupBox.Controls.Add(SecondNumberLabel);
            CurrentProblemGroupBox.Controls.Add(SecondNumberTextBox);
            CurrentProblemGroupBox.Controls.Add(FirstNumberLabel);
            CurrentProblemGroupBox.Controls.Add(FirstNumberTextBox);
            CurrentProblemGroupBox.Location = new Point(12, 130);
            CurrentProblemGroupBox.Name = "CurrentProblemGroupBox";
            CurrentProblemGroupBox.Size = new Size(275, 308);
            CurrentProblemGroupBox.TabIndex = 1;
            CurrentProblemGroupBox.TabStop = false;
            CurrentProblemGroupBox.Text = "Current Math Problem";
            
            // 
            // StudentAnswerLabel
            // 
            StudentAnswerLabel.AutoSize = true;
            StudentAnswerLabel.Location = new Point(6, 162);
            StudentAnswerLabel.Name = "StudentAnswerLabel";
            StudentAnswerLabel.Size = new Size(112, 20);
            StudentAnswerLabel.TabIndex = 3;
            StudentAnswerLabel.Text = "Student Answer";
            // 
            // StudentTextBox
            // 
            StudentTextBox.Location = new Point(6, 185);
            StudentTextBox.Name = "StudentTextBox";
            StudentTextBox.Size = new Size(216, 27);
            StudentTextBox.TabIndex = 4;
            // 
            // SecondNumberLabel
            // 
            SecondNumberLabel.AutoSize = true;
            SecondNumberLabel.Location = new Point(6, 97);
            SecondNumberLabel.Name = "SecondNumberLabel";
            SecondNumberLabel.Size = new Size(92, 20);
            SecondNumberLabel.TabIndex = 1;
            SecondNumberLabel.Text = "2nd Number";
            // 
            // SecondNumberTextBox
            // 
            SecondNumberTextBox.Location = new Point(6, 120);
            SecondNumberTextBox.Name = "SecondNumberTextBox";
            SecondNumberTextBox.Size = new Size(216, 27);
            SecondNumberTextBox.TabIndex = 2;
            // 
            // FirstNumberLabel
            // 
            FirstNumberLabel.AutoSize = true;
            FirstNumberLabel.Location = new Point(6, 38);
            FirstNumberLabel.Name = "FirstNumberLabel";
            FirstNumberLabel.Size = new Size(86, 20);
            FirstNumberLabel.TabIndex = 0;
            FirstNumberLabel.Text = "1st Number";
            // 
            // FirstNumberTextBox
            // 
            FirstNumberTextBox.Location = new Point(6, 61);
            FirstNumberTextBox.Name = "FirstNumberTextBox";
            FirstNumberTextBox.Size = new Size(216, 27);
            FirstNumberTextBox.TabIndex = 0;
            // 
            // MathTypeGroupBox
            // 
            MathTypeGroupBox.Controls.Add(DivideRadioButton);
            MathTypeGroupBox.Controls.Add(MultiplyRadioButton);
            MathTypeGroupBox.Controls.Add(SubtractRadioButton);
            MathTypeGroupBox.Controls.Add(AddRadioButton);
            MathTypeGroupBox.Location = new Point(293, 130);
            MathTypeGroupBox.Name = "MathTypeGroupBox";
            MathTypeGroupBox.Size = new Size(175, 308);
            MathTypeGroupBox.TabIndex = 1;
            MathTypeGroupBox.TabStop = false;
            MathTypeGroupBox.Text = "Math Problem Type";
            // 
            // DivideRadioButton
            // 
            DivideRadioButton.AutoSize = true;
            DivideRadioButton.Location = new Point(19, 140);
            DivideRadioButton.Name = "DivideRadioButton";
            DivideRadioButton.Size = new Size(73, 24);
            DivideRadioButton.TabIndex = 3;
            DivideRadioButton.TabStop = true;
            DivideRadioButton.Text = "Divide";
            DivideRadioButton.UseVisualStyleBackColor = true;
            // 
            // MultiplyRadioButton
            // 
            MultiplyRadioButton.AutoSize = true;
            MultiplyRadioButton.Location = new Point(19, 110);
            MultiplyRadioButton.Name = "MultiplyRadioButton";
            MultiplyRadioButton.Size = new Size(84, 24);
            MultiplyRadioButton.TabIndex = 2;
            MultiplyRadioButton.TabStop = true;
            MultiplyRadioButton.Text = "Multiply";
            MultiplyRadioButton.UseVisualStyleBackColor = true;
            // 
            // SubtractRadioButton
            // 
            SubtractRadioButton.AutoSize = true;
            SubtractRadioButton.Location = new Point(19, 80);
            SubtractRadioButton.Name = "SubtractRadioButton";
            SubtractRadioButton.Size = new Size(85, 24);
            SubtractRadioButton.TabIndex = 1;
            SubtractRadioButton.TabStop = true;
            SubtractRadioButton.Text = "Subtract";
            SubtractRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddRadioButton
            // 
            AddRadioButton.AutoSize = true;
            AddRadioButton.Location = new Point(19, 50);
            AddRadioButton.Name = "AddRadioButton";
            AddRadioButton.Size = new Size(58, 24);
            AddRadioButton.TabIndex = 0;
            AddRadioButton.TabStop = true;
            AddRadioButton.Text = "Add";
            AddRadioButton.UseVisualStyleBackColor = true;
            // 
            // ButtonGroupBox
            // 
            ButtonGroupBox.Controls.Add(ExitButton);
            ButtonGroupBox.Controls.Add(SummaryButton);
            ButtonGroupBox.Controls.Add(ClearButton);
            ButtonGroupBox.Controls.Add(SubmitButton);
            ButtonGroupBox.Location = new Point(474, 12);
            ButtonGroupBox.Name = "ButtonGroupBox";
            ButtonGroupBox.Size = new Size(314, 426);
            ButtonGroupBox.TabIndex = 2;
            ButtonGroupBox.TabStop = false;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(41, 325);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(254, 74);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SummaryButton
            // 
            SummaryButton.Location = new Point(41, 238);
            SummaryButton.Name = "SummaryButton";
            SummaryButton.Size = new Size(254, 74);
            SummaryButton.TabIndex = 2;
            SummaryButton.Text = "Summary";
            SummaryButton.UseVisualStyleBackColor = true;
            SummaryButton.Click += SummaryButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(41, 154);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(254, 74);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(41, 69);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(254, 74);
            SubmitButton.TabIndex = 0;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // MathContest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonGroupBox);
            Controls.Add(MathTypeGroupBox);
            Controls.Add(CurrentProblemGroupBox);
            Controls.Add(StudentInformationGroupBox);
            Name = "MathContest";
            Text = "Form1";
            StudentInformationGroupBox.ResumeLayout(false);
            StudentInformationGroupBox.PerformLayout();
            CurrentProblemGroupBox.ResumeLayout(false);
            CurrentProblemGroupBox.PerformLayout();
            MathTypeGroupBox.ResumeLayout(false);
            MathTypeGroupBox.PerformLayout();
            ButtonGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox StudentInformationGroupBox;
        private GroupBox CurrentProblemGroupBox;
        private GroupBox MathTypeGroupBox;
        private GroupBox ButtonGroupBox;
        private TextBox FirstNumberTextBox;
        private Label StudentAnswerLabel;
        private TextBox StudentTextBox;
        private Label SecondNumberLabel;
        private TextBox SecondNumberTextBox;
        private Label FirstNumberLabel;
        private Label AgeLabel;
        private TextBox GradeTextBox;
        private TextBox AgeTextBox;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Label GradeLabel;
        private RadioButton DivideRadioButton;
        private RadioButton MultiplyRadioButton;
        private RadioButton SubtractRadioButton;
        private RadioButton AddRadioButton;
        private Button ExitButton;
        private Button SummaryButton;
        private Button ClearButton;
        private Button SubmitButton;
    }
}
