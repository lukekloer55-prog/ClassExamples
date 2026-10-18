using System.Security.Cryptography.Xml;
using System.Xml.Serialization;

namespace DartBoard
{
    public partial class Form1 : Form
    {
        int DartCount = 0;
        bool roundstart = false;
        int x1, y1,x2, y2, x3, y3;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += Form1_keyDown;
            
        }


        void DrawDart(int x, int y)
        {
            Graphics g = DisplaypictureBox.CreateGraphics();
            Pen thepen = new Pen(Color.Red, 3);
            int size = 20;
            g.DrawEllipse(thepen, x - size / 2, y - size / 2, size, size);
            g.DrawLine(thepen, x, y - 10, x, y + 10);
            g.DrawLine(thepen, x - 10, y, x + 10, y);
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
                    y3= y;
                    break;
            }

            string filesave = $"{DartCount}, {x}, {y}";
            

            if (DartCount >= 3)
            {
                DartGameComplete();
            }

        }

        void DartGameComplete()
        {
            
            DialogResult choice = MessageBox.Show("Would you like to start a new game?\n Choose no to quit the game.", "Game Over",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)

            {

            }
            else
            {

            }

        }

        int GetNumberFrom(int max, int min = 0)
        {
            Random rand = new Random();
            return rand.Next(min, max + 1);
        }

        void LoadLogFiles()
        {
            LogFileComboBox.Items.Clear();
            try
            {
                string[] logFiles = Directory.GetFiles("..\\..\\DartGame.log");
                foreach (string file in logFiles)
                {
                    LogFileComboBox.Items.Add(Path.GetFileName(file));
                }
            }
            catch (Exception)
            {
                Directory.CreateDirectory("..\\..\\DartGame.log");
            }
        }

        static void LogDataToFile(int currentData)
        {
            try
            {
                string path = $"..\\..\\logs\\{DateTime.Now.ToString("yyyyMMddhh")}_data.log";
                using (StreamWriter currentFile = File.AppendText(path))
                {
                    currentFile.WriteLine($"{DateTime.Now:yyyyMMddhhmmss}{DateTime.Now.Millisecond:D3},{currentData}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Event Handler Code starts here
        private void ReviewButton_Click(object sender, EventArgs e)
        {

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_keyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Space)
            {

                e.SuppressKeyPress = true;

                if (roundstart == true)
                {
                    int x = GetNumberFrom(DisplaypictureBox.Width);
                    int y = GetNumberFrom(DisplaypictureBox.Height);
                    DrawDart(x, y);
                }

            }

        }

        private void StartRoundButton_Click(object sender, EventArgs e)
        {
            roundstart = true;
        }
    }
}
