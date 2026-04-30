/*Luke Kloer
Rcet 2265
Semester Spring 2026
RCET 2265 - Programming in C#
Etch-A-Sketch Program
GitHub URL:
https://github.com/lukekloer55-prog/ClassExamples/tree/main/Etch-A-Sketch */

using EtchASketch;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etch_A_Sketch
{
    public partial class EtchASketch : Form
    {
        public EtchASketch()
        {
            InitializeComponent();
            MainDisplayPictureBox.MouseMove += MainDisplayPictureBox_MouseStuff;
            ToolComboBox.Items.Add(2);
            ToolComboBox.Items.Add(3);
            ToolComboBox.Items.Add(4);
            ToolComboBox.Items.Add(5);
            ToolComboBox.Items.Add(6);
            ToolComboBox.Items.Add(7);
            ToolComboBox.SelectedIndex = 1;
        }

        //Declare global variables
        int oldX, oldY;
        private Color penColor = Color.Black;
        private Color BackGround = Color.White;
        private int penWidth = 3;

        void DrawLineSegment(int newX, int newY)
        {
            //create a Graphics object named g that draws on the picture box
            Graphics Draw = MainDisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(this.penColor);
            thePen.Width = this.penWidth;
            //draw the line here
            Draw.DrawLine(thePen, oldX, oldY, newX, newY);
            //free up resources
            //By clearing up resources, we prevent memory leaks and ensure that the application runs efficiently.
            Draw.Dispose();
            thePen.Dispose();
        }

        void ClearDrawing()
        {
            // create a graphics object named g that draws on the PictureBox
            Graphics Draw = MainDisplayPictureBox.CreateGraphics();

            // Shake the form
            var original = this.Location; // save the original position of the form
            var random = new Random(); // create a random number generator
            int shake_amplitude = 75; // how far the form should shake in pixels
            for (int i = 0; i < 6; i++) // shake the form 6 times
            {
                // Randomly offset the form's position
                this.Location = new Point(
                    original.X + random.Next(-shake_amplitude, shake_amplitude),
                    original.Y + random.Next(-shake_amplitude, shake_amplitude));
                // Small pause for visibility, adjust as needed for smoother or more jittery shaking
                System.Threading.Thread.Sleep(150);
            }
            // clear the drawing by filling the picture box
            Draw.Clear(Color.White);
            // Reset to original position
            this.Location = original;

            // free up resources
            Draw.Dispose();
        }

        void UpdatePenColor()
        {
            PenColorDialog.ShowDialog();
            this.penColor = PenColorDialog.Color;
        }

        void UpdateBackGroundColor()
        {
            PenColorDialog.ShowDialog();
            this.BackGround = PenColorDialog.Color;
            MainDisplayPictureBox.BackColor = this.BackGround;
        }

        void UpdatePenWidth()
        {
            this.penWidth = int.Parse(ToolComboBox.SelectedItem.ToString());
        }

        void DrawSineWave()
        {
            // create a graphics object named Draw that draws on the PictureBox
            Graphics Draw = MainDisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.Lime);
            // set the width of the pen
            thePen.Width = 3;
            int lastX = 0, lastY = 0, currentY = 0;
            // draw the line here 
            float scaleX = MainDisplayPictureBox.Width / 360f;
            float scaleY = (MainDisplayPictureBox.Height / 200f) * -1;
            // scale the x-axis so that one period of the sine wave fits in the width of the picture box
            Draw.TranslateTransform(0, MainDisplayPictureBox.Height / 2);
            // move the origin (start) of the drawing area to the center of the picture box
            Draw.ScaleTransform(scaleX, scaleY);
            // scale the drawing area so that the sine wave is wider and flip
            // the y-axis so that positive values go upinstead of down
            for (int currentX = 0; currentX < 360; currentX++)
            {
                currentY = (int)(Math.Round(100 * Math.Sin((Math.PI / 180) * currentX)));
                Draw.DrawLine(thePen, lastX, lastY, currentX, currentY);
                lastX = currentX;
                lastY = currentY;
            }
            Draw.Dispose();
            thePen.Dispose();
        }

        void DrawCosineWave()
        {
            // create a graphics object named Draw that draws on the PictureBox
            Graphics Draw = MainDisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.MediumVioletRed);
            // set the width of the pen
            thePen.Width = 3;
            int lastX = 0, lastY = 0, currentY = 0;
            // draw the line here 
            float scaleX = MainDisplayPictureBox.Width / 360f;
            float scaleY = (MainDisplayPictureBox.Height / 200f) * -1;
            // scale the x-axis so that one period of the sine wave fits in the width of the picture box
            Draw.TranslateTransform(0, MainDisplayPictureBox.Height / 2);
            Draw.ScaleTransform(scaleX, scaleY);
            // scale the drawing area so that the sine wave is wider and flip
            // the y-axis so that positive values go upinstead of down
            for (int currentX = 0; currentX < 360; currentX++)
            {
                currentY = (int)(Math.Round(100 * Math.Cos((Math.PI / 180) * currentX)));
                Draw.DrawLine(thePen, lastX, lastY, currentX, currentY);
                lastX = currentX;
                lastY = currentY;
            }
            Draw.Dispose();
            thePen.Dispose();
        }

        void DrawTangentWave()
        {
            // create a graphics object named Draw that draws on the PictureBox
            Graphics Draw = MainDisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.Purple);
            // set the width of the pen
            thePen.Width = 3;
            int lastX = 0, lastY = 0, currentY = 0;
            // draw the line here 
            float scaleX = MainDisplayPictureBox.Width / 360f;
            float scaleY = (MainDisplayPictureBox.Height / 200f) * -1;
            // scale the x-axis so that one period of the sine wave fits in the width of the picture box
            Draw.TranslateTransform(0, MainDisplayPictureBox.Height / 2);
            Draw.ScaleTransform(scaleX, scaleY);
            // scale the drawing area so that the sine wave is wider and flip
            // the y-axis so that positive values go upinstead of down

            for (int currentX = 0; currentX < 360; currentX++)
            {
                currentY = (int)(Math.Round(100 * Math.Tan((Math.PI / 180) * currentX)));
                //(long) had to be used due to the fact that the tangent wave kept throwing a 
                //the negating of a twos complement overflow exception when the value of the tangent wave got too high
                //this was due to the fact that the tangent wave went to infinity which negated the 32bit integer limit and
                //caused the exception to be thrown
                if (Math.Abs((long)currentY) < MainDisplayPictureBox.Height / 2)
                {
                    Draw.DrawLine(thePen, lastX, lastY, currentX, currentY);
                }
                lastX = currentX;
                lastY = currentY;
                // makes sure that the tan wave doesn't draw that would be outside
                // the picture box
            }
            //free up resorces
            Draw.Dispose();
            thePen.Dispose();
        }

        void DrawGrid()
        {
            // create a graphics object named Draw that draws on the PictureBox
            Graphics Draw = MainDisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.LightGray);
            // set the width of the pen
            thePen.Width = 1;
            // draw the line here 
            for (int x = 0; x < MainDisplayPictureBox.Width; x += 100)
            {
                Draw.DrawLine(thePen, x, 0, x, MainDisplayPictureBox.Height);
            }
            for (int y = 0; y < MainDisplayPictureBox.Height; y += 100)
            {
                Draw.DrawLine(thePen, 0, y, MainDisplayPictureBox.Width, y);
            }
            Draw.Dispose();
            thePen.Dispose();
        }

        // Event handlers -----------------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            DrawTangentWave();
            DrawCosineWave();
            DrawSineWave();
            DrawGrid();
        }

        private void MainDisplayPictureBox_MouseStuff(object sender, MouseEventArgs e)
        {
            DrawingStatusLabel.Text = $"({e.X},{e.Y}) | {e.Button} " +
                $"| {this.penColor} | {this.penWidth}";

            switch (e.Button)
            {
                case MouseButtons.Left:
                    DrawLineSegment(e.X, e.Y); // only draw when the left mouse button is down
                    break;
                case MouseButtons.Right:
                    // Save for context menu
                    break;
                case MouseButtons.Middle:
                    UpdatePenColor();
                    // TODO open color picker dialogue
                    break;
                default:
                    //MessageBox.Show($"{e.Button}");
                    break;
            }
            // save the current mouse position for the next time we draw a line segment
            this.oldX = e.X;
            this.oldY = e.Y;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear the drawing by filling the picture box with the background color
            ClearDrawing();
        }


        private void PenMenuItem_Click(object sender, EventArgs e)
        {
            // Update the pen color based on the user's selection in the menu item
            UpdatePenColor();
        }

        private void BackGroundMenuItem_Click(object sender, EventArgs e)
        {
            // Update the background color based on the user's selection in the menu item
            UpdateBackGroundColor();
        }

        private void ToolComboBox_Click(object sender, EventArgs e)
        {
            // Update the pen width based on the selected item in the combo box
            UpdatePenWidth();
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

        //With the declaration of the menu clicks being tied to their respective event handlers, the application can now respond to user interactions with the menu items.
        //This is instead of the decleration of all these values in the main form's constructor, which would make the code more cluttered and less organized.

    }
}
