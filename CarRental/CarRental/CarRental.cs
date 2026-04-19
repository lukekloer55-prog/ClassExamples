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
using System.Xml.Schema;

namespace CarRental
{
    public partial class CarRental : Form
    {
        int customerCount = 0;
        double totalMilesDriven = 0;
        double totalCharges = 0;
        public CarRental()
        {
            InitializeComponent();
            DefaultSettings();  
        }

        private void DefaultSettings ()
        {
            this.Text = "Car Rental";
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
            DistanceDrivenInMilesTextBox.Text = "";
            MileageChargeTextBox.Text = "";
            DayChargeTextBox.Text = "";
            MinusDiscountTextBox.Text = "";
            YouOweTextBox.Text = "";

            if (customerCount == 0)
            {
                SummaryButton.Enabled = false;
            }
        }

        private void Exitutton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to quit?",
                "Confirm Exit",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private bool ValidateFields()
        {
            bool valid = true;
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
        }
        

        private bool ValidateOdometerReadings()
        {
            bool valid = false;

            if (int.TryParse(NumberOfDaysTextBox.Text, out int numberOfDays))
            {
                if (numberOfDays > 0 & numberOfDays < 46)
                {
                    valid = true;
                }

                else
                {
                    MessageBox.Show("Please enter a valid number for the number of days, must be greater than 0 and no more than 45.");
                    NumberOfDaysTextBox.Text = "";
                    NumberOfDaysTextBox.Focus();
                }
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
            return valid;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double mileagetotal = 0;
            double total = 0;
            double AAADiscount = 0;
            double SeniorCitizenDiscount = 0;
            double above500 = 0;    
            double above200 = 0;
            double distanceDriven = 0;
            double.TryParse(EndingOdomoterReadingTextBox.Text, out double endingMileage);
            double.TryParse(BeginningOdometerReadingTextBox.Text, out double startingMileage);
            int.TryParse(NumberOfDaysTextBox.Text, out int numberofdays);

            if (KilometersRadioButton.Checked == true) 
            { 
                endingMileage = endingMileage * .62;
                startingMileage = startingMileage * .62;
            }

            ValidateFields();

            if (ValidateFields() == true)
            {
                ValidateOdometerReadings();
                customerCount = customerCount + 1;

                if (ValidateOdometerReadings())
                {
                    DistanceDrivenInMilesTextBox.Text = (endingMileage - startingMileage).ToString();
                    distanceDriven = endingMileage - startingMileage;
                    double mileageCharge = distanceDriven - 200;

                    if (mileageCharge < 0)
                        { 
                        mileageCharge = 0;
                        }
                    else 
                    { 
                        mileageCharge = mileageCharge - 500;
                        double remainder = mileageCharge;
                        if (remainder > 0)
                        {
                            above200 = 500 * 0.12;
                            above500 = remainder * .1;
                        }
                        else 
                        {
                            above200 = (mileageCharge + 500) * .12;
                        }
                        mileagetotal = above500 + above200;
                        MileageChargeTextBox.Text = mileagetotal.ToString();
                        DayChargeTextBox.Text = (numberofdays * 15).ToString();
                        total = mileagetotal + (numberofdays * 15);
                    }  
                }
                if (AAACheckBox.Checked == true)
                {
                    AAADiscount = .05;
                }

                if (SeniorCitizenCheckBox.Checked == true)
                {
                    SeniorCitizenDiscount = .03;
                }
                double minusDiscount = (AAADiscount + SeniorCitizenDiscount) * total;
                MinusDiscountTextBox.Text = minusDiscount.ToString();
                YouOweTextBox.Text = (total - minusDiscount).ToString();
                totalMilesDriven += distanceDriven;
                totalCharges += total;

                if (customerCount > 0)
                {
                    SummaryButton.Enabled = true;
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DefaultSettings();
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            DefaultSettings();
            string text = $"{"Total customers:"} {customerCount}\n {"Total Miles Driven:"} {totalMilesDriven} \n {"Total Charges:"} {totalCharges} ";
            MessageBox.Show(text);
        }

        private double KiloMetersToMiles(double kilometers)
        {
            return kilometers * 0.62;
        }
    }
}
