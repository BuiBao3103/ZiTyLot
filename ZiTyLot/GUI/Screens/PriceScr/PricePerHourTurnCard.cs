using System;
using System.Windows.Forms;
using ZiTyLot.ENTITY;

namespace ZiTyLot.GUI.Screens.PriceScr
{
    public partial class PricePerHourTurnCard : UserControl
    {
        public PricePerHourTurnCard(VisitorFee visitorFee)
        {
            InitializeComponent();
            lbDayFee.Text = visitorFee.Day_fee?.ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
            lbNightFee.Text = visitorFee.Night_fee?.ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
            lbDayHour.Text = lbDayHour.Text.Replace("{hour}", visitorFee.Hours_per_turn.ToString());
            lbNightHour.Text = lbNightHour.Text.Replace("{hour}", visitorFee.Hours_per_turn.ToString());
        }
        public event EventHandler EditButtonClicked;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
