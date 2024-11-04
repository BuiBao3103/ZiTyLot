using System;
using System.Windows.Forms;
using ZiTyLot.ENTITY;

namespace ZiTyLot.GUI.Screens.BillScr
{
    public partial class IssueDetailRow : UserControl
    {
        public Issue _issue;
        public IssueDetailRow(Issue newIssue)
        {
            _issue = newIssue;
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
