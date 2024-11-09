using OfficeOpenXml.Drawing.Style.Fill;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using iTextSharp.text.pdf.qrcode;
using System.Windows.Media.Media3D;

namespace ZiTyLot.GUI
{
    public partial class CustomContextMenuStrip : UserControl
    { 
        private int _flag;
        private string _page;
        const int MODEl_INFO = 0;
        const int MODEL_FUNCTION = 1;
        public CustomContextMenuStrip()
        {
            InitializeComponent();
        }
        public void SetMode(int mode)
        {
            _flag = mode;
        }

        public void SetControl(string page)
        {
            _page = page;
        }

        private void CustomContextMenuStrip_Load(object sender, EventArgs e)
        {
            if(_flag == MODEl_INFO)
            {
                pnlDownload.Visible = false;
                pnlExport.Visible = false;
                pnlImport.Visible = false;
            }
            else
            {
                pnlProfile.Visible = false;
                pnlLogout.Visible = false;
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout");
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Download");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Export");
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Import");
        }
    }
}
