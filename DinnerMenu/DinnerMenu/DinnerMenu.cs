/*Luke Kloer
Rcet 2265
Semester Spring 2026
RCET 2265 - Programming in C#
DinnerMenu Program
GitHub URL:
https://github.com/lukekloer55-prog/ClassExamples/tree/main/DinnerMenu */

namespace DinnerMenu
{
    public partial class DinnerMenu : Form
    {
        public DinnerMenu()
        {
            InitializeComponent();
            this.Text = "Dinner Menu";
            // This sets the title of the form to "Dinner Menu".
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
            // This handles the click event for the ExitButton.
            // When the button is clicked, it closes the form, effectively exiting the application.
        }

        private void SoupButton_Click(object sender, EventArgs e)
        {
            ItemDisplayLabel.Text = $"{"Soup of the Day:"} \n {"Mixed Greens"}";
            DescItemLabel.Text = $"{"A delicious potato soup made with fresh ingredients."}";
            // This handles the click event for the SoupButton.
            // When the button is clicked, it updates the ItemDisplayLabel to show the name of the soup dish and the DescItemLabel to provide a description of the dish.
        }

        private void SaladButton_Click(object sender, EventArgs e)
        {
            ItemDisplayLabel.Text = $"{"Salad of the Day:"} \n {"Mixed Greens"}";
            DescItemLabel.Text = $"{"A refreshing salad made with crisp greens and a tangy dressing."}";
            // This handles the click event for the SaladButton.
            // When the button is clicked, it updates the ItemDisplayLabel to show the name of the salad dish and the DescItemLabel to provide a description of the dish.
        }

        private void FishButton_Click(object sender, EventArgs e)
        {
            ItemDisplayLabel.Text = $"{"Fish of the Day:"} \n {"Mixed Greens"}";
            DescItemLabel.Text = $"{"A flavorful lemon fish dish prepared with the freshest catch."}";
            // This deals with the click event of the FishButton.
            // When the button is clicked, it updates the ItemDisplayLabel to show the name of the fish dish and the DescItemLabel to provide a description of the dish.
        }
    }
}
