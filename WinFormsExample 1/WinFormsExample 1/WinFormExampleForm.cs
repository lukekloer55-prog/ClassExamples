namespace WinFormsExample_1
{
    public partial class WinFormExampleForm : Form
    {
        public WinFormExampleForm()
        {
            InitializeComponent();
            SetDefaults();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ValidateFields();
            //this.Text = NameTextBox.Text;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void SetDefaults()
        {

            NameTextBox.Text = "";
            AgeTextBox.Text = "";
            CityTextBox.Text = "";
            PhoneTextBox.Text = "";

            UpperCaseRadio.Checked = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ValidateFields ()
        {

            string message = "";

            if (CityTextBox.Text == "")
            {
                message = "City is required\n" + message;
                CityTextBox.Focus();
            }

            if (PhoneTextBox.Text == "")
            {
                message = "Phone is required\n" + message;
                PhoneTextBox.Focus();
            }

            if (AgeTextBox.Text == "")
            {
                message = "Age is required\n" + message;
                AgeTextBox.Focus();
            }

            if (NameTextBox.Text == "")
            {
               message = "Name is required\n" + message;
               NameTextBox.Focus();
            }

            if (message != "")
            {
                MessageBox.Show(message);
            }

        }
    }
}
