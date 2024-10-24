using System;
using System.Windows.Forms;

namespace ZiTyLot.GUI.Screens.BillScr
{
    public partial class IssueDetailRow : UserControl
    {
        public IssueDetailRow()
        {
            InitializeComponent();
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            this.Dispose();
            OnRowDeleted();  
        }

        // Custom event to notify parent control about row deletion
        public event EventHandler RowDeleted;

        protected virtual void OnRowDeleted()
        {
            if (RowDeleted != null)
                RowDeleted(this, EventArgs.Empty);
        }
    }

}
