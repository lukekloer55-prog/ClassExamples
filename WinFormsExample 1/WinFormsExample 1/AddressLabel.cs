namespace WinFormsExample_1
{
    public partial class AddressLabel : Form
    {
        public AddressLabel()
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
            if (ValidateFields())
            {

            }
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
            FirstNameTextBox.Text = "";
            //NameTextBox.BackColor = Color.LightYellow;
            LastNameTextBox.Text = "";
            AddressTextBox.Text = "";
            CityTextBox.Text = "";
            StateTextBox.Text = "";
            ZipCodeBox.Text = "";
            FinalAddressLabel.Text = "";
            DisplayLabelButton.Enabled = false;
        }

        private bool ValidateFields()
        {
            bool valid = true;
            string message = "";

            if (ZipCodeBox.Text == "")
            {
                message = "Zip Code is required\n" + message;
                ZipCodeBox.Focus();
            }
            if (StateTextBox.Text == "")
            {
                message = "State is required\n" + message;
                StateTextBox.Focus();
            }
            if (CityTextBox.Text == "")
            {
                message = "City is required\n" + message;
                CityTextBox.Focus();
            }
            if (AddressTextBox.Text == "")
            {
                message = "Address is required\n" + message;
                AddressTextBox.Focus();
            }
            if (LastNameTextBox.Text == "")
            {
                message = "LastName is required\n" + message;
                LastNameTextBox.Focus();
            }
            if (FirstNameTextBox.Text == "")
            {
                message = "FirstName is required\n" + message;
                FirstNameTextBox.Focus();
            }
            if (message != "")
            {
                valid = false;
                MessageBox.Show(message);
            }
            if (valid == true)
            {
                FinalAddressLabel.Text = $"{FirstNameTextBox.Text} {LastNameTextBox.Text}\n{AddressTextBox.Text}\n{CityTextBox.Text}, {StateTextBox.Text} {ZipCodeBox.Text}";
            }
            return valid;

        }

        private void NameTextBox_TextChanged(Object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text != "")
            {
                FirstNameTextBox.BackColor = Color.White;
                DisplayLabelButton.Enabled = true;
            }

            else
            {
                FirstNameTextBox.BackColor = Color.LightYellow;
                DisplayLabelButton.Enabled = false;
            }

        }
    }
}
