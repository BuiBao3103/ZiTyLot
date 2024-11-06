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

namespace ZiTyLot.GUI.Screens.DashboardScr
{
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
            this.pickerDuration.DateConfirmed += pickerDuration_DateConfirmed;
            this.pickerDuration.MonthConfirmed += pickerDuration_MonthConfirmed;
            this.pickerDuration.YearConfirmed += pickerDuration_YearConfirmed;
            this.pickerSessionDuration.DateConfirmed += pickerSessionDuration_DateConfirmed;
            this.pickerSessionDuration.MonthConfirmed += pickerSessionDuration_MonthConfirmed;
            this.pickerSessionDuration.YearConfirmed += pickerSessionDuration_YearConfirmed;

        }

        private void pickerSessionDuration_YearConfirmed(object sender, string combine)
        {
            this.pnlBtnSessionDuration.Width = 170;
            this.btnSessionDuration.Text = combine;
        }
        private void pickerSessionDuration_MonthConfirmed(object sender, string combine)
        {
            this.pnlBtnSessionDuration.Width = 320;
            this.btnSessionDuration.Text = combine;
        }
        private void pickerSessionDuration_DateConfirmed(object sender, string combine)
        {
            this.pnlBtnSessionDuration.Width = 250;
            this.btnSessionDuration.Text = combine;
        }
        private void pickerDuration_DateConfirmed (object sender, string combine)
        {
            this.pnlBtnDuration.Width = 250;
            this.btnDuration.Text = combine;
        }

        private void pickerDuration_MonthConfirmed(object sender, string combine)
        {
            this.pnlBtnDuration.Width = 320;
            this.btnDuration.Text = combine;
        }

        private void pickerDuration_YearConfirmed(object sender, string combine)
        {
            this.pnlBtnDuration.Width = 170;
            this.btnDuration.Text = combine;
        }
        private void btnDuration_Click(object sender, EventArgs e)
        {
            this.pickerDuration.BringToFront();
            this.pickerDuration.Visible = !this.pickerDuration.Visible;
            this.pickerDuration.SetToTheCenterOfParent();
        }

        private void DashboardControl_Resize(object sender, EventArgs e)
        {
            this.pickerDuration.Visible = false;
            this.pickerSessionDuration.Visible = false;
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int columnCount = 10;
            for (int i = 0; i < columnCount; i++)
            {
                this.chartOverview.Series[1].Points.AddXY(i + 1, random.Next(1, 1000));
                this.chartOverview.Series[2].Points.AddXY(i + 1, random.Next(1, 1000));
                int sum = (int)(this.chartOverview.Series[1].Points[i].YValues[0] + this.chartOverview.Series[2].Points[i].YValues[0]);
                this.chartOverview.Series[0].Points.AddXY(i + 1, sum);
                //put lable on top of the column
                this.chartOverview.Series[0].Points[i].Label = sum.ToString();
                this.chartOverview.Series[1].Points[i].Label = this.chartOverview.Series[1].Points[i].YValues[0].ToString();
                this.chartOverview.Series[2].Points[i].Label = this.chartOverview.Series[2].Points[i].YValues[0].ToString();
            }

            for (int i = 0; i < columnCount; i++)
            {
                this.chartSessionOverview.Series[1].Points.AddXY(i + 1, random.Next(1, 100));
                this.chartSessionOverview.Series[2].Points.AddXY(i + 1, random.Next(1, 100));

                this.chartSessionOverview.Series[0].Points.AddXY(i + 1, random.Next(1, 100));
                //put lable on top of the column
                this.chartSessionOverview.Series[0].Points[i].Label = this.chartSessionOverview.Series[0].Points[i].YValues[0].ToString();
                this.chartSessionOverview.Series[1].Points[i].Label = this.chartSessionOverview.Series[1].Points[i].YValues[0].ToString();
                this.chartSessionOverview.Series[2].Points[i].Label = this.chartSessionOverview.Series[2].Points[i].YValues[0].ToString();
            }

            // generate data for pie chartCorrelate with Resident 30% and Vistor 70%
            this.chartCorrelate.Series[0].Points.AddXY("Resident", 30);
            this.chartCorrelate.Series[0].Points.AddXY("Vistor", 70);
            this.chartCorrelate.Series[0].LabelForeColor = Color.White;
            this.chartCorrelate.Series[0].Font = new Font("Arial", 11F ,FontStyle.Bold);
            this.chartCorrelate.Series[0].Points[0].Label = "Resident - 30%";
            this.chartCorrelate.Series[0].Points[1].Label = "Visitor - 70%";
        }

        private void btnSessionDuration_Click(object sender, EventArgs e)
        {
            this.pickerSessionDuration.BringToFront();
            this.pickerSessionDuration.Visible = !this.pickerSessionDuration.Visible;
            this.pickerSessionDuration.SetToTheCenterOfParent();
        }

        private void pnlTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pickerSessionDuration.Visible = false;
            this.pickerDuration.Visible = false;
        }
    }
}
