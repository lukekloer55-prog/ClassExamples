namespace RollTheDiceListBox
{
    public partial class RollOfTheDice : Form
    {
        public RollOfTheDice()
        {
            InitializeComponent();
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
            string diceFace = "";
            string currentLine = "";
            ResultsListBox.Items.Add("Roll of the Dice");
            ResultsListBox.Items.Add("________________________________________");
            ResultsListBox.Items.Add("Number of faces: ");
            ResultsListBox.Items.Add("________________________________________");

            for (int j = 0; j < 6; j++)
            {
                int[] diceoptions = { 1, 2, 3, 4, 5, 6 };
                diceFace += (diceoptions[j].ToString().PadLeft(6));
                //Writes the numbers 1-6 to represent the faces of the die. 
            }

            ResultsListBox.Items.Add(diceFace);
            ResultsListBox.Items.Add("________________________________________");
            ResultsListBox.Items.Add("Resulting Counts:");
            ResultsListBox.Items.Add("________________________________________");
            

            int[] rollCount = new int[7];
            int[] rollCount2 = new int[7];// Initializes two integer arrays to count the occurrences of each face for both dice.

            for (int i = 1; i <= 1000; i++)
            {
                var (dice1, dice2) = RollTheDice();
                rollCount[dice1]++;
                rollCount[dice2]++;
                // Calls the RollTheDice method 1000 times and counts the occurrences of each face for both dice.
            }

            for (int j = 1; j < 7; j++)
            {
                currentLine += (rollCount[j].ToString().PadLeft(6));
                // Writes the count of occurrences for each face of the die, formatted to align with the numbers above.
            }

            ResultsListBox.Items.Add(currentLine);
            ResultsListBox.Items.Add("________________________________________");
            
        }

        static (int diceroll1, int diceroll2) RollTheDice()
        {

            Random random = new Random();
            int diceRoll = random.Next(1, 7);  // Simulate rolling a six-sided die
            int diceRoll2 = random.Next(1, 7); // Simulate rolling another six-sided die
                                               // Return the results as a tuple
                                               // A tuple is a way to hold and use multiple outputs within a class, instead of using out methods. 
                                               // It can be found microsoft documentation online. 
            return (diceRoll, diceRoll2);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetDefaults()
        {
            ResultsListBox.Items.Clear();
        }
}
}
