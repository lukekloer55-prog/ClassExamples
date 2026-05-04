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
        string[,] customerData = new string[0, 0];
        string filePath = "..\\..\\..\\Grocery.txt";

        public StansGroceryForm()
        {
            InitializeComponent();
            SetDefaults();
            FileToArray(filePath);
            LoadFilterComboBox();
            ChoiceComboBox.SelectedIndex = 0;
            DisplayData();
        }

        private void SetDefaults()
        {
           
            FilterByAisleRadioButton.Checked = false; // IMPORTANT FIX
            FilterByCategoryRadioButton.Checked = false;
        }

        
        int CountOfLinesIn(string filePath)
        {
            int count = 0;

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.ReadLine() != null)
                    count++;
            }

            return count;
        }

        
        string CleanField(string input)
        {
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

      
        void FileToArray(string filePath)
        {
            int rows = CountOfLinesIn(filePath);

            string[,] _customerData = new string[4, rows];

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                int counter = 0;

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

       
        void DisplayData()
        {
            DisplayListBox.Items.Clear();

            if (customerData.GetLength(1) == 0 || ChoiceComboBox.SelectedItem == null)
                return;

            string selectedFilter = ChoiceComboBox.SelectedItem.ToString();
            bool showAll = ChoiceComboBox.SelectedIndex == 0;

            string search = SearchTextBox.Text ?? "";

            for (int row = 0; row < customerData.GetLength(1); row++)
            {
                if (customerData[0, row] == null)
                    continue;

               
                string item;

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

              
                int filterColumn = FilterByCategoryRadioButton.Checked ? 2 : 1;

                bool matchesFilter =
                    showAll || customerData[filterColumn, row] == selectedFilter;

             
                bool matchesSearch =
                    item.IndexOf(search, StringComparison.InvariantCultureIgnoreCase) >= 0;

                if (matchesFilter && matchesSearch)
                {
                    DisplayListBox.Items.Add(item);
                }
            }
        }

       
        void LoadFilterComboBox()
        {
            ChoiceComboBox.Items.Clear();
            ChoiceComboBox.Items.Add("Show All");

            int column = FilterByCategoryRadioButton.Checked ? 2 : 1;

            for (int row = 0; row < customerData.GetLength(1); row++)
            {
                string value = customerData[column, row];

                if (!string.IsNullOrEmpty(value) &&
                    !ChoiceComboBox.Items.Contains(value))
                {
                    ChoiceComboBox.Items.Add(value);
                }
            }

            ChoiceComboBox.Sorted = true;
            ChoiceComboBox.SelectedIndex = 0;
        }

       
        private void ChoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FilterByAisleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LoadFilterComboBox();
            ChoiceComboBox.SelectedIndex = 0;
            DisplayData();
        }

        private void FilterByCategoryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LoadFilterComboBox();
            ChoiceComboBox.SelectedIndex = 0;
            DisplayData();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string search = SearchTextBox.Text.Trim();

            DisplayListBox.Items.Clear();

            if (string.IsNullOrWhiteSpace(search))
            {
                MessageBox.Show ("Please enter a search term.");
                return;
            }

            bool foundAny = false;

            for (int row = 0; row < customerData.GetLength(1); row++)
            {
                 
                    string name = customerData[0, row];
                    string aisle = customerData[1, row];
                    string category = customerData[2, row];

                    if ((name != null && name.IndexOf(search, StringComparison.InvariantCultureIgnoreCase) >= 0) ||
                        (aisle != null && aisle.IndexOf(search, StringComparison.InvariantCultureIgnoreCase) >= 0) ||
                        (category != null && category.IndexOf(search, StringComparison.InvariantCultureIgnoreCase) >= 0))
                    {
                        DisplayListBox.Items.Add($"{name} - {aisle} - {category}");
                        foundAny = true;
                    }
                
            }

            if (!foundAny)
            {
                MessageBox.Show($"Sorry no matches for {search}");
                
            }
           
        }
    }
}
