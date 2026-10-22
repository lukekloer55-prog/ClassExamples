namespace BetterEtch_O_Sketch
{
    public partial class EtchASketch : Form
    {
        bool MouseControlEnabled = false;
        bool ExternalControlEnabled = false;
        public EtchASketch()
        {
            InitializeComponent();
        }

        void DrawSketch()
        {
            Point cursorPosInPictureBox = DisplayPictureBox.PointToClient(Cursor.Position);

            if (MouseControlEnabled && DisplayPictureBox.ClientRectangle.Contains(cursorPosInPictureBox))
            {
                if (MouseClick= true)
                Point MousePosition = new Point(0, 0);

            }







        }




        //Event Handlers Start Here .......................................................
        private void SelectColorButton_Click(object sender, EventArgs e)
        {

        }

        private void DrawWaveformsButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MouseRadioButton.Checked) 
            {
                MouseControlEnabled = true;
                ExternalControlEnabled = false;
            }
        }

        private void ExternalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ExternalRadioButton.Checked)
            {
                ExternalControlEnabled = true;
                MouseControlEnabled = false;  
            } 
        }
    }
}
