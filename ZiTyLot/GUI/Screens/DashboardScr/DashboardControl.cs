using Google.Protobuf.WellKnownTypes;
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
using ZiTyLot.BUS;
using ZiTyLot.DTOS;

namespace ZiTyLot.GUI.Screens.DashboardScr
{
    public partial class DashboardControl : UserControl
    {
        private readonly StatisticBUS _statisticBUS = new StatisticBUS();
        private List<RevenueStatistic> _revenueStatistics = new List<RevenueStatistic>();
        private List<SessionStatistic> _sessionStatistics = new List<SessionStatistic>();
        private SlotStatistic _slotStatistic = new SlotStatistic();
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
            _sessionStatistics = _statisticBUS.GetSessionStatistics(combine);
            LoadSessionCharts();
        }
        private void pickerSessionDuration_MonthConfirmed(object sender, string combine)
        {
            this.pnlBtnSessionDuration.Width = 320;
            this.btnSessionDuration.Text = combine;
            _sessionStatistics = _statisticBUS.GetSessionStatistics(combine);
            LoadSessionCharts();
        }
        private void pickerSessionDuration_DateConfirmed(object sender, string combine)
        {
            this.pnlBtnSessionDuration.Width = 250;
            this.btnSessionDuration.Text = combine;
            _sessionStatistics = _statisticBUS.GetSessionStatistics(combine);
            LoadSessionCharts();
        }
        private void pickerDuration_DateConfirmed(object sender, string combine)
        {
            this.pnlBtnDuration.Width = 250;
            this.btnDuration.Text = combine;
            _revenueStatistics = _statisticBUS.GetRevenueStatistics(combine);
            LoadRevenueCharts();
        }

        private void pickerDuration_MonthConfirmed(object sender, string combine)
        {
            this.pnlBtnDuration.Width = 200;
            this.btnDuration.Text = combine;
            _revenueStatistics = _statisticBUS.GetRevenueStatistics(combine);
            LoadRevenueCharts();
        }

        private void pickerDuration_YearConfirmed(object sender, string combine)
        {
            this.pnlBtnDuration.Width = 170;
            this.btnDuration.Text = combine;
            _revenueStatistics = _statisticBUS.GetRevenueStatistics(combine);
            LoadRevenueCharts();
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

        private void LoadRevenueCharts()
        {
            this.chartOverview.Series[0].Points.Clear();
            this.chartOverview.Series[1].Points.Clear();
            this.chartOverview.Series[2].Points.Clear();
            this.chartCorrelate.Series[0].Points.Clear();


            foreach (var (revenueStatistic, i) in _revenueStatistics.Select((value, index) => (value, index)))
            {
                this.chartOverview.Series[0].Points.AddXY(i + 1, revenueStatistic.totalAmount / 1000);
                this.chartOverview.Series[1].Points.AddXY(i + 1, revenueStatistic.ResidentAmount / 1000);
                this.chartOverview.Series[2].Points.AddXY(i + 1, revenueStatistic.VisitorAmount / 1000);
                this.chartOverview.Series[0].Points[i].Label = (revenueStatistic.totalAmount / 1000).ToString();
                this.chartOverview.Series[1].Points[i].Label = (revenueStatistic.ResidentAmount / 1000).ToString();
                this.chartOverview.Series[2].Points[i].Label = (revenueStatistic.VisitorAmount / 1000).ToString();

                //put Period on X axis
                this.chartOverview.Series[1].Points[i].AxisLabel = revenueStatistic.Period;

            }

          


            decimal totalResident = _revenueStatistics.Sum(x => x.ResidentAmount);
            decimal totalVisitor = _revenueStatistics.Sum(x => x.VisitorAmount);
            decimal total = totalResident + totalVisitor;
            if (total == 0)
            {
                return;
            }
            decimal percentResident = Math.Round(totalResident / total * 100, 2);
            decimal percentVisitor = Math.Round(totalVisitor / total * 100, 2);
            this.chartCorrelate.Series[0].Points.AddXY("Resident", percentResident);
            this.chartCorrelate.Series[0].Points.AddXY("Vistor", percentVisitor);
            this.chartCorrelate.Series[0].LabelForeColor = Color.White;
            this.chartCorrelate.Series[0].Font = new Font("Arial", 11F, FontStyle.Bold);
            this.chartCorrelate.Series[0].Points[0].Label = $"Resident - {percentResident}%";
            this.chartCorrelate.Series[0].Points[1].Label = $"Visitor - {percentVisitor}%";

            lbTotalRevenue.Text = $"{(total / 1000).ToString("N0")}K ₫";
            lbTotalResidentRevenue.Text = $"{(totalResident / 1000).ToString("N0")}K ₫";
            lbTotalVisitorRevenue.Text = $"{(totalVisitor / 1000).ToString("N0")}K ₫";
        }

        private void LoadSessionCharts()
        {
            this.chartSessionOverview.Series[0].Points.Clear();
            this.chartSessionOverview.Series[1].Points.Clear();
            this.chartSessionOverview.Series[2].Points.Clear();
            foreach (var (sessionStatistic, i) in _sessionStatistics.Select((value, index) => (value, index)))
            {
                this.chartSessionOverview.Series[0].Points.AddXY(i + 1, sessionStatistic.CountMotorbike);
                this.chartSessionOverview.Series[1].Points.AddXY(i + 1, sessionStatistic.CountCar);
                this.chartSessionOverview.Series[2].Points.AddXY(i + 1, sessionStatistic.CountBicycle);
                this.chartSessionOverview.Series[0].Points[i].Label = sessionStatistic.CountMotorbike.ToString();
                this.chartSessionOverview.Series[1].Points[i].Label = sessionStatistic.CountCar.ToString();
                this.chartSessionOverview.Series[2].Points[i].Label = sessionStatistic.CountBicycle.ToString();
                this.chartSessionOverview.Series[1].Points[i].AxisLabel = sessionStatistic.Period;
            }
        }

        public void LoadSlotStatistic()
        {
            _slotStatistic = _statisticBUS.GetSlotStatistics();
            int current2Wheels = _slotStatistic.CurrentMotorbike + _slotStatistic.CurrentBicycle;
            int current4Wheels = _slotStatistic.CurrentCar;
            int currentBicycle = _slotStatistic.CurrentBicycle;
            int total2Wheels = _slotStatistic.Total2Wheels;
            int total4Wheels = _slotStatistic.Total4Wheels;
            lbTotal2Wheels.Text = $"{current2Wheels}/{total2Wheels} slots ({currentBicycle} bicycles)";
            lbTotal4Wheels.Text = $"{current4Wheels}/{total4Wheels} slots";
        }
    }
}
