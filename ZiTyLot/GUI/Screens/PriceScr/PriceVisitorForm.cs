using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZiTyLot.GUI.Screens.PriceScr
{
    public partial class PriceVisitorForm : Form
    {
        public PriceVisitorForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void PriceDetailForm_Load(object sender, EventArgs e)
        {

        }
        // create event to notify parent control about new row insertion
        public event EventHandler PricePerTurnInsertion;
        public event EventHandler PricePerHourTurnInsertion;
        public event EventHandler PricePerPeriodInsertion;
        protected virtual void OnPricePerTurnInsertion()
        {
            if (PricePerTurnInsertion != null)
                PricePerTurnInsertion(this, EventArgs.Empty);
        }

        protected virtual void OnPricePerHourTurnInsertion()
        {
            if (PricePerHourTurnInsertion != null)
                PricePerHourTurnInsertion(this, EventArgs.Empty);
        }
        protected virtual void OnPricePerPeriodInsertion() {
            if (PricePerPeriodInsertion != null)
                PricePerPeriodInsertion(this, EventArgs.Empty);
        }

        private void btnConfirmPT_Click(object sender, EventArgs e)
        {
            this.Close();
            OnPricePerTurnInsertion();
        }

        private void btnConfirmPHT_Click(object sender, EventArgs e)
        {
            this.Close();
            OnPricePerHourTurnInsertion();
        }

        private void btnConfirmPeriod_Click(object sender, EventArgs e)
        {
            this.Close();
            OnPricePerPeriodInsertion();
        }

        private void btnCancelPT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelPHT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelPeriod_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
