/*Luke Kloer
Rcet 2265
Semester Spring 2026
RCET 2265 - Programming in C#
MathContest Program
GitHub URL:
https://github.com/lukekloer55-prog/ClassExamples/tree/main/MathContest */

using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace MathContest
{


    public partial class MathContest : Form
    {
        //Global variables that needed declared.
        int submitCounter = 0;
        int amountCorrect = 0;
        int answer = 0;


        public MathContest()
        {
            //Renaming the page
            this.Text = "Math Contest";
            //This is the method call operation for the entire program.
            InitializeComponent();
            DefaultSettings();
            ValidateFields();
        }

        private void ValidateFields()
        {
            //This if statement controls weath the submit button is able to be clicked while the student data isn't inputed.
            //Null just means that it checks weather the space is empty or of no value. 
            //If it is empty then the submit button is diabled.
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrEmpty(AgeTextBox.Text) || string.IsNullOrWhiteSpace(GradeTextBox.Text))
            {
                SubmitButton.Enabled = false;
            }

            else
            {
                SubmitButton.Enabled = true;
            }

            //This watches the count of the times the submit button is pressed to disable the student information text boxes
            //Limits the user to only changing student information if clear had been clicked.
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
            //Generates random numbers to do the math problems with
            Random random = new Random();
            int FirstNumber = random.Next(0, 10);
            int SecondNumber = random.Next(0, 10);
            FirstNumberTextBox.Text = FirstNumber.ToString();
            SecondNumberTextBox.Text = SecondNumber.ToString();
            int caseSelection = 0;

            //If statements for checking the state of radio buttons.
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

            //This is a case selection for the different math types.
            //Allows the user to change math problem type.
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
            //This method is a call to check the math that the student has answered.
            //This was done as the generate math had to be seperate so that the user
            //could see the correct numbers.
            if (StudentAnswerTextBox.Text == answer.ToString())
            {
                amountCorrect = amountCorrect + 1;
            }
        }



        private void DefaultSettings()
        {
            //Sets the values to their default values when called.
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
            this.Text = "Math Contest";
            NameTextBox.BackColor = Color.LightYellow;
            AgeTextBox.BackColor = Color.LightYellow;
            GradeTextBox.BackColor = Color.LightYellow;
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Cloes the program if called.
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //This method counts the amount of times the submit had been clicked
            //As well as sets the operations of methods
            submitCounter = submitCounter + 1;
            ValidateFields();
            CheckMath();
            GenerateMath();
            //The enabling of the student text box after the submit button is clicked is to make sure that
            //the user cant input a result while there is no generated numbers and student information hasnt been subbmited.
            StudentAnswerTextBox.Enabled = true;
            StudentAnswerTextBox.Text = string.Empty;
            StudentAnswerTextBox.BackColor = Color.LightYellow;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Sets everything back to defaults when called
            DefaultSettings();
            submitCounter = 0;
            amountCorrect = 0;
            //Reruns validate fields to turn on and off the respective controls.
            ValidateFields();
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            //This method when clicked shows a pop up message containing the amount of answers the student got right to amount that was possible. 
            string text = $"{NameTextBox.Text} {"got"} {amountCorrect} {"answers correct out of possible"}  {submitCounter - 1}";
            MessageBox.Show(text, "Summary");
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            //validate fields to turn on and off the respective controls.
            ValidateFields();
            //This changes the color of text boxes that are empty to signal that they need to be filled in.
            if (NameTextBox.Text != "")
            {
                NameTextBox.BackColor = Color.White;

            }

            else
            {
                NameTextBox.BackColor = Color.LightYellow;
            }
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            //validate fields to turn on and off the respective controls.
            ValidateFields();
            //This changes the color of text boxes that are empty to signal that they need to be filled in.
            if (AgeTextBox.Text != "")
            {
                AgeTextBox.BackColor = Color.White;

            }

            else
            {
                AgeTextBox.BackColor = Color.LightYellow;
            }
        }

        private void GradeTextBox_TextChanged(object sender, EventArgs e)
        {
            //validate fields to turn on and off the respective controls.
            ValidateFields();
            //This changes the color of text boxes that are empty to signal that they need to be filled in.
            if (GradeTextBox.Text != "")
            {
                GradeTextBox.BackColor = Color.White;

            }

            else
            {
                GradeTextBox.BackColor = Color.LightYellow;
            }
        }

        private void AddRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Generates new numbers if the user changed the math type
            //Prevents the student from just choosing what they want to add subtract etc...
            GenerateMath();
        }

        private void SubtractRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Generates new numbers if the user changed the math type
            //Prevents the student from just choosing what they want to add subtract etc...
            GenerateMath();
        }

        private void MultiplyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Generates new numbers if the user changed the math type
            //Prevents the student from just choosing what they want to add subtract etc...
            GenerateMath();
        }

        private void DivideRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Generates new numbers if the user changed the math type
            //Prevents the student from just choosing what they want to add subtract etc...
            GenerateMath();
        }

        private void StudentAnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            
            //This changes the color of text boxes that are empty to signal that they need to be filled in.
            if (StudentAnswerTextBox.Text != "")
            {
                StudentAnswerTextBox.BackColor = Color.White;

            }

            else
            {
                StudentAnswerTextBox.BackColor = Color.LightYellow;
            }
        }
    }
}
