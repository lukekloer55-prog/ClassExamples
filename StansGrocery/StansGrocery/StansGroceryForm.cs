using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StansGrocery
{
    public partial class StansGroceryForm : Form
    {
        // Moved these out of the constructor to class scope to avoid
        // redeclaration / scoping errors (CS0136).
        string[,] customerData = new string[0, 0];
        string filePath = "..\\..\\..\\Grocery.txt";
        // file path to the grocery data file

        public StansGroceryForm()
        {
            InitializeComponent();
            SetDefaults();
            // set the defaults to load when the form starts
            string filepath = "..\\..\\..\\Grocery.txt";
            FileToArray(filePath);
            // load the data from the file into the 2D array
            LoadFilterComboBox();
            DisplayData();
            // display the data in the list box

            SearchButton.Enabled = false;
            // disable the search button until a search type is selected
        }

        //Custom Methods-------------------------------------------------------

        private void SetDefaults()
        {
            FilterByAisleRadioButton.Checked = true;
            // set the default filter to "Filter by Aisle"
        }

        int CountOfLinesIn(string filePath)
        {
            int count = 0;
            using (StreamReader testFile = new StreamReader(filePath))
            // open the file for reading 
            {
                do
                {
                    testFile.ReadLine();
                    count++;
                } while (!testFile.EndOfStream);
                // read each line until the end of the file and count the number of lines
            }
            return count;
        }

        string CleanField(string input)
        {
            return input
                .Replace("\"", "")
                // remove quotes
                .Replace("$", "")
                // remove dollar signs
                .Replace("#", "")
                // remove hash symbols
                .Replace("%", "")
                // remove percent signs
                .Replace("ITM", "")
                // remove "ITM" prefix
                .Replace("LOC", "")
                // remove "LOC" prefix
                .Replace("CAT", "")
                // remove "CAT" prefix
                .Trim();
            // remove leading and trailing whitespace
        }

        void FileToArray(string filePath)
        {
            string[,] _customerData = new string[3, CountOfLinesIn(filePath)];
            string[] temp;
            int counter = 0;

            using (StreamReader testFile = new StreamReader(filePath))
            {
                do
                {
                    temp = testFile.ReadLine().Split(',');
                    // read all the lines and split them into an array of strings
                    // using the comma as a delimiter

                    if (temp.Length >= 3)
                    // check if the line has at least 3 fields before
                    // trying to access them
                    {
                        for (int i = 0; i < temp.Length && i < 4; i++)
                        // loop through the fields in the line and clean
                        // them before storing them in the 2D array
                        {
                            _customerData[i, counter] = CleanField(temp[i]);
                        }
                    }
                    counter++;
                } while (!testFile.EndOfStream);
            }

            this.customerData = _customerData;
        }

        void DisplayData()
        {
            string[,] data = this.customerData;
            string formattedRow = "";
            int filterColumn = 2;

            ChoiceListBox.Items.Clear();

            if (FilterByCategoryRadioButton.Checked)
            {
                filterColumn = 2;
            }
            else if (FilterByAisleRadioButton.Checked)
            {
                filterColumn = 1;
            }

            for (int row = 0; row < data.GetLength(1); row++)
            {
                for (int column = 0; column < data.GetLength(0); column++)
                {
                    if (data[column, row] != null && (data[filterColumn, row]
                    == ChoiceComboBox.SelectedItem.ToString()
                    || ChoiceComboBox.SelectedIndex == 0))
                    {
                        formattedRow = $"{data[0, row],-25} {data[1, row],-5} " +
                            $"{data[2, row],-25}";
                        // format by row and align the columns using string 
                    }
                }

                if (formattedRow != "" && formattedRow.IndexOf(SearchTextBox.Text,
                StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    DisplayListBox.Items.Add(formattedRow);
                }
            }
        }

        void LoadFilterComboBox()
        {
            int column = 1;
            ChoiceComboBox.Items.Clear();

          
            if (FilterByAisleRadioButton.Checked)
            {
                column = 1;
            }
            else if (FilterByCategoryRadioButton.Checked)
            {
                column = 2;
            }

            for (int row = 0; (row < this.customerData.GetUpperBound(1)); row++)
            {
                if (this.customerData[column, row] == null &&
                ChoiceComboBox.Items.Contains(this.customerData[column, row]) != true)
                {
                    ChoiceComboBox.Items.Add(this.customerData[column, row]);
                }
            }
            ChoiceComboBox.Items.Add("~Select~");
            ChoiceComboBox.Sorted = true;
            ChoiceComboBox.SelectedIndex = 0;

        }

        private void ChoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayData();
        }

       
        private void SearchButton_Click(object sender, EventArgs e)
        {
            ChoiceComboBox.SelectedIndex = 0;
            DisplayData();
            SearchTextBox.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FilterByAisleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LoadFilterComboBox();
        }

        private void FilterByCategoryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LoadFilterComboBox();
        }
    }
}
