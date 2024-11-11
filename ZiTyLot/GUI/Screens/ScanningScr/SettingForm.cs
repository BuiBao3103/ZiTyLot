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
using AForge.Video;
using AForge.Video.DirectShow;
using System.Windows.Controls;
namespace ZiTyLot.GUI.Screens.ScanningScr
{
    public partial class SettingForm : Form
    {
        private FilterInfoCollection cameras;
        private List<string> monikerStrings = new List<string>();

        public SettingForm(string frontCameraId, string backCameraId)
        {
            InitializeComponent();
            this.CenterToScreen();
            GetVideoDevices();

            if (!string.IsNullOrEmpty(frontCameraId))
            {
                cbCameraFront.SelectedIndex = monikerStrings.IndexOf(frontCameraId);
                btnConnectCameraFront.Enabled = false;
                btnDisconnectCameraFront.Enabled = true;
                cbCameraFront.Enabled = false;
            }
            if (!string.IsNullOrEmpty(backCameraId))
            {
                cbCameraBack.SelectedIndex = monikerStrings.IndexOf(backCameraId);
                btnConnectCameraBack.Enabled = false;
                btnDisconnectCameraBack.Enabled = true;
                cbCameraBack.Enabled = false;
            }

        }

        public event EventHandler<string> ConnectCameraFront;
        public event EventHandler<string> ConnectCameraBack;
        public event EventHandler DisconnectCameraFront;
        public event EventHandler DisconnectCameraBack;
        private void GetVideoDevices()
        {
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            cbCameraFront.Items.Clear();
            cbCameraBack.Items.Clear();
            foreach (FilterInfo device in cameras)
            {
                cbCameraFront.Items.Add(device.Name);
                cbCameraBack.Items.Add(device.Name);
                monikerStrings.Add(device.MonikerString);
            }
            if (cbCameraFront.Items.Count > 0)
            {
                cbCameraFront.SelectedIndex = 0;
                cbCameraBack.SelectedIndex = 0;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConnectCameraFront_Click(object sender, EventArgs e)
        {
            ConnectCameraFront?.Invoke(this, cameras[cbCameraFront.SelectedIndex].MonikerString);
            btnConnectCameraFront.Enabled = false;
            btnDisconnectCameraFront.Enabled = true;
            cbCameraFront.Enabled = false;
        }

        private void btnDisconnectCameraFront_Click(object sender, EventArgs e)
        {
            DisconnectCameraFront?.Invoke(this, e);
            btnConnectCameraFront.Enabled = true;
            btnDisconnectCameraFront.Enabled = false;
            cbCameraFront.Enabled = true;
        }

        private void btnConnectCameraBack_Click(object sender, EventArgs e)
        {
            ConnectCameraBack?.Invoke(this, cameras[cbCameraBack.SelectedIndex].MonikerString);
            btnConnectCameraBack.Enabled = false;
            btnDisconnectCameraBack.Enabled = true;
            cbCameraBack.Enabled = false;
        }

        private void btnDisconnectCameraBack_Click(object sender, EventArgs e)
        {
            DisconnectCameraBack?.Invoke(this, e);
            btnConnectCameraBack.Enabled = true;
            btnDisconnectCameraBack.Enabled = false;
            cbCameraBack.Enabled = true;
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

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
