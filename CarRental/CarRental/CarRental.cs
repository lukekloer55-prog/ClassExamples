/*Luke Kloer
Rcet 2265
Semester Spring 2026
RCET 2265 - Programming in C#
CarRental Program
GitHub URL:https://github.com/lukekloer55-prog/ClassExamples/tree/main/CarRental */


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
        // Declare variables to keep track of the number of customers, total miles driven, and total charges.
        // These are global variables.
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
            // Set default settings for the form
            // Sets the title of the form, clears all text boxes, unchecks all checkboxes, and sets the default radio button to miles.
            // Also disables the summary button if there are no customers.
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
            // Disable the summary button if there are no customers
            if (customerCount == 0)
            {
                SummaryButton.Enabled = false;
            }
        }

        private void Exitutton_Click(object sender, EventArgs e)
        {
            // Show a confirmation message box when the user clicks the exit button
            // If the user clicks "Yes", close the form. If the user clicks "No", do nothing.
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
            // Validate that all required fields are filled in. If any field is empty, set the message variable to the appropriate error message and set valid to false.
            // If valid is false, show a message box with the error message and set the focus to the appropriate text box.
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
            // Valid is a boolean value that will be used to determine if the fields are valid or not.
            // If valid is false, the program will not continue with the calculations.
            return valid;
        }


        // Validate that the number of days, ending odometer reading, and beginning odometer reading are all valid numbers.
        // If any of the fields are invalid, show a message box with the appropriate error message and set the focus to the appropriate text box.
        private bool ValidateOdometerReadings()
        {
            bool valid = false;
           
            if (int.TryParse(NumberOfDaysTextBox.Text, out int numberOfDays))
            {
                // The number of days must be greater than 0 and no more than 45.
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

            // The ending odometer reading must be a valid number.
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

            // The beginning odometer reading must be a valid number and must be less than the ending odometer reading.
            if (int.TryParse(BeginningOdometerReadingTextBox.Text, out int startingMileage))
            {
                // Check if the ending mileage is less than the starting mileage.
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

               
            }
            // If the beginning odometer reading is not a valid number, show an error message and set the focus to the beginning odometer reading text box.
            else
            {
                MessageBox.Show("Please enter a valid number for the beginning odometer reading.");
                BeginningOdometerReadingTextBox.Text = "";
                BeginningOdometerReadingTextBox.Focus();
            }
            // Valid is a boolean value that will be used to determine if the odometer readings are valid or not.
            return valid;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Declare variables to keep track of the mileage total, total charges, discounts, and distance driven.
            // Use TryParse to convert the text from the text boxes to the appropriate data types.
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

            // If the kilometers radio button is checked, convert the ending and starting mileage to miles by multiplying by 0.62.
            if (KilometersRadioButton.Checked == true) 
            { 
                endingMileage = endingMileage * .62;
                startingMileage = startingMileage * .62;
            }
            // Check if the fields are valid by calling the ValidateFields method.
            // If the fields are valid, call the ValidateOdometerReadings method to validate the odometer readings.
            // If the odometer readings are valid, calculate the distance driven, mileage charge, day charge, and total charges.
            // If the AAA or Senior Citizen checkboxes are checked, apply the appropriate discounts.
            // Finally, update the total miles driven and total charges for all customers and enable the summary button if there is at least one customer.
            ValidateFields();

            if (ValidateFields() == true)
            {
                ValidateOdometerReadings();
                customerCount = customerCount + 1;

                if (ValidateOdometerReadings())
                {
                    // Calculate the distance driven by subtracting the starting mileage from the ending mileage and display it in the DistanceDrivenInMilesTextBox.
                    DistanceDrivenInMilesTextBox.Text = (endingMileage - startingMileage).ToString();
                    distanceDriven = endingMileage - startingMileage;
                    double mileageCharge = distanceDriven - 200;
                    // The first 200 miles are free, so if the mileage charge is less than 0, set it to 0. Otherwise, calculate the mileage charge for the miles above 200 and above 500.
                    // The mileage charge for the miles above 200 is 12 cents per mile, and the mileage charge for the miles above 500 is 10 cents per mile.
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
                        // Calculate the total mileage charge by adding the mileage charge for the miles above 200 and above 500 and display it in the MileageChargeTextBox.
                        mileagetotal = above500 + above200;
                        MileageChargeTextBox.Text = mileagetotal.ToString();
                        DayChargeTextBox.Text = (numberofdays * 15).ToString();
                        total = mileagetotal + (numberofdays * 15);
                    }  
                }
                // If the AAA checkbox is checked, apply a 5% discount to the total charges.
                // If the Senior Citizen checkbox is checked, apply a 3% discount to the total charges.
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
                // Update the total miles driven and total charges for all customers and enable the summary button if there is at least one customer.
                // "+=" allows us to add the distance driven and total charges for the current customer to the total miles driven and total charges for all customers.
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
            // Clear all fields and reset the form to its default settings by calling the DefaultSettings method.
            DefaultSettings();
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            // Display a summary of the total number of customers, total miles driven, and total charges for all customers in a message box.
            // Then reset the form to its default settings by calling the DefaultSettings method.
            // The reset will not clear the summary data, so the user can continue to add customers and see the updated summary data.
            DefaultSettings();
            string text = $"{"Total customers:"} {customerCount}\n {"Total Miles Driven:"} {totalMilesDriven} \n {"Total Charges:"} {totalCharges} ";
            MessageBox.Show(text);
        }

        private void YouOweLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
