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

            DateTime selectedDateFrom = calendarFrom.SelectionStart;
            string hourFrom = listHourFrom.SelectedItem.ToString().PadLeft(2, '0');
            string minuteFrom = listMinuteFrom.SelectedItem.ToString().PadLeft(2, '0');
            string ampmFrom = listAmPmFrom.SelectedItem.ToString().ToUpper();

            DateTime selectedDateTo = calendarTo.SelectionStart;
            string hourTo = listHourTo.SelectedItem.ToString().PadLeft(2, '0');
            string minuteTo = listMinuteTo.SelectedItem.ToString().PadLeft(2, '0');
            string ampmTo = listAmPmTo.SelectedItem.ToString().ToUpper();

            string from = selectedDateFrom.ToString("yyyy-MM-dd") + " " + hourFrom + ":" + minuteFrom + " " + ampmFrom;
            string to = selectedDateTo.ToString("yyyy-MM-dd") + " " + hourTo + ":" + minuteTo + " " + ampmTo;
            string combine = from + " - " + to;
            
            this.Visible = false;

            DateTimeConfirmed?.Invoke(this, combine);
            
            MessageBox.Show(combine);

        }
    }
}
