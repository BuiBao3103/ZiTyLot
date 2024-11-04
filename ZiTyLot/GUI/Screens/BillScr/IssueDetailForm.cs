using System;
using System.Windows.Forms;
using ZiTyLot.ENTITY;

namespace ZiTyLot.GUI.Screens.BillScr
{
    public partial class IssueDetailForm : Form
    {
        public event EventHandler IssueInsertionEvent;
        public IssueDetailForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            IssueInsertionEvent?.Invoke(this, EventArgs.Empty);
            this.Dispose();
        }
    }
}
