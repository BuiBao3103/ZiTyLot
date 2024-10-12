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
            AdjustPanelPosition();
        }
        private void AdjustPanelPosition()
        {
            var screenBounds = Screen.FromControl(this).WorkingArea;

            if (screenBounds.Width <= 1600)
            {
                // For smaller screens, position uiPanel1 accordingly
                uiPanel1.Location = new System.Drawing.Point(this.panel2.Width / 4, 0);
            }
            else
            {
                uiPanel1.Location = new System.Drawing.Point(this.panel2.Width / 2 - uiPanel1.Width / 2, this.panel2.Height / 2 - uiPanel1.Height / 2);
            }
        }
        private void ScanningScreen_Resize(object sender, EventArgs e)
        {
            AdjustPanelPosition();
        }

        private void ScanningScreen_Load(object sender, EventArgs e)
        {
            //TopPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, TopPnl.Width, TopPnl.Height, 10, 10
        }

    }
}