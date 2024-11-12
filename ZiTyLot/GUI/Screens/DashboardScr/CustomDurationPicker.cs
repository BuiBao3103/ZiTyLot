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

            if (selectedDateFrom > selectedDateTo)
            {
                MessageBox.Show("The start date must be earlier than the end date.");
                return;
            }

            string from = selectedDateFrom.ToString("yyyy-MM-dd");
            string to = selectedDateTo.ToString("yyyy-MM-dd");
            string combine = from + " to " + to;

            this.Visible = false;
            DateConfirmed?.Invoke(this, combine);
        }


        private void btnMonthConfirm_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(listYearFrom.SelectedItem?.ToString(), out int yearFrom) ||
                !int.TryParse(listYearTo.SelectedItem?.ToString(), out int yearTo) ||
                !int.TryParse(listMonthFrom.SelectedItem?.ToString(), out int monthFrom) ||
                !int.TryParse(listMonthTo.SelectedItem?.ToString(), out int monthTo) ||
                monthFrom < 1 || monthFrom > 12 || monthTo < 1 || monthTo > 12)
            {
                MessageBox.Show("Please select valid month and year.");
                return;
            }

            DateTime fromDate = new DateTime(yearFrom, monthFrom, 1);
            DateTime toDate = new DateTime(yearTo, monthTo, 1);

            if (fromDate > toDate)
            {
                MessageBox.Show("The start date must be earlier than the end date.");
                return;
            }

            string combine = $"{fromDate:yyyy-MM} to {toDate:yyyy-MM}";
            this.Visible = false;
            MonthConfirmed?.Invoke(this, combine);
        }


        private void btnYearConfirm_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(listYearYearFrom.SelectedItem?.ToString(), out int yearFrom) ||
                !int.TryParse(listYearYearTo.SelectedItem?.ToString(), out int yearTo) ||
                yearFrom > yearTo)
            {
                MessageBox.Show("Please select a valid year range.");
                return;
            }

            string combine = $"{yearFrom} to {yearTo}";
            this.Visible = false;
            YearConfirmed?.Invoke(this, combine);
        }

    }
}
