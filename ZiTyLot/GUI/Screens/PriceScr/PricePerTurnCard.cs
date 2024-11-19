using System;
using System.Windows.Forms;
using ZiTyLot.DTOS;

namespace ZiTyLot.GUI.Screens
{
    public partial class PricePerTurnCard : UserControl
    {

        public PricePerTurnCard(VisitorFee visitorFee)
        {
            InitializeComponent();
            lbDayFee.Text = visitorFee.Day_fee?.ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
            lbNightFee.Text = visitorFee.Night_fee?.ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
        }
        public event EventHandler EditButtonClicked;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Raise the event to notify the parent control
            EditButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }

}
