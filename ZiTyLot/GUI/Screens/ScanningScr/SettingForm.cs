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
using System.IO.Ports;
using System.ComponentModel.Composition.Primitives;
using ZiTyLot.Helper;
namespace ZiTyLot.GUI.Screens.ScanningScr
{
    public partial class SettingForm : Form
    {
        private FilterInfoCollection cameras;
        private readonly List<string> monikerStrings = new List<string>();
        private SerialPort serialPort;
        public SettingForm(string frontCameraId, string backCameraId, string serialPort)
        {
            InitializeComponent();
            this.CenterToScreen();
            GetVideoDevices();
            GetSerialPort();

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
            if (!string.IsNullOrEmpty(serialPort))
            {
                cbGate.SelectedItem = serialPort;
                btnConnectGate.Enabled = false;
                btnDisconnectGate.Enabled = true;
                cbGate.Enabled = false;
            }
        }

        public event EventHandler<string> ConnectCameraFront;
        public event EventHandler<string> ConnectCameraBack;
        public event EventHandler DisconnectCameraFront;
        public event EventHandler DisconnectCameraBack;
        public event EventHandler<string> ConnectGate;
        public event EventHandler DisconnectGate;
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
            if (cbFront.Items.Count == 0)
            {
                cbBack.Items.Add("No available camera");
                cbFront.Items.Add("No available camera");
                cbBack.Enabled = false;
                cbFront.Enabled = false;
            }
            cbFront.SelectedIndex = 0;
            cbBack.SelectedIndex = 0;

        }
        private void GetSerialPort()
        {
            string[] ports = SerialPort.GetPortNames();
            cbGate.Items.Clear();
            foreach (string port in ports)
            {
                if (!IsPortInUse(port))
                {
                    cbGate.Items.Add(port);
                }
            }
            if (cbGate.Items.Count == 0)
            {
                cbGate.Items.Add("No available port");
                btnConnectGate.Enabled = false;
                cbGate.Enabled = false;
            }
            cbGate.SelectedIndex = 0;

        }
        public static bool IsPortInUse(string portName)
        {
            try
            {
                using (SerialPort port = new SerialPort(portName))
                {
                    port.Open();
                    port.Close();
                    return false;
                }
            }
            catch (UnauthorizedAccessException)
            {
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
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

        private void btnConnectGate_Click(object sender, EventArgs e)
        {
            if (cbGate.SelectedItem != null)
            {
                string selectedPort = cbGate.SelectedItem.ToString();
                btnDisconnectGate.Enabled = true;
                btnConnectGate.Enabled = false;
                cbGate.Enabled = false;
                ConnectGate?.Invoke(this, selectedPort);
            }
        }

        private void btnDisconnectGate_Click(object sender, EventArgs e)
        {
            btnConnectGate.Enabled = true;
            btnDisconnectGate.Enabled = false;
            cbGate.Enabled = true;
            DisconnectGate?.Invoke(this, e);
        }
    }
}
