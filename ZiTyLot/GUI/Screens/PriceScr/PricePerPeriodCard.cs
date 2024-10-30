using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiTyLot.ENTITY;

namespace ZiTyLot.GUI.Screens.PriceScr
{
    public partial class PricePerPeriodCard : UserControl
    {
        public PricePerPeriodCard(VisitorFee visitorFee)
        {
            InitializeComponent();
            lbFeeFirstPeriod.Text = visitorFee.First_n_hours_fee?.ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
            lbFeeNextPeriod.Text = visitorFee.Additional_m_hours_fee?.ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
            lbHourFirstPeriod.Text = lbHourFirstPeriod.Text.Replace("{hour}", visitorFee.N_hours.ToString());
            lbHourNextPeriod.Text = lbHourNextPeriod.Text.Replace("{hour}", visitorFee.M_hours.ToString());
        }
        public event EventHandler EditButtonClicked;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
