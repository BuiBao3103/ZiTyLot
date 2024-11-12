using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ZiTyLot.Constants.Enum;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.Screens;

namespace ZiTyLot.GUI
{
    public partial class CustomDateTimePicker : UserControl
    {
        public event EventHandler<string> DateTimeConfirmed;
        public CustomDateTimePicker()
        {
            InitializeComponent();
            listAmPmFrom.SelectedIndex = 0;
            listAmPmTo.SelectedIndex = 0;
            listHourFrom.SelectedIndex = 0;
            listHourTo.SelectedIndex = 0;
            listMinuteFrom.SelectedIndex = 0;
            listMinuteTo.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                // Convert selectedDateFrom to DateTime with full time details
                DateTime selectedDateFrom = calendarFrom.SelectionStart;
                int hourFrom = Convert.ToInt32(listHourFrom.SelectedItem);
                int minuteFrom = Convert.ToInt32(listMinuteFrom.SelectedItem);
                if (listAmPmFrom.SelectedItem.ToString().ToUpper() == "PM" && hourFrom < 12) hourFrom += 12;
                DateTime dateTimeFrom = new DateTime(selectedDateFrom.Year, selectedDateFrom.Month, selectedDateFrom.Day, hourFrom, minuteFrom, 0);

                // Convert selectedDateTo to DateTime with full time details
                DateTime selectedDateTo = calendarTo.SelectionStart;
                int hourTo = Convert.ToInt32(listHourTo.SelectedItem);
                int minuteTo = Convert.ToInt32(listMinuteTo.SelectedItem);
                if (listAmPmTo.SelectedItem.ToString().ToUpper() == "PM" && hourTo < 12) hourTo += 12;
                DateTime dateTimeTo = new DateTime(selectedDateTo.Year, selectedDateTo.Month, selectedDateTo.Day, hourTo, minuteTo, 0);

                // Validate the DateTime range
                if (dateTimeFrom >= dateTimeTo)
                {
                    MessageBox.Show("Invalid date time range. The begin time must be earlier than the end time.");
                    return;
                }

                // Combine date and time information for display or further processing
                string combine = $"{dateTimeFrom} - {dateTimeTo}";
                this.Visible = false;
                DateTimeConfirmed?.Invoke(this, combine);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid date time range.");
            }
        }


    }
}
