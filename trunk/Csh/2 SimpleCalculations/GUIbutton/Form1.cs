using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIbutton
{
    public partial class catchthebuttonmain : Form
    {
        public catchthebuttonmain()
        {
            InitializeComponent();
        }

      
        private void mouse_Enter(object sender, EventArgs e)
        {
            Random rand = new Random();
            var maxWidth = this.ClientSize.Width - button.ClientSize.Width;
            var maxHeight = this.ClientSize.Height - button.ClientSize.Height;
            this.button.Location = new Point(
            rand.Next(maxWidth), rand.Next(maxHeight));
        }

        private void mouseclick(object sender, MouseEventArgs e)
        {
          
                MessageBox.Show("You Win!","Congrats!");
            
        }
    }

}
