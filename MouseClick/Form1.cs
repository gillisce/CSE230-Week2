using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseClick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    MessageBox.Show("The left button was clicked");
                    break;
                case MouseButtons.Right:
                    MessageBox.Show("The right button was clicked");
                    break;
                case MouseButtons.Middle:
                    MessageBox.Show("The middle button was clicked");
                    break;
            }
            MessageBox.Show("The mouse is at location " + e.X.ToString() + "," +
            e.Y.ToString());

        }
    }
}
