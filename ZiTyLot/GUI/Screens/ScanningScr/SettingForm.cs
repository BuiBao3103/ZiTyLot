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
                cbFront.SelectedIndex = monikerStrings.IndexOf(frontCameraId);
                btnConnectCameraFront.Enabled = false;
                btnDisconnectCameraFront.Enabled = true;
                cbFront.Enabled = false;
            }
            if (!string.IsNullOrEmpty(backCameraId))
            {
                cbBack.SelectedIndex = monikerStrings.IndexOf(backCameraId);
                btnConnectCameraBack.Enabled = false;
                btnDisconnectCameraBack.Enabled = true;
                cbBack.Enabled = false;
            }

        }

        public event EventHandler<string> ConnectCameraFront;
        public event EventHandler<string> ConnectCameraBack;
        public event EventHandler DisconnectCameraFront;
        public event EventHandler DisconnectCameraBack;
        private void GetVideoDevices()
        {
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            cbFront.Items.Clear();
            cbBack.Items.Clear();
            foreach (FilterInfo device in cameras)
            {
                cbFront.Items.Add(device.Name);
                cbBack.Items.Add(device.Name);
                monikerStrings.Add(device.MonikerString);
            }
            if (cbFront.Items.Count > 0)
            {
                cbFront.SelectedIndex = 0;
                cbBack.SelectedIndex = 0;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConnectCameraFront_Click(object sender, EventArgs e)
        {
            ConnectCameraFront?.Invoke(this, cameras[cbFront.SelectedIndex].MonikerString);
            btnConnectCameraFront.Enabled = false;
            btnDisconnectCameraFront.Enabled = true;
            cbFront.Enabled = false;
        }

        private void btnDisconnectCameraFront_Click(object sender, EventArgs e)
        {
            DisconnectCameraFront?.Invoke(this, e);
            btnConnectCameraFront.Enabled = true;
            btnDisconnectCameraFront.Enabled = false;
            cbFront.Enabled = true;
        }

        private void btnConnectCameraBack_Click(object sender, EventArgs e)
        {
            ConnectCameraBack?.Invoke(this, cameras[cbBack.SelectedIndex].MonikerString);
            btnConnectCameraBack.Enabled = false;
            btnDisconnectCameraBack.Enabled = true;
            cbBack.Enabled = false;
        }

        private void btnDisconnectCameraBack_Click(object sender, EventArgs e)
        {
            DisconnectCameraBack?.Invoke(this, e);
            btnConnectCameraBack.Enabled = true;
            btnDisconnectCameraBack.Enabled = false;
            cbBack.Enabled = true;
        }
        

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
