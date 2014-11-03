using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint2
{
    public partial class Form1 : Form
    {
        private ArrayList thingsToPaint = new ArrayList(); // an array of all paintable elements
        private Boolean firstClick = true; // keep track of whether this is the first click on the form
        private Point p1, p2, topLeftPoint; // placeholders for mouse coordinates after click
        private string whichShape;
        private Pen pen;
        private Brush brush;
        private Brush textBrush;
        private Font font = new Font("Arial", 10);
        private Boolean isFilled, isOutlined; // checkbox controlled

        // function to draw all shapes
        private void drawAllThings(Graphics g)
        {
            foreach (Paintable thing in thingsToPaint)
            {
                thing.Draw(g);
            }
        }

        public Form1()
        {
            InitializeComponent();
            initControls();
        }

        private void initControls()
        {
            this.outlineColorBox.SetSelected(0, true);
            this.fillColorBox.SetSelected(0, true);
            this.penWidthBox.SetSelected(0, true);
            this.radioButton1.Select();
            this.Height = 600;
            this.Width = 800;
        }

        private int currentOutlineWidth()
        {
            return Convert.ToInt32(this.penWidthBox.SelectedItem.ToString());
        }

        private void setOutlineColor()
        {
            switch (this.outlineColorBox.SelectedItems[0].ToString())
            {
                case "Black" :
                    pen = new Pen(Color.Black, currentOutlineWidth());
                    textBrush = Brushes.Black;
                    break;
                case "Blue" :
                    pen = new Pen(Color.Blue, currentOutlineWidth());
                    textBrush = Brushes.Blue;
                    break;
                case "Red" :
                    pen = new Pen(Color.Red, currentOutlineWidth());
                    textBrush = Brushes.Red;
                    break;
                case "Green" :
                    pen = new Pen(Color.Green, currentOutlineWidth());
                    textBrush = Brushes.Green;
                    break;
                default :
                    pen = new Pen(Color.Black, currentOutlineWidth());
                    textBrush = Brushes.Black;
                    break;
            }
        }

        private void setFillColor()
        {
            
            switch (this.fillColorBox.SelectedItem.ToString())
            {
                case "Black":
                    brush = Brushes.Black;
                    break;
                case "White" :
                    brush = Brushes.White;
                    break;
                case "Blue" :
                    brush = Brushes.Blue;
                    break;
                case "Red" :
                    brush = Brushes.Red;
                    break;
                case "Green" :
                    brush = Brushes.Green;
                    break;
                default :
                    brush = Brushes.Black;
                    break;
            }
        }

        private void setWhichShape() // look at the radio buttons and decide what to draw
        {
            foreach (Control control in shapePanel.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton r = control as RadioButton;
                    if (r.Checked)
                    {
                        whichShape = r.Text;
                    }
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (firstClick)
            {
                firstClick = false;
                p1 = new Point(e.X, e.Y); // store this point
            }
            else
            {
                firstClick = true;
                p2 = new Point(e.X, e.Y); // now we have a p1 and p2, so we can draw
                setWhichShape(); // find out what to draw
                if (whichShape != null) // if a shape is selected
                {
                    setFillColor();
                    setOutlineColor();
                    if (whichShape == "Line")
                    {
                        thingsToPaint.Add(new paintLine(p1, p2, pen));
                    }
                    else // not a line, define a bounding box
                    {
                        topLeftPoint.X = Math.Min(p1.X, p2.X); // figure out the left point
                        topLeftPoint.Y = Math.Min(p1.Y, p2.Y); // figure out the left point
                        int height = Math.Abs(p1.Y - p2.Y);
                        int width = Math.Abs(p1.X - p2.X);
                        switch (whichShape) // decide what to add to the array based on the currently selected menu option
                        {
                            case "Rectangle":
                                thingsToPaint.Add(new paintRectangle(topLeftPoint, width, height, pen, brush, isFilled, isOutlined));
                                break;
                            case "Ellipse":
                                thingsToPaint.Add(new paintEllipse(topLeftPoint, width, height, pen, brush, isFilled, isOutlined));
                                break;
                            case "Text" :
                                thingsToPaint.Add(new paintText(topLeftPoint, width, height, textBrush, this.textBox1.Text, font));
                                break;
                        }
                    }
                    this.Invalidate();
                }
            }           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            drawAllThings(e.Graphics);
        }

        private void outlineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.isOutlined = !this.isOutlined;
        }

        private void fillCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.isFilled = !this.isFilled;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.thingsToPaint.Clear();
            this.Invalidate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (thingsToPaint.Count > 0)
            {
                this.thingsToPaint.RemoveAt(thingsToPaint.Count - 1);
                this.Invalidate();
            }
        }
    }
}
