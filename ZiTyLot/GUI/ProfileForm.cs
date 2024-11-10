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

namespace ZiTyLot.GUI
{
    public partial class ProfileForm : Form
    {
        const int ResidentId = 1;// TODO: get from session
        private Resident _resident;
        private readonly ResidentBUS _residentBUS = new ResidentBUS();

        public ProfileForm()
        {
            InitializeComponent();
            this.CenterToScreen();

            _resident = _residentBUS.GetById(ResidentId);

            tbFullname.Text = _resident.Full_name;
            tbEmail.Text = _resident.Email;
            tbPhone.Text = _resident.Phone;
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
