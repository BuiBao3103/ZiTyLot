using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZiTyLot.GUI.Screens.DashboardScr
{
    public partial class CustomDurationPicker : UserControl
    {
        public event EventHandler<string> DateConfirmed;
        public event EventHandler<string> MonthConfirmed;
        public event EventHandler<string> YearConfirmed;

        public CustomDurationPicker()
        {
            InitializeComponent();
        }

        private void btnDateCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnMonthCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnYearCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnDateConfirm_Click(object sender, EventArgs e)
        {
            DateTime selectedDateFrom = calendarFrom.SelectionStart;
            DateTime selectedDateTo = calendarTo.SelectionStart;

            string from = selectedDateFrom.ToString("yyyy-MM-dd");
            string to = selectedDateTo.ToString("yyyy-MM-dd");
            string combine = from + " to " + to;

            this.Visible = false;

            DateConfirmed?.Invoke(this, combine);
        }

        private void btnMonthConfirm_Click(object sender, EventArgs e)
        {
            string monthFrom;
            string yearFrom = listYearFrom.SelectedItem?.ToString();
            string monthTo;
            string yearTo = listYearTo.SelectedItem?.ToString();

            if (yearFrom == null || yearTo == null)
            {
                MessageBox.Show("Please select a year.");
                return;
            }

            if (!int.TryParse(listMonthFrom.SelectedItem?.ToString(), out int monthFromValue) ||
                !int.TryParse(listMonthTo.SelectedItem?.ToString(), out int monthToValue))
            {
                MessageBox.Show("Invalid month selection.");
                return;
            }

            if (monthFromValue < 1 || monthFromValue > 12 || monthToValue < 1 || monthToValue > 12)
            {
                MessageBox.Show("Invalid month selection.");
                return;
            }

            string from = yearFrom + "-" + monthFromValue;
            string to = yearTo + "-" + monthToValue;
            string combine = from + " to " + to;

            this.Visible = false;

            MonthConfirmed?.Invoke(this, combine);
        }

        private void btnYearConfirm_Click(object sender, EventArgs e)
        {
            string yearFrom = listYearYearFrom.SelectedItem?.ToString();
            string yearTo = listYearYearTo.SelectedItem?.ToString();
            string combine = yearFrom + " to " + yearTo;
            this.Visible = false;
            YearConfirmed?.Invoke(this, combine);
        }
    }
}
