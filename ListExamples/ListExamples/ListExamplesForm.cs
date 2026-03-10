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
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ListExamplesForm_Load(sender, e);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
