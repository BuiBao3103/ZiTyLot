using System;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.ENTITY;

namespace ZiTyLot.GUI.Screens.BillScr
{
    public partial class IssueDetailRow : UserControl
    {
        public Issue _issue;
        private readonly VehicleTypeBUS _vehicleTypeBUS;
        public IssueDetailRow(Issue newIssue)
        {
            _vehicleTypeBUS = new VehicleTypeBUS();
            _issue = newIssue;
            InitializeComponent();
            this.Dock = DockStyle.Top;

            lbIssuePlate.Text = _issue.License_plate;
            lbIssueVehicleType.Text = _vehicleTypeBUS.GetById(_issue.Vehicle_type_id).Name;
            lbIssueParkingLot.Text = _issue.Parking_lot_id;
            if (_issue.Slot_id != null)
                lbIssueParkingLot.Text += $"({_issue.Slot_id})";
            lbIssueDate.Text = _issue.Start_date.ToString("dd/MM/yyyy") + " - " + _issue.End_date.ToString("dd/MM/yyyy");
            lbIssueTotal.Text = _issue.Fee.ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            this.Dispose();
            OnRowDeleted();  
        }

        public event EventHandler RowDeleted;

        protected virtual void OnRowDeleted()
        {
            if (RowDeleted != null)
                RowDeleted(this, EventArgs.Empty);
        }
    }

}
