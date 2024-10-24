using System;
using System.Windows.Forms;

namespace ZiTyLot.GUI.Screens.BillScr
{
    public partial class IssueDetailForm : Form
    {
        public IssueDetailForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
