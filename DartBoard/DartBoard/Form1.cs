using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DartBoard
{
    public partial class DartGameSimulator : Form
    {
        // Number of darts thrown in the current round.
        int DartCount = 0;

        // Spacebar throws are allowed only when this is true.
        bool roundstart = false;

        // Store the X and Y coordinates of all three darts.
        int x1, y1, x2, y2, x3, y3;

        // Number of the round being played or reviewed.
        int roundNumber = 0;

        // Reuse one random number generator for all throws.
        Random rand = new Random();

        public DartGameSimulator()
        {
            // Create the controls configured in the Designer.
            InitializeComponent();

            // Run Form1_keyDown when the form receives a key press.
            KeyDown += Form1_keyDown;

            // Display the starting round, dart count, and mode.
            UpdateStatus("Play");

            // Fill the dropdown with previously saved games.
            LoadLogFiles(@"..\..\DartGame.log");
        }

        void UpdateStatus(string mode)
        {
            // Show the current game information in the status bar.
            statusLabel.Text =
                $"Round: {roundNumber}   Darts: {DartCount}/3   Mode: {mode}";

            // ! means "not", so these controls are disabled during play.
            // This prevents starting or reviewing another round midway.
            StartRoundButton.Enabled = !roundstart;
            ReviewButton.Enabled = !roundstart;
            LogFileComboBox.Enabled = !roundstart;
        }

        void DrawDart(int x, int y)
        {
            // Get a drawing surface for the PictureBox.
            // The pen draws red lines with a thickness of 3 pixels.
            // using releases these drawing resources when finished.
            using (Graphics g = DisplaypictureBox.CreateGraphics())
            using (Pen thepen = new Pen(Color.Red, 3))
            {
                int size = 20;

                // Offset the circle so its center is at x, y.
                g.DrawEllipse(
                    thepen,
                    x - size / 2,
                    y - size / 2,
                    size,
                    size);

                // Draw vertical and horizontal lines through the center.
                g.DrawLine(thepen, x, y - 10, x, y + 10);
                g.DrawLine(thepen, x - 10, y, x + 10, y);
            }

            // Count the dart that was just thrown.
            DartCount++;

            // Save its position in the matching coordinate variables.
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

            // Show the updated throw count.
            UpdateStatus("Play");

            // Each round ends after exactly three darts.
            if (DartCount == 3)
            {
                DartGameComplete();
            }
        }

        void DartGameComplete()
        {
            // Stop accepting throws and allow the review controls.
            roundstart = false;
            UpdateStatus("Review");

            // Relative path to the game's log file.
            string path = @"..\..\DartGame.log";

            // Build one line containing the complete round.
            // The | character separates the round and dart sections.
            string game =
                $"Round {roundNumber} | " +
                $"Dart 1: {x1},{y1} | " +
                $"Dart 2: {x2},{y2} | " +
                $"Dart 3: {x3},{y3}";

            // LogDataToFile returns false if saving was unsuccessful.
            // return stops this method when that happens.
            if (!LogDataToFile(path, game))
            {
                return;
            }

            // Refresh the dropdown to include the completed game.
            LoadLogFiles(path);

            // Ask whether the player wants another round.
            DialogResult choice = MessageBox.Show(
                "Would you like to start a new game?\n" +
                "Choose No to view the results.",
                "Game Over",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Reuse the Start Round handler if the player chooses Yes.
            // Choosing No leaves the game in Review mode.
            if (choice == DialogResult.Yes)
            {
                StartRoundButton_Click(this, EventArgs.Empty);
            }
        }

        int GetNumberFrom(int max, int min = 0)
        {
            // min defaults to zero when no value is supplied.
            // max is excluded, so a width of 800 gives values 0–799.
            return rand.Next(min, max);
        }

        int GetNextRoundNumber(string path)
        {
            int highestRound = 0;

            // No log file means there are no saved rounds yet.
            if (!File.Exists(path))
            {
                return 1;
            }

            // Read each saved round from the file.
            foreach (string line in File.ReadAllLines(path))
            {
                // Ignore empty lines.
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                // Split the entry into its round and dart sections.
                string[] parts = line.Split('|');

                // Trim removes spaces around the round heading.
                string roundText = parts[0].Trim();

                // Check the heading and read the number after "Round ".
                // Substring(6) skips the six characters in "Round ".
                // TryParse returns false if the text is not an integer.
                if (!roundText.StartsWith("Round ") ||
                    !int.TryParse(
                        roundText.Substring(6), out int savedRound) ||
                    savedRound < 1)
                {
                    // The Start Round handler catches this error.
                    throw new FormatException(
                        "The log contains an invalid round number.");
                }

                // Keep the largest round number found so far.
                highestRound = Math.Max(highestRound, savedRound);
            }

            // Continue numbering after the highest saved round.
            return highestRound + 1;
        }

        void LoadLogFiles(string path)
        {
            // Remove old dropdown items before loading them again.
            LogFileComboBox.Items.Clear();

            try
            {
                // There is nothing to load if the file does not exist.
                if (!File.Exists(path))
                {
                    return;
                }

                // Each array element contains one line from the file.
                string[] games = File.ReadAllLines(path);

                foreach (string game in games)
                {
                    if (string.IsNullOrWhiteSpace(game))
                    {
                        continue;
                    }

                    // Extract the round number from the first section.
                    string[] parts = game.Split('|');
                    string roundText = parts[0].Trim();
                    int savedRound = int.Parse(roundText.Substring(6));

                    // Show the game number without showing coordinates.
                    LogFileComboBox.Items.Add($"Game {savedRound}");
                }
            }
            catch (Exception ex)
            {
                // Remove any partially loaded items if loading fails.
                LogFileComboBox.Items.Clear();

                // Explain the error instead of allowing it to crash the app.
                MessageBox.Show("Could not load games: " + ex.Message);
            }
        }

        bool LogDataToFile(string path, string game)
        {
            try
            {
                // Check existing entries before adding this round.
                if (File.Exists(path))
                {
                    foreach (string line in File.ReadAllLines(path))
                    {
                        // Read only the round heading from each entry.
                        string heading = line.Split('|')[0].Trim();

                        // Do not save the same round number twice.
                        if (heading == $"Round {roundNumber}")
                        {
                            MessageBox.Show(
                                "This round has already been saved.");

                            return false;
                        }
                    }
                }

                // Append preserves previous results and adds this game.
                // It creates the file if it does not already exist.
                // NewLine ensures the next game starts on a separate line.
                File.AppendAllText(path, game + Environment.NewLine);

                // Tell the calling method that saving succeeded.
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save game: " + ex.Message);

                // Tell the calling method that saving failed.
                return false;
            }
        }

        // Runs when the player clicks the Review button.
        private void ReviewButton_Click(object sender, EventArgs e)
        {
            // Prevent reviewing while a round is still active.
            if (roundstart)
            {
                return;
            }

            // -1 means no dropdown item has been selected.
            if (LogFileComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Choose a game to review.");
                return;
            }

            try
            {
                string path = @"..\..\DartGame.log";
                string[] games = File.ReadAllLines(path);

                // Convert "Game 1" from the dropdown into "Round 1"
                // so it matches the heading stored in the file.
                string selectedRound =
                    LogFileComboBox.SelectedItem.ToString()
                    .Replace("Game ", "Round ");

                string game = "";

                // Search the file for the selected round.
                foreach (string line in games)
                {
                    if (line.Split('|')[0].Trim() == selectedRound)
                    {
                        game = line;

                        // Stop searching once the game is found.
                        break;
                    }
                }

                // An empty string means no matching entry was found.
                if (game == "")
                {
                    MessageBox.Show(
                        "The selected game could not be found.");

                    return;
                }

                string[] sections = game.Split('|');

                // Expect one round heading and three dart sections.
                if (sections.Length != 4)
                {
                    MessageBox.Show("Invalid game format.");
                    return;
                }

                // Store the saved coordinates for the three darts.
                int[] xPositions = new int[3];
                int[] yPositions = new int[3];

                for (int i = 0; i < 3; i++)
                {
                    // i + 1 skips the round heading at index zero.
                    // Splitting at : separates "Dart 1" from its coordinates.
                    string[] parts = sections[i + 1].Split(':');

                    // Splitting at the comma separates X from Y.
                    string[] coordinates = parts[1].Trim().Split(',');

                    // Convert the coordinate text into integers.
                    xPositions[i] = int.Parse(coordinates[0]);
                    yPositions[i] = int.Parse(coordinates[1]);
                }

                // Show the selected round's information in the status bar.
                roundNumber =
                    int.Parse(sections[0].Trim().Substring(6));

                DartCount = 3;
                roundstart = false;

                UpdateStatus("Review");

                // Clear existing drawings before showing the saved darts.
                DisplaypictureBox.Refresh();

                using (Graphics g = DisplaypictureBox.CreateGraphics())
                using (Pen pen = new Pen(Color.Red, 3))
                {
                    // Draw directly so reviewing does not count throws
                    // or trigger another save through DrawDart.
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
                // Handle file-reading errors or invalid saved values.
                MessageBox.Show("Could not review game: " + ex.Message);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Close the main form.
            this.Close();
        }

        private void Form1_keyDown(object sender, KeyEventArgs e)
        {
            // Ignore keys other than Space.
            if (e.KeyCode == Keys.Space)
            {
                // Prevent Space from also activating a focused button.
                e.SuppressKeyPress = true;

                // Only throw a dart after a round has started.
                if (roundstart)
                {
                    // Use the PictureBox's drawable width and height.
                    int x = GetNumberFrom(
                        DisplaypictureBox.ClientSize.Width);

                    int y = GetNumberFrom(
                        DisplaypictureBox.ClientSize.Height);

                    DrawDart(x, y);
                }
            }
        }

        private void StartRoundButton_Click(object sender, EventArgs e)
        {
            // Do not restart a round that is already running.
            if (roundstart)
            {
                return;
            }

            try
            {
                string path = @"..\..\DartGame.log";

                // Read the file so numbering continues after restarting.
                roundNumber = GetNextRoundNumber(path);

                // Reset the throw count for the new round.
                DartCount = 0;

                // Clear old drawings and allow Spacebar throws.
                DisplaypictureBox.Refresh();
                roundstart = true;

                UpdateStatus("Play");
            }
            catch (Exception ex)
            {
                // Handle problems reading the previous round numbers.
                MessageBox.Show("Could not start round: " + ex.Message);
            }
        }
    }
}