using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiTyLot.GUI.component_extensions;

namespace ZiTyLot.GUI.Screens
{
    public partial class ScanningScreen : UserControl
    {
        public ScanningScreen()
        {
            InitializeComponent();
            uiPanel1.Location = new System.Drawing.Point(this.panel2.Width / 2 - 150, this.panel2.Height / 2);
        }

        private void ScanningScreen_Load(object sender, EventArgs e)
        {
            //TopPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, TopPnl.Width, TopPnl.Height, 10, 10
        }

    }
}