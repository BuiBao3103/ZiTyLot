using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZiTyLot.GUI.Screens.PriceScr
{
    public partial class PricePerHourTurnCard : UserControl
    {
        public PricePerHourTurnCard()
        {
            InitializeComponent();
        }
        public event EventHandler EditButtonClicked;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
