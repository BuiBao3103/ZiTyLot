using System;
using System.Windows.Forms;

namespace ZiTyLot.GUI.Screens.BillScr
{
    public partial class BillDetailControl : UserControl
    {
        public BillDetailControl()
        {
            InitializeComponent();
            pnlBillDetail.RowStyles[1] = new RowStyle(SizeType.Absolute, 0);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            IssueDetailForm issueDetailForm = new IssueDetailForm();
            issueDetailForm.Show();
            IssueDetailRow newRow = new IssueDetailRow();
            newRow.Dock = DockStyle.Top;
            newRow.RowDeleted += OnRowDeleted; // Subscribe to the RowDeleted event
            pnlIssueTable.Controls.Add(newRow);

            AdjustPanelHeight(120); // Increase height when adding a row
        }

        private void OnRowDeleted(object sender, EventArgs e)
        {
            AdjustPanelHeight(-120); // Decrease height when a row is deleted
        }

        // Adjust the height of the panel dynamically
        private void AdjustPanelHeight(int change)
        {
            if (pnlBillDetail.RowStyles[1].Height + change >= 0)
            {
                pnlBillDetail.RowStyles[1].Height += change;
            }
        }

        private void pnlIssueTable_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in pnlIssueTable.Controls)
            {
                control.Width = pnlIssueTable.Width - 40;
            }
        }
    }

}
