using System.Runtime.CompilerServices;

namespace ListExamples
{
    public partial class ListExamplesForm : Form
    {
        public ListExamplesForm()
        {
            
            InitializeComponent();  

            
        }
        //Custom Methods below here

        void ListExamplesForm_Load(object sender, EventArgs e)
        {
            List<string> names = new List<string>();
            names.Add("John");
            names.Add("Jane");
            names.Add("Jack");
            this.Text = names.Count.ToString();
        }

        void AddItemToListBox()
        {
            DisplayListBox.Items.Add($"{LastNameTextBox.Text},{FirstNameTextBox.Text} {CompanyTextBox.Text}");
        }

        void AddItemToComboBox()
        {
            SelectionComboBox.Items.Add($"{LastNameTextBox.Text},{FirstNameTextBox.Text} {CompanyTextBox.Text}");

            if (SelectionComboBox.Items.Count > 0)
            {
                SelectionComboBox.SelectedIndex = 0;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //ListExamplesForm_Load(sender, e);
            AddItemToListBox();
            AddItemToComboBox();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DisplayListBox.Items.Clear();
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            CompanyTextBox.Text = "";
        }

        private void DisplayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] temp = DisplayListBox.SelectedItem.ToString().Split(" ");
            CompanyTextBox.Text = temp[1];
            temp = temp[0].Split(",");
            FirstNameTextBox.Text = temp[1];
            LastNameTextBox.Text = temp[0];
            //this.Text = DisplayListBox.SelectedIndex.ToString();   
        }

        private void SelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayListBox.SelectedIndex = SelectionComboBox.SelectedIndex;
        }

        void Validation(object sender, EventArgs e) 
        {
            bool valid = false;

            if (FirstNameTextBox.Text != "")
            {
                FirstNameTextBox.BackColor = Color.White;
                valid = true;
            }

            else
            {  
                FirstNameTextBox.BackColor = Color.LightYellow;
                valid = false;
            }

            if (LastNameTextBox.Text != "")
            {
                LastNameTextBox.BackColor = Color.White;
                valid = true;
            }

            else
            {
                LastNameTextBox.BackColor = Color.LightYellow;
                valid = false;
            }

            if (CompanyTextBox.Text != "")
            {
                CompanyTextBox.BackColor = Color.White;
                valid = true;
            }

            else
            {
                CompanyTextBox.BackColor = Color.LightYellow;
                valid = false;
            }

            if (valid == false)
            {
                SubmitButton.Enabled = false;
            }

            else
            { 
                SubmitButton.Enabled = true;
            }

        }
    }
}
