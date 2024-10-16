using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZiTyLot.GUI.Screens.Bill
{
    public partial class BillDetailControl : UserControl
    {
        public BillDetailControl()
        {
            InitializeComponent();
            pnlBillDetail.RowStyles[1] = new RowStyle(SizeType.Absolute, 0);
        }

        private void uiPanel3_Click(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            IssueDetailRow newRow = new IssueDetailRow();
            newRow.Dock = DockStyle.Top;
            pnlIssueTable.Controls.Add(newRow);
            if (pnlBillDetail.RowStyles[1].Height < 240)
                pnlBillDetail.RowStyles[1].Height += 120;

        }

        private void pnlIssueTable_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in pnlIssueTable.Controls)
            {
                control.Width = pnlIssueTable.Width - 40;
                Console.WriteLine(control.Name + " " + control.Width);// Adjust width based on panel size
            }
        }
    }
}
