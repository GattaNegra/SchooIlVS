﻿using Nakov.TurtleGraphics;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class TurtleDrawDemo : Form
    {
        public TurtleDrawDemo()
       {
            InitializeComponent();
        }

       private void buttonDraw_Click(object sender, EventArgs e)
        {
Turtle.Rotate(30);
Turtle.Forward(200);
Turtle.Rotate(120);
Turtle.Forward(200);
Turtle.Rotate(120);
Turtle.Forward(200);

        }

    private void buttonHide_Click(object sender, EventArgs e)
        {
            if (Turtle.ShowTurtle)
            {
                Turtle.ShowTurtle = false;
                this.buttonShowHideTurtle.Text = "Show Turtle";
            }
            else
            {
                Turtle.ShowTurtle = true;
                this.buttonShowHideTurtle.Text = "Hide Turtle";
            }

        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }
    }
}
