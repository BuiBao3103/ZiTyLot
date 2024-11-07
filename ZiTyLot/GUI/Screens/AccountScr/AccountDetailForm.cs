using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.Constants.Enum;
using ZiTyLot.ENTITY;

namespace ZiTyLot.GUI.Screens.AccountScr
{
    public partial class AccountDetailForm : Form
    {
        private readonly AccountBUS accountBUS = new AccountBUS();
        public readonly Account account;

        public event EventHandler AccountUpdateEvent;

        private readonly RoleBUS roleBUS = new RoleBUS();
        private readonly FunctionBUS functionBUS = new FunctionBUS();
        private readonly List<Function> functions;
        public AccountDetailForm(int accountId)
        {
            InitializeComponent();
            this.CenterToScreen();

            account = accountBUS.GetById(accountId);
            tbFullname.Text = account.Full_name;
            tbEmail.Text = account.Email;
            tbNationalId.Text = account.National_id;
            tbPhone.Text = account.Phone;
            tbUsername.Text = account.Username;
            if (account.Gender == AccountGender.FEMALE)
            {
                cbGender.SelectedIndex = 1;
            }
            if (account.Role_id == 2)
            {
                cbRole.SelectedIndex =2;
            }
            if (account.Role_id == 3)
            {
                cbRole.SelectedIndex = 1;
            }

            Role role = accountBUS.PopulateRole(account).Role;
            functions = new List<Function>(roleBUS.PopulateFunctions(role).Functions);
            listAccess.DataSource = functions;
            listAccess.DisplayMember = nameof(Function.Name);
        }

        private void AccountDetailForm_Load(object sender, System.EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
