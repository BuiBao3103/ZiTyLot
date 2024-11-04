using System;
using System.Windows.Forms;

namespace ZiTyLot.GUI.Screens.BillScr
{
    public partial class IssueDetailRow : UserControl
    {
        public IssueDetailRow()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
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
