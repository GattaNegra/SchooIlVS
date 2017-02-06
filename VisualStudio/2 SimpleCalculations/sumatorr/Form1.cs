using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplusb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = decimal.Parse(this.n1.Text);
                var num2 = decimal.Parse(this.n2.Text);
                var sum = num1 + num2;
                result.Text = sum.ToString();
            }
            catch (Exception)
            {
                result.Text = "Please enter valid numbers!";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
