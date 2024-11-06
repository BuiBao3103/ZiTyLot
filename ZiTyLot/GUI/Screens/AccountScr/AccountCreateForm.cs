using Google.Protobuf.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ZiTyLot.BUS;
using ZiTyLot.Constants.Enum;
using ZiTyLot.DAO;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZiTyLot.GUI.Screens.AccountScr
{
    public partial class AccountCreateForm : Form
    {
        private readonly AccountBUS accountBUS = new AccountBUS();
        private readonly RoleBUS roleBUS = new RoleBUS();

        public event EventHandler AccountCreated;

        public AccountCreateForm()
        {
            InitializeComponent();
            this.CenterToScreen();

            List<Role> roles = roleBUS.GetAll();
            cbRole.DataSource = roles;
            cbRole.DisplayMember = nameof(Role.Name);
            cbRole.ValueMember = nameof(Role.Id);
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
                Account account = new Account
                {
                    Full_name = tbFullname.Text.Trim(),
                    National_id = tbNationalId.Text.Trim(),
                    Email = tbEmail.Text.Trim(),
                    Phone = tbPhone.Text.Trim(),
                    Username = tbUsername.Text.Trim(),
                    Gender = cbGender.SelectedIndex == 0 ? AccountGender.MALE : AccountGender.FEMALE,
                    Role_id = (int)cbRole.SelectedValue,
                    Password = "1"
                };
                accountBUS.Add(account);
                MessageHelper.ShowSuccess("Account added successfully!");
                AccountCreated?.Invoke(this, EventArgs.Empty);
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
                MessageHelper.ShowError("An unexpected error occurred. Please try again later.");
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(tbFullname.Text))
            {
                MessageHelper.ShowWarning("Please enter full name");
                tbFullname.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbNationalId.Text))
            {
                MessageHelper.ShowWarning("Please enter national id");
                tbNationalId.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageHelper.ShowWarning("Please enter email");
                tbEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                MessageHelper.ShowWarning("Please enter phone number");
                tbPhone.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                MessageHelper.ShowWarning("Please enter username");
                tbUsername.Focus();
                return false;
            }

            if (!InputValidator.ValidateEmail(tbEmail.Text))
            {
                MessageHelper.ShowWarning("Invalid email");
                tbEmail.Focus();
                return false;
            }

            if (!InputValidator.ValidatePhoneNumber(tbPhone.Text))
            {
                MessageHelper.ShowWarning("Invalid phone number");
                tbPhone.Focus();
                return false;
            }

            return true;
        }

        private void tbNationalId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers and control characters in textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers and control characters in textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRole.SelectedItem != null)
            {
                Role role = roleBUS.PopulateFunctions((Role)cbRole.SelectedItem);
                listAccess.DataSource = null;
                listAccess.DataSource = role.Functions;
                listAccess.DisplayMember = nameof(Function.Name);
            }
        }
    }
}
