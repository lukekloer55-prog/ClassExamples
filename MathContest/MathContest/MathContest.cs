using System.Security.AccessControl;

namespace MathContest
{


    public partial class MathContest : Form
    {
        int submitCounter = 0;
        int amountCorrect = 0;
        int answer = 0;



        public MathContest()
        {
            InitializeComponent();
            DefaultSettings();
            ValidateFields();

        }

        private void ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrEmpty(AgeTextBox.Text) || string.IsNullOrWhiteSpace(GradeTextBox.Text))
            {
                SubmitButton.Enabled = false;
            }

            else
            {
                SubmitButton.Enabled = true;
            }

            if (submitCounter >= 1)
            {
                NameTextBox.Enabled = false;
                AgeTextBox.Enabled = false;
                GradeTextBox.Enabled = false;
            }

            else
            {
                NameTextBox.Enabled = true;
                AgeTextBox.Enabled = true;
                GradeTextBox.Enabled = true;
            }


        }

        private void GenerateMath()

        {
            Random random = new Random();
            int FirstNumber = random.Next(0, 10);
            int SecondNumber = random.Next(0, 10);
            FirstNumberTextBox.Text = FirstNumber.ToString();
            SecondNumberTextBox.Text = SecondNumber.ToString();
            int caseSelection = 0;


            if (AddRadioButton.Checked)
            {
                caseSelection = 0;
            }
            else if (SubtractRadioButton.Checked)
            {
                caseSelection = 1;
            }
            else if (MultiplyRadioButton.Checked)
            {
                caseSelection = 2;
            }
            else if (DivideRadioButton.Checked)
            {
                caseSelection = 3;
            }

            switch (caseSelection)
            {

                case 0:
                    {
                        answer = FirstNumber + SecondNumber;
                        break;
                    }
                case 1:
                    {
                        answer = FirstNumber - SecondNumber;
                        break;
                    }
                case 2:
                    {
                        answer = FirstNumber * SecondNumber;
                        break;
                    }
                case 3:
                    {
                        answer = FirstNumber / SecondNumber;
                        break;
                    }
            }

        }

        private void CheckMath()
        {
            if (StudentAnswerTextBox.Text == answer.ToString())
            {
                amountCorrect = amountCorrect + 1;
            }
        }



        private void DefaultSettings()
        {
            SubmitButton.Enabled = true;
            AddRadioButton.Checked = true;
            NameTextBox.Text = string.Empty;
            AgeTextBox.Text = string.Empty;
            GradeTextBox.Text = string.Empty;
            FirstNumberTextBox.Text = string.Empty;
            SecondNumberTextBox.Text = string.Empty;
            FirstNumberTextBox.Enabled = false;
            SecondNumberTextBox.Enabled = false;
            StudentAnswerTextBox.Enabled = false;
        }



        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            submitCounter = submitCounter + 1;
            ValidateFields();
            CheckMath();
            GenerateMath();
            StudentAnswerTextBox.Enabled = true;
            StudentAnswerTextBox.Text = string.Empty;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DefaultSettings();
            submitCounter = 0;
            amountCorrect = 0;
            ValidateFields();
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            string text = $"Name: {NameTextBox.Text}\nAge: {AgeTextBox.Text}\nGrade: {GradeTextBox.Text}  \n{submitCounter - 1}  {amountCorrect}";
            MessageBox.Show(text, "Summary");
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        private void GradeTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        private void AddRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            GenerateMath();
        }

        private void SubtractRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            GenerateMath();
        }

        private void MultiplyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            GenerateMath();
        }

        private void DivideRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            GenerateMath();
        }
    }
}
