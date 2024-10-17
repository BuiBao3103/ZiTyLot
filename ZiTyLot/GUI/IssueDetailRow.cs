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
    public partial class IssueDetailRow : UserControl
    {
        public IssueDetailRow()
        {
            InitializeComponent();
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            this.Dispose();
            OnRowDeleted();  // Notify the parent control
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
