using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZiTyLot.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            //Rectangle r = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
            //System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            //int d = 50;
            //gp.AddArc(r.X, r.Y, d, d, 180, 90);
            //gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            //gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            //gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            //pictureBox2.Region = new Region(gp);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                inputPassword.PasswordChar = '\0';  // Show password
            }
            else
            {
                inputPassword.PasswordChar = '*';   // Mask password
            }
        }

    }
}
