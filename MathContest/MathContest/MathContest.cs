namespace MathContest
{
    public partial class MathContest : Form
    {
        public MathContest()
        {
            InitializeComponent();
            ValidateFields(); 
            DefaultSettings();
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

        private void Math()
        {
            Random random = new Random();
            int FirstNumber = random.Next(0,10);
            int SecondNumber = random.Next(0,10);
            FirstNumberTextBox.Text = FirstNumber.ToString();
            SecondNumberTextBox.Text = SecondNumber.ToString();

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
        }

        private int submitCounter = 0;

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            submitCounter = 1;
            ValidateFields();
            Math();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DefaultSettings();
            submitCounter = 0;
            ValidateFields();
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {

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
    }
}
