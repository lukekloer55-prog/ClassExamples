using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DartBoard
{
    public partial class DartGameSimulator : Form
    {
        int DartCount = 0;
        bool roundstart = false;
        int x1, y1, x2, y2, x3, y3;
        int roundNumber = 0;

        Random rand = new Random();

        public DartGameSimulator()
        {
            InitializeComponent();

            KeyDown += Form1_keyDown;

            UpdateStatus("Play");

            LoadLogFiles(@"..\..\DartGame.log");
        }

        void UpdateStatus(string mode)
        {
            statusLabel.Text =
                $"Round: {roundNumber}   Darts: {DartCount}/3   Mode: {mode}";

            StartRoundButton.Enabled = !roundstart;
            ReviewButton.Enabled = !roundstart;
            LogFileComboBox.Enabled = !roundstart;
        }

        void DrawDart(int x, int y)
        {
            using (Graphics g = DisplaypictureBox.CreateGraphics())
            using (Pen thepen = new Pen(Color.Red, 3))
            {
                int size = 20;

                g.DrawEllipse(
                    thepen,
                    x - size / 2,
                    y - size / 2,
                    size,
                    size);

                g.DrawLine(thepen, x, y - 10, x, y + 10);
                g.DrawLine(thepen, x - 10, y, x + 10, y);
            }

            DartCount++;

            switch (DartCount)
            {
                case 1:
                    x1 = x;
                    y1 = y;
                    break;

                case 2:
                    x2 = x;
                    y2 = y;
                    break;

                case 3:
                    x3 = x;
                    y3 = y;
                    break;
            }

            UpdateStatus("Play");

            if (DartCount == 3)
            {
                DartGameComplete();
            }
        }

        void DartGameComplete()
        {
            roundstart = false;
            UpdateStatus("Review");

            string path = @"..\..\DartGame.log";

            string game = $"Round {roundNumber} | " + $"Dart 1: {x1},{y1} | " + $"Dart 2: {x2},{y2} | " +
                $"Dart 3: {x3},{y3}";

            if (!LogDataToFile(path, game))
            {
                return;
            }

            LoadLogFiles(path);

            DialogResult choice = MessageBox.Show("Would you like to start a new game?\n" + "Choose No to view the results.",
                "Game Over",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (choice == DialogResult.Yes)
            {
                StartRoundButton_Click(this, EventArgs.Empty);
            }
        }

        int GetNumberFrom(int max, int min = 0)
        {
            // max is excluded so the center stays inside the board.
            return rand.Next(min, max);
        }

        int GetNextRoundNumber(string path)
        {
            int highestRound = 0;

            if (!File.Exists(path))
            {
                return 1;
            }

            foreach (string line in File.ReadAllLines(path))
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] parts = line.Split('|');
                string roundText = parts[0].Trim();

                if (!roundText.StartsWith("Round ") || !int.TryParse(roundText.Substring(6), out int savedRound) || savedRound < 1)
                {
                    throw new FormatException(
                        "The log contains an invalid round number.");
                }

                highestRound = Math.Max(highestRound, savedRound);
            }

            return highestRound + 1;
        }

        void LoadLogFiles(string path)
        {
            LogFileComboBox.Items.Clear();

            try
            {
                if (!File.Exists(path))
                {
                    return;
                }

                string[] games = File.ReadAllLines(path);

                foreach (string game in games)
                {
                    if (string.IsNullOrWhiteSpace(game))
                    {
                        continue;
                    }

                    string[] parts = game.Split('|');
                    string roundText = parts[0].Trim();
                    int savedRound = int.Parse(roundText.Substring(6));

                    LogFileComboBox.Items.Add($"Game {savedRound}");
                }
            }
            catch (Exception ex)
            {
                LogFileComboBox.Items.Clear();

                MessageBox.Show("Could not load games: " + ex.Message);
            }
        }

        bool LogDataToFile(string path, string game)
        {
            try
            {
                // Check that this round has not already been saved.
                if (File.Exists(path))
                {
                    foreach (string line in File.ReadAllLines(path))
                    {
                        string heading = line.Split('|')[0].Trim();

                        if (heading == $"Round {roundNumber}")
                        {
                            MessageBox.Show("This round has already been saved.");

                            return false;
                        }
                    }
                }

                // Creates the file if it does not exist.
                File.AppendAllText(path, game + Environment.NewLine);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save game: " + ex.Message);

                return false;
            }
        }

        // Event handlers.
        private void ReviewButton_Click(object sender, EventArgs e)
        {
            if (roundstart)
            {
                return;
            }

            if (LogFileComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Choose a game to review.");
                return;
            }

            try
            {
                string path = @"..\..\DartGame.log";
                string[] games = File.ReadAllLines(path);

                string selectedRound = LogFileComboBox.SelectedItem.ToString()
                    .Replace("Game ", "Round ");

                string game = "";

                // Find the entry matching the selected game number.
                foreach (string line in games)
                {
                    if (line.Split('|')[0].Trim() == selectedRound)
                    {
                        game = line;
                        break;
                    }
                }

                if (game == "")
                {
                    MessageBox.Show("The selected game could not be found.");

                    return;
                }

                string[] sections = game.Split('|');

                if (sections.Length != 4)
                {
                    MessageBox.Show("Invalid game format.");
                    return;
                }

                int[] xPositions = new int[3];
                int[] yPositions = new int[3];

                for (int i = 0; i < 3; i++)
                {
                    string[] parts = sections[i + 1].Split(':');
                    string[] coordinates = parts[1].Trim().Split(',');

                    xPositions[i] = int.Parse(coordinates[0]);
                    yPositions[i] = int.Parse(coordinates[1]);
                }

                roundNumber =
                    int.Parse(sections[0].Trim().Substring(6));

                DartCount = 3;
                roundstart = false;

                UpdateStatus("Review");
                DisplaypictureBox.Refresh();

                using (Graphics g = DisplaypictureBox.CreateGraphics())
                using (Pen pen = new Pen(Color.Red, 3))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        int x = xPositions[i];
                        int y = yPositions[i];

                        g.DrawEllipse(
                            pen, x - 10, y - 10, 20, 20);

                        g.DrawLine(
                            pen, x, y - 10, x, y + 10);

                        g.DrawLine(
                            pen, x - 10, y, x + 10, y);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not review game: " + ex.Message);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;

                if (roundstart)
                {
                    int x = GetNumberFrom(DisplaypictureBox.ClientSize.Width);

                    int y = GetNumberFrom(DisplaypictureBox.ClientSize.Height);

                    DrawDart(x, y);
                }
            }
        }

        private void StartRoundButton_Click(object sender, EventArgs e)
        {
            if (roundstart)
            {
                return;
            }

            try
            {
                string path = @"..\..\DartGame.log";

                roundNumber = GetNextRoundNumber(path);
                DartCount = 0;

                DisplaypictureBox.Refresh();
                roundstart = true;

                UpdateStatus("Play");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not start round: " + ex.Message);
            }
        }

    }
}