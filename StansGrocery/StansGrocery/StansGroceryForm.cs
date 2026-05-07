/*Luke Kloer
Rcet 2265
Semester Spring 2026
RCET 2265 - Programming in C#
Stans Grocery Program
GitHub URL:
https://github.com/lukekloer55-prog/ClassExamples/tree/main/StansGrocery */

using EtchASketch;
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
        // This is a two-dimensional array that will hold the customer data loaded from the file.
        string[,] customerData = new string[0, 0];
        string filePath = "..\\..\\..\\Grocery.txt";

        public StansGroceryForm()
        {
            // When the form is initialized, we want to set up the default states of the controls,
            // load the data from the file into the customerData array,
            // populate the filter combo box with the appropriate values,
            // and display the initial data in the DisplayListBox.
            // This will default to showing all items since no filter is selected at this point.
            // Gives the user an idea of all the avaliable items in the grocery store before they apply any filters or search terms.
            InitializeComponent();
            SetDefaults();
            FileToArray(filePath);
            LoadFilterComboBox();
            ChoiceComboBox.SelectedIndex = 0;
            DisplayData();
        }

        void FileToArray(string filePath)
        {
            // This method reads data from a specified file and stores it in a two-dimensional array called customerData.
            int rows = CountOfLinesIn(filePath);
            // The number of columns is set to 4, which corresponds to the expected fields in the data (e.g., item name, aisle, category, etc.).
            string[,] _customerData = new string[4, rows];
            // A StreamReader is used to read the file line by line.
            // For each line, the data is split by commas and stored in the corresponding position in the _customerData array after being cleaned using the CleanField method.
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                int counter = 0;
                // Read through the file line by line until the end is reached, splitting each line by commas and storing the cleaned data in the _customerData array.
                while ((line = sr.ReadLine()) != null)
                {
                    string[] temp = line.Split(',');

                    for (int i = 0; i < temp.Length && i < 4; i++)
                    {
                        _customerData[i, counter] = CleanField(temp[i]);
                    }

                    counter++;
                }
            }
            
            customerData = _customerData;
        }


        private void SetDefaults()
        {
            // This just sets the default states of the radio checkboxes to unchecked when the form loads, so that no filter is applied until the user selects one.
            FilterByAisleRadioButton.Checked = false; 
            FilterByCategoryRadioButton.Checked = false;
        }

        
        int CountOfLinesIn(string filePath)
        {
            int count = 0;
            // This method counts the number of lines in a specified file.
            // It initializes a counter variable to zero and uses a StreamReader to read through the file line by line.
            // For each line that is read, the counter is incremented. Once the end of the file is reached, the total count of lines is returned.
            // This is later used to determine the number of rows needed for the customerData array when loading the data from the file.
            using (StreamReader sr = new StreamReader(filePath))
            {
                // Read through the file line by line until the end is reached, incrementing the count for each line.
                while (sr.ReadLine() != null)
                    count++;
            }

            return count;
        }

        
        string CleanField(string input)
        {
            // This method takes an input string and removes specific unwanted characters and substrings, such as quotes, dollar signs, hash symbols, percentage signs, and certain prefixes like "ITM", "LOC", and "CAT".
            // It also trims any leading or trailing whitespace from the resulting string. The cleaned string is then returned.
            return input
                .Replace("\"", "")
                .Replace("$", "")
                .Replace("#", "")
                .Replace("%", "")
                .Replace("ITM", "")
                .Replace("LOC", "")
                .Replace("CAT", "")
                .Trim();
        }

       
        void DisplayData()
        {
            // Clear the DisplayListBox to prepare for showing the filtered data.
            DisplayListBox.Items.Clear();
            // Declare a variable selectedFilter to store the currently selected filter value from the ChoiceComboBox.
            // This will be used to determine which items to display based on the selected filter.
            string selectedFilter = ChoiceComboBox.SelectedItem.ToString();
            // Declare a boolean variable showAll to determine whether to show all items or filter based on the selected filter.
            bool showAll = ChoiceComboBox.SelectedIndex == 0;
            // Declare a variable search to store the search term entered in the SearchTextBox. 
            string search = SearchTextBox.Text ?? "";

            // Loop through each row of the customerData array to check for matches with the selected filter and search term.
            for (int row = 0; row < customerData.GetLength(1); row++)
            {
                // Check if the first column of the current row is null. If it is, skip to the next iteration of the loop.
                if (customerData[0, row] == null)
                    // If the item name is null, we skip this row since it doesn't contain valid data.
                    // Continue is used to skip the rest of the loop body and move on to the next iteration, which allows us to avoid processing rows that don't have valid item names.
                    continue;

                string item;
                // Determine how to format the item string based on which filter is selected.
                if (FilterByAisleRadioButton.Checked)
                {
                    item = $"{customerData[0, row]} - {customerData[1, row]}";
                }
                else if (FilterByCategoryRadioButton.Checked)
                {
                    item = $"{customerData[0, row]} - {customerData[2, row]}";
                }
                else
                {
                    item = $"{customerData[0, row]} - {customerData[1, row]} - {customerData[2, row]}";
                }
                // Determine which column to use for filtering based on the selected filter radio button.
                // The question mark operator is used to check if the FilterByCategoryRadioButton is checked.
                // If it is, filterColumn is set to 2 (the category column); otherwise, it is set to 1 (the aisle column).
                // Acts as a if statement in one line, where if the condition before the question mark is true, the value after the question mark is assigned to filterColumn, and if it is false, the value after the colon is assigned to filterColumn.
                // Found this solution on somones blog.
                int filterColumn = FilterByCategoryRadioButton.Checked ? 2 : 1;
                // Check if the current row matches the selected filter and search term.
                bool matchesFilter =
                    showAll || customerData[filterColumn, row] == selectedFilter;
                // Check if the item string contains the search term, ignoring case.
                // This ignore case is different than the class examples as this version is older and doesn't have the string.Contains method.
                bool matchesSearch =
                    item.IndexOf(search, StringComparison.InvariantCultureIgnoreCase) >= 0;
                // If the current row matches both the selected filter and the search term, add it to the DisplayListBox.
                if (matchesFilter && matchesSearch)
                {
                    DisplayListBox.Items.Add(item);
                }
            }
        }

       
        void LoadFilterComboBox()
        {
            // Clear existing items
            ChoiceComboBox.Items.Clear();
            // If no filter is selected, just show "Show All"
            // Fixed the problem with aisles being displayed when nothing was selected.
            if (!FilterByAisleRadioButton.Checked && !FilterByCategoryRadioButton.Checked)
            {
                ChoiceComboBox.Items.Add("Show All");
                ChoiceComboBox.SelectedIndex = 0;
                return;
            }
            // Determine which column to extract values from based on the selected filter
            int column = FilterByCategoryRadioButton.Checked ? 2 : 1;
            //
            List<string> values = new List<string>();
            
            for (int row = 0; row < customerData.GetLength(1); row++)
            {
                // Skip null or empty values
                string value = customerData[column, row];
                // Add unique values to the list
                if (!string.IsNullOrEmpty(value) && !values.Contains(value))
                {
                    values.Add(value);
                }
            }
            // Sort numerically if possible, otherwise alphabetically
            // Had to use online repositories to find a way to sort the values in the combo box numerically if they were numbers, and alphabetically if they were not.
            // I found a solution that uses a custom comparison function in the Sort method of the List<string>.
            values.Sort((a, b) =>
            {
                // Try to parse both values as integers
                bool aIsNum = int.TryParse(a, out int aNum);
                bool bIsNum = int.TryParse(b, out int bNum);
                // If both are numbers, compare them as integers
                if (aIsNum && bIsNum) return aNum.CompareTo(bNum);
                // Otherwise, compare them as strings
                return string.Compare(a, b, StringComparison.InvariantCultureIgnoreCase);
            });
            // Add "Show All" option at the top of the sorted list
            ChoiceComboBox.Sorted = false;
            // Set Sorted to false to maintain the order of items as we add them, since we are adding "Show All" at the top.
            ChoiceComboBox.Items.Add("Show All");
            // Add the sorted values to the combo box
            foreach (string value in values) 
                ChoiceComboBox.Items.Add(value);
                ChoiceComboBox.SelectedIndex = 0;
        }

       
        private void ChoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When the selected index changes, we want to update the displayed data based on the new filter selection.
            DisplayData();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FilterByAisleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // When the aisle filter is selected, we want to load the combo box with the unique aisle values and update the displayed data accordingly.
            LoadFilterComboBox();
            ChoiceComboBox.SelectedIndex = 0;
            DisplayData();
        }

        private void FilterByCategoryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // When the category filter is selected, we want to load the combo box with the unique category values and update the displayed data accordingly.
            LoadFilterComboBox();
            ChoiceComboBox.SelectedIndex = 0;
            DisplayData();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Declare the search variable and delete any leading or trailing whitespace from the search term entered in the SearchTextBox.
            string search = SearchTextBox.Text.Trim();
            // Clear the DisplayListBox to prepare for showing the search results.
            DisplayListBox.Items.Clear();
            // Check if the search term is empty or consists only of whitespace.
            // If it is, show a message box prompting the user to enter a search term and return from the method to prevent further execution.
            if (string.IsNullOrWhiteSpace(search))
            {
                MessageBox.Show ("Please enter a search term.");
                return;
            }
            // Initialize a boolean variable foundAny to keep track of whether any matches were found during the search.
            bool foundAny = false;
            // Loop through each row of the customerData array to check for matches with the search term.
            for (int row = 0; row < customerData.GetLength(1); row++)
            {
                    string name = customerData[0, row];
                    string aisle = customerData[1, row];
                    string category = customerData[2, row];
                // Check if any of the fields (name, aisle, category) contain the search term, ignoring case.
                // If a match is found, add the item to the DisplayListBox and set foundAny to true.
                if ((name != null && name.IndexOf(search, StringComparison.InvariantCultureIgnoreCase) >= 0) ||
                        (aisle != null && aisle.IndexOf(search, StringComparison.InvariantCultureIgnoreCase) >= 0) ||
                        (category != null && category.IndexOf(search, StringComparison.InvariantCultureIgnoreCase) >= 0))
                    {
                        DisplayListBox.Items.Add($"{name} - {aisle} - {category}");
                        foundAny = true;
                    }
            }
            // After the loop, check if foundAny is still false, which means no matches were found.
            // If so, show a message box informing the user that there are no matches for the search term.
            if (!foundAny)
            {
                MessageBox.Show($"Sorry no matches for {search}");
                
            }
           
        }

        private void AboutTopStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm(); //instantitate the about form
            aboutForm.FormClosed += AboutForm_FormClosed; //map the FormClosed event to a handler
            aboutForm.Show(); // show the about form
            this.Hide();// hide the main form while the about form is open
        }

        private void AboutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); // show the main form again when the about form is closed
        }
    }
}
