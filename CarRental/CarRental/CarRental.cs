using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class CarRental : Form
    {
        public CarRental()
        {
            InitializeComponent();
            DefaultSettings();
            ValidateFields();
        }

        private void DefaultSettings ()
        {
            MilesRadioButton.Checked = true;
            SeniorCitizenCheckBox.Checked = false;
            AAACheckBox.Checked = false;
            CustomerNameTextBox.Text = "";
            AddressTextBox.Text = "";
            CityTextBox.Text = "";
            StateTextBox.Text = "";
            ZipCodeTextBox.Text = "";
            BeginningOdometerReadingTextBox.Text = "";
            EndingOdomoterReadingTextBox.Text = "";
            NumberOfDaysTextBox.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MilesRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void KilometersRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AAACheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Exitutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateFields()
        {
            bool valid = false;
            string message = "";

            if (NumberOfDaysTextBox.Text == "")
                {
                    message = "Please enter the number of days for the rental.";
                    NumberOfDaysTextBox.Focus();
                }
                if (EndingOdomoterReadingTextBox.Text == "")
                {
                    message = "Please enter the ending odometer reading.";
                    EndingOdomoterReadingTextBox.Focus();
                }
                if (BeginningOdometerReadingTextBox.Text == "")
                {
                    message = "Please enter the beginning odometer reading.";
                    BeginningOdometerReadingTextBox.Focus();
                }
                if (ZipCodeTextBox.Text == "")
                {
                    message = "Please enter the zip code.";
                    ZipCodeTextBox.Focus();
                }
                if (StateTextBox.Text == "")
                {
                    message = "Please enter the state.";
                    StateTextBox.Focus();
                }
                if (CityTextBox.Text == "")
                {
                    message = "Please enter the city.";
                    CityTextBox.Focus();
                }
                if (AddressTextBox.Text == "")
                {
                    message = "Please enter the address.";
                    AddressTextBox.Focus();
                }
                if (CustomerNameTextBox.Text == "")
                {
                    message = "Please enter the customer's name.";
                    CustomerNameTextBox.Focus();
                }
                if (message != "")
                {
                    valid = false;
                    MessageBox.Show(message);
                }
                
                return valid;


            // if (string.IsNullOrWhiteSpace(CustomerNameTextBox.Text) || string.IsNullOrEmpty(AddressTextBox.Text) || string.IsNullOrWhiteSpace(CityTextBox.Text)
            //  || string.IsNullOrWhiteSpace(StateTextBox.Text) || string.IsNullOrWhiteSpace(ZipCodeTextBox.Text) || string.IsNullOrWhiteSpace(BeginningOdometerReadingTextBox.Text)
            //  || string.IsNullOrWhiteSpace(EndingOdomoterReadingTextBox.Text) || string.IsNullOrWhiteSpace(BeginningOdometerReadingTextBox.Text)
            //  || string.IsNullOrWhiteSpace(NumberOfDaysTextBox.Text) || valid == false)
            //{
            //  CalculateButton.Enabled = false;
            //}

            // else if (valid == true)
            // {
            //     CalculateButton.Enabled = true;
            // }

        }
        

        private void ValidateOdometerReadings()
        {
            bool valid = false;

            if (int.TryParse(NumberOfDaysTextBox.Text, out int numberOfDays))
            {
                if (numberOfDays > 1 || numberOfDays < 46)
                {
                    valid = true;
                }
            }

            else
            {
                MessageBox.Show("Please enter a valid number for the number of days.");
                NumberOfDaysTextBox.Text = "";
                NumberOfDaysTextBox.Focus();
            }

            if (int.TryParse(EndingOdomoterReadingTextBox.Text, out int endingMileage))
            {
                valid = true;
            }
            else
            {
                MessageBox.Show("Please enter a valid number for the ending odometer reading.");
                EndingOdomoterReadingTextBox.Text = "";
                EndingOdomoterReadingTextBox.Focus();
            }


            if (int.TryParse(BeginningOdometerReadingTextBox.Text, out int startingMileage))
            {
                if (endingMileage < startingMileage)
                {
                    MessageBox.Show("The ending odometer reading must be greater than the beginning odometer reading.");
                    BeginningOdometerReadingTextBox.Text = "";
                    BeginningOdometerReadingTextBox.Focus();
                    EndingOdomoterReadingTextBox.Text = "";
                    EndingOdomoterReadingTextBox.Focus();
                    valid = false;
                }

                else if (endingMileage > startingMileage)
                {
                    valid = true;
                }

                else
                {
                    MessageBox.Show("Please enter a valid number for the beginning odometer reading.");
                    BeginningOdometerReadingTextBox.Text = "";
                    BeginningOdometerReadingTextBox.Focus();
                }
            } 
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            ValidateOdometerReadings();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DefaultSettings();
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {

        }
    }
}
