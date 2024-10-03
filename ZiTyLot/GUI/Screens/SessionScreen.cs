using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiTyLot.GUI.component_extensions;

namespace ZiTyLot.GUI
{
    public partial class SessionScreen : UserControl
    {
        public SessionScreen()
        {
            InitializeComponent();
            main.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, main.Width, main.Height , 5, 5));
            //searchPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, searchPnl.Width + 1, searchPnl.Height + 1, 5, 5));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sessionTopPnl_Resize(object sender, EventArgs e)
        {
            main.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, main.Width,main.Height + 1, 5, 5));
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //searchPnl.BorderStyle = Buffer
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
