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
    public partial class BScreen : UserControl
    {
        public BScreen()
        {
            InitializeComponent();
        }

        private void InvoiceScreen_Load(object sender, EventArgs e)
        {
            invoiceTopPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, invoiceTopPnl.Width, invoiceTopPnl.Height, 5, 5));
        }

        private void invoiceTopPnl_Resize(object sender, EventArgs e)
        {
            invoiceTopPnl.Region = Region.FromHrgn(RoundedBorder.CreateRoundRectRgn(0, 0, invoiceTopPnl.Width, invoiceTopPnl.Height, 5, 5));
        }
    }
}
