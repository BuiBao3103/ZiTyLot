using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiTyLot.GUI.Screens.PriceScr;

namespace ZiTyLot.GUI.Screens
{
    public partial class PricePerTurnCard : UserControl
    {

        public PricePerTurnCard()
        {
            InitializeComponent();
        }
        public event EventHandler EditButtonClicked;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Raise the event to notify the parent control
            EditButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }

}
