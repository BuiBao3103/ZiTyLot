using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.Constants.Enum;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Utils;

namespace ZiTyLot.GUI.Screens.CardScr
{
    public partial class CardCreateForm : Form
    {
        private readonly CardBUS cardBUS = new CardBUS();

        public event EventHandler CardInsertionEvent;

        public CardCreateForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            try
            {
                Card card = new Card
                {
                    Rfid = tbRFID.Text.Trim(),
                    Status = CardStatus.EMPTY,
                    Type = cbCardType.SelectedIndex == 0 ? CardType.RESIDENT : CardType.VISITOR
                };
                cardBUS.Add(card);
                MessageHelper.ShowSuccess("Card added successfully!");
                CardInsertionEvent?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            catch (ValidationInputException ex)
            {
                MessageHelper.ShowWarning(ex.Message);
            }
            catch (BusinessException ex)
            {
                MessageHelper.ShowWarning(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageHelper.ShowError("Some errors occurred. Please try again later.");
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(tbRFID.Text))
            {
                MessageHelper.ShowWarning("Please enter RFID");
                tbRFID.Focus();
                return false;
            }

            if (!InputValidator.ValidateRfid(tbRFID.Text))
            {
                MessageHelper.ShowWarning("Please enter a valid RFID");
                tbRFID.Focus();
                return false;
            }

            return true;
        }

        private void cbCardType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbCardType.SelectedIndex;
            switch (index)
            {
                case 0: // Resident
                    pnlMain.RowStyles[2] = new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent ,0);
                    this.MinimumSize = new Size(0, 280);
                    this.Height = 280;
                    break;
                case 1: // Visitor
                    pnlMain.RowStyles[2] = new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100);
                    this.Height = 370;
                    this.MinimumSize = new Size(0, 370);
                    break;
            }
        }
        
    }
}
