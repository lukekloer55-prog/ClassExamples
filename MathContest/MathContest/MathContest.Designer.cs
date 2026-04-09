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
            AgeLabel = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            textBox4 = new TextBox();
            CurrentProblemGroupBox = new GroupBox();
            StudentAnswerLabel = new Label();
            textBox3 = new TextBox();
            SecondNumberLabel = new Label();
            textBox2 = new TextBox();
            FirstNumberLabel = new Label();
            textBox1 = new TextBox();
            MathTypeGroupBox = new GroupBox();
            ButtonGroupBox = new GroupBox();
            GradeLabel = new Label();
            AddRadioButton = new RadioButton();
            SubtractRadioButton = new RadioButton();
            DivideRadioButton = new RadioButton();
            MultiplyRadioButton = new RadioButton();
            StudentInformationGroupBox.SuspendLayout();
            CurrentProblemGroupBox.SuspendLayout();
            MathTypeGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // StudentInformationGroupBox
            // 
            StudentInformationGroupBox.Controls.Add(GradeLabel);
            StudentInformationGroupBox.Controls.Add(AgeLabel);
            StudentInformationGroupBox.Controls.Add(textBox6);
            StudentInformationGroupBox.Controls.Add(textBox5);
            StudentInformationGroupBox.Controls.Add(label1);
            StudentInformationGroupBox.Controls.Add(textBox4);
            StudentInformationGroupBox.Location = new Point(12, 12);
            StudentInformationGroupBox.Name = "StudentInformationGroupBox";
            StudentInformationGroupBox.Size = new Size(456, 112);
            StudentInformationGroupBox.TabIndex = 0;
            StudentInformationGroupBox.TabStop = false;
            StudentInformationGroupBox.Text = "Student Information";
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
            // textBox6
            // 
            textBox6.Location = new Point(385, 69);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(48, 27);
            textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(314, 69);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(36, 27);
            textBox5.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 5;
            label1.Text = "1st Number";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 69);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(269, 27);
            textBox4.TabIndex = 5;
            // 
            // CurrentProblemGroupBox
            // 
            CurrentProblemGroupBox.Controls.Add(StudentAnswerLabel);
            CurrentProblemGroupBox.Controls.Add(textBox3);
            CurrentProblemGroupBox.Controls.Add(SecondNumberLabel);
            CurrentProblemGroupBox.Controls.Add(textBox2);
            CurrentProblemGroupBox.Controls.Add(FirstNumberLabel);
            CurrentProblemGroupBox.Controls.Add(textBox1);
            CurrentProblemGroupBox.Location = new Point(12, 130);
            CurrentProblemGroupBox.Name = "CurrentProblemGroupBox";
            CurrentProblemGroupBox.Size = new Size(275, 308);
            CurrentProblemGroupBox.TabIndex = 1;
            CurrentProblemGroupBox.TabStop = false;
            CurrentProblemGroupBox.Text = "Current Math Problem";
            CurrentProblemGroupBox.Enter += CurrentProblemGroupBox_Enter;
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
            // textBox3
            // 
            textBox3.Location = new Point(6, 185);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(188, 27);
            textBox3.TabIndex = 4;
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
            // textBox2
            // 
            textBox2.Location = new Point(6, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 27);
            textBox2.TabIndex = 2;
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
            // textBox1
            // 
            textBox1.Location = new Point(6, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 27);
            textBox1.TabIndex = 0;
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
            // ButtonGroupBox
            // 
            ButtonGroupBox.Location = new Point(474, 12);
            ButtonGroupBox.Name = "ButtonGroupBox";
            ButtonGroupBox.Size = new Size(314, 426);
            ButtonGroupBox.TabIndex = 2;
            ButtonGroupBox.TabStop = false;
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
            ResumeLayout(false);
        }

        #endregion

        private GroupBox StudentInformationGroupBox;
        private GroupBox CurrentProblemGroupBox;
        private GroupBox MathTypeGroupBox;
        private GroupBox ButtonGroupBox;
        private TextBox textBox1;
        private Label StudentAnswerLabel;
        private TextBox textBox3;
        private Label SecondNumberLabel;
        private TextBox textBox2;
        private Label FirstNumberLabel;
        private Label AgeLabel;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label1;
        private TextBox textBox4;
        private Label GradeLabel;
        private RadioButton DivideRadioButton;
        private RadioButton MultiplyRadioButton;
        private RadioButton SubtractRadioButton;
        private RadioButton AddRadioButton;
    }
}
