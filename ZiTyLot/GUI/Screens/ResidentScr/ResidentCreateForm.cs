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
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Utils;

namespace ZiTyLot.GUI.Screens.ResidentScr
{
    public partial class ResidentCreateForm : Form
    {
        private readonly ResidentBUS residentBUS = new ResidentBUS();
        public event EventHandler ResidentInsertionEvent;
        public ResidentCreateForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void ResidentCreateForm_Load(object sender, EventArgs e)
        {

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
                string fullName = tbFullname.Text;
                string apartmentId = tbApartmentID.Text;
                string email = tbEmail.Text;    
                string phone = tbPhone.Text;
                Resident resident = new Resident
                {
                    Full_name = fullName,
                    Phone = phone,
                    Email = email,
                    Apartment_id = apartmentId,
                    Created_at = DateTime.Now
                };
                residentBUS.Add(resident);
                MessageHelper.ShowSuccess("Resident added successfully!");
                ResidentInsertionEvent?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            catch (ValidationException ex)
            {
                MessageHelper.ShowWarning(ex.Message);
            }
            catch (BusinessException ex)
            {
                MessageHelper.ShowWarning(ex.Message);
            }
            catch (Exception)
            {
                MessageHelper.ShowWarning("An unexpected error occurred. Please try again later.");
            }
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

       
        private void tbFullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbApartmentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(tbFullname.Text))
            {
                MessageHelper.ShowWarning("Please enter fullname");
                return false;
            }

            if (string.IsNullOrEmpty(tbApartmentID.Text))
            {
                MessageHelper.ShowWarning("Please enter apartment");
                return false;
            }

            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageHelper.ShowWarning("Please enter email");
                return false;
            }

            if (string.IsNullOrEmpty(tbPhone.Text))
            {
                MessageHelper.ShowWarning("Please enter phone");
                return false;
            }

            if (!InputValidator.ValidateEmail(tbEmail.Text))
            {
                MessageHelper.ShowWarning("Email invalid");
                return false;
            }

            if (!InputValidator.ValidatePhoneNumber(tbPhone.Text))
            {
                MessageHelper.ShowWarning("Phone invalid");
                return false;
            }

            return true;
        }

    }
}
