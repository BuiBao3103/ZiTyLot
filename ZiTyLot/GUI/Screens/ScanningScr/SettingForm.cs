using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZiTyLot.GUI.Screens.ScanningScr
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
            this.CenterToScreen();

        }

        private void btnCheckInFrontFolder_Click(object sender, EventArgs e)
        {
            if (fbdFolderLocation.ShowDialog() == DialogResult.OK)
            {
                // Use the selected folder path, for example:
                tbCheckInFrontRecord.Text = fbdFolderLocation.SelectedPath;
            }
        }

        private void btnCheckInBackFolder_Click(object sender, EventArgs e)
        {
            if (fbdFolderLocation.ShowDialog() == DialogResult.OK)
            {
                // Use the selected folder path, for example:
                tbCheckInBackRecord.Text = fbdFolderLocation.SelectedPath;
            }
        }

        private void btnCheckInPlateFolder_Click(object sender, EventArgs e)
        {
            if (fbdFolderLocation.ShowDialog() == DialogResult.OK)
            {
                // Use the selected folder path, for example:
                tbCheckInPlateRecord.Text = fbdFolderLocation.SelectedPath;
            }
        }

        private void btnCheckOutFrontFolder_Click(object sender, EventArgs e)
        {
            if (fbdFolderLocation.ShowDialog() == DialogResult.OK)
            {
                // Use the selected folder path, for example:
                tbCheckOutFrontRecord.Text = fbdFolderLocation.SelectedPath;
            }
        }

        private void btnCheckOutBackFolder_Click(object sender, EventArgs e)
        {
            if (fbdFolderLocation.ShowDialog() == DialogResult.OK)
            {
                // Use the selected folder path, for example:
                tbCheckOutBackRecord.Text = fbdFolderLocation.SelectedPath;
            }
        }

        private void btnCheckOutPlateFolder_Click(object sender, EventArgs e)
        {
            if (fbdFolderLocation.ShowDialog() == DialogResult.OK)
            {
                // Use the selected folder path, for example:
                tbCheckOutPlateRecord.Text = fbdFolderLocation.SelectedPath;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
