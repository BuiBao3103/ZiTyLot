using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.Constants.Enum;
using ZiTyLot.ENTITY;
using ZiTyLot.Helper;

namespace ZiTyLot.GUI.Screens.ScanningScr
{
    public partial class CheckOutFrom : Form
    {
        private readonly CardBUS _cardBUS = new CardBUS();
        private readonly SessionBUS _sessionBUS = new SessionBUS();
        private readonly ImageBUS _imageBUS = new ImageBUS();

        private readonly CameraHelper _cameraHelper = new CameraHelper();
        private VideoCaptureDevice _frontCamera;
        private VideoCaptureDevice _backCamera;
        private string _frontCameraId;
        private string _backCameraId;
        private bool _isClosing = false;

        private SettingForm _settingForm;

        private SerialPort _serialPort;
        private readonly RFIDReader _rfidReader;

        private bool _isGateClose = true;
        private ProcessState _processState = ProcessState.Preparing;
        private ParkingLotType _parkingLotType;

        private Session _currentSession;
        private System.Drawing.Image _currentFrontImage;
        private System.Drawing.Image _currentBackImage;
        private System.Drawing.Image _currentPlateImage;
        public CheckOutFrom(ParkingLotType parkingLotType)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.KeyPreview = true;
            btnOpen.Resize += btnOpen_Resize;
            uiTableLayoutPanel4.Resize += uiTableLayoutPanel4_Resize;
            uiTableLayoutPanel5.Resize += uiTableLayoutPanel5_Resize;
            uiTableLayoutPanel3.Resize += uiTableLayoutPanel3_Resize;
            uiTableLayoutPanel2.Resize += uiTableLayoutPanel2_Resize;
        }
        public void StartFrontCamera(string cameraId)
        {
            if (_frontCamera != null)
            {
                Task.Run(() => _cameraHelper.StopCameraAsync(_frontCameraId, _frontCamera, pbFrontCamera));
            }

            _frontCameraId = cameraId;
            _cameraHelper.StartCamera(cameraId, pbFrontCamera, out _frontCamera);
        }

        public void StartBackCamera(string cameraId)
        {
            if (_backCamera != null)
            {
                Task.Run(() => _cameraHelper.StopCameraAsync(_backCameraId, _backCamera, pbBackCamera));
            }

            _backCameraId = cameraId;
            _cameraHelper.StartCamera(cameraId, pbBackCamera, out _backCamera);
        }

        public async Task StopFrontCameraAsync()
        {
            await _cameraHelper.StopCameraAsync(_frontCameraId, _frontCamera, pbFrontCamera);
            _frontCamera = null;
            _frontCameraId = null;
        }

        public async Task StopBackCameraAsync()
        {
            await _cameraHelper.StopCameraAsync(_backCameraId, _backCamera, pbBackCamera);
            _backCamera = null;
            _backCameraId = null;
        }

        public async Task StopAllCamerasAsync()
        {
            var tasks = new List<Task>
        {
            StopFrontCameraAsync(),
            StopBackCameraAsync()
        };
            await Task.WhenAll(tasks);
        }

        private async void BikeCheckInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isClosing) return;

            _isClosing = true;
            e.Cancel = true; // Tạm thời cancel việc đóng form

            try
            {
                await StopAllCamerasAsync();
                await _cameraHelper.DisposeAsync();
            }
            finally
            {
                this.Close(); // Đóng form sau khi đã cleanup xong
            }
        }

        private void ShowSettingForm()
        {
            if (_settingForm == null || _settingForm.IsDisposed)
            {
                _settingForm = new SettingForm(_frontCameraId, _backCameraId, _serialPort?.PortName);

                // Kết nối camera
                _settingForm.ConnectCameraFront += (sender, cameraId) =>
                {
                    StartFrontCamera(cameraId);
                    updateStatusDevice();

                };
                _settingForm.ConnectCameraBack += (sender, cameraId) =>
                {
                    StartBackCamera(cameraId);
                    updateStatusDevice();
                };

                // Ngắt kết nối camera - sử dụng async
                _settingForm.DisconnectCameraFront += async (sender, e) =>
                {
                    await StopFrontCameraAsync();
                    updateStatusDevice();
                };
                _settingForm.DisconnectCameraBack += async (sender, e) =>
                {
                    await StopBackCameraAsync();
                    updateStatusDevice();
                };

                // Gate events
                _settingForm.ConnectGate += (sender, port) =>
                {
                    ConnectGate(port);
                    updateStatusDevice();
                };
                _settingForm.DisconnectGate += (sender, e) =>
                {
                    DisconnectGate();
                    updateStatusDevice();
                };

                _settingForm.Show();
            }
            else
            {
                if (_settingForm.WindowState == FormWindowState.Minimized)
                    _settingForm.WindowState = FormWindowState.Normal;
                _settingForm.BringToFront();
            }
        }
        private void ConnectGate(string port)
        {
            if (_serialPort != null)
            {
                _serialPort.Close();
            }
            _serialPort = Arduino.Connect(port);
        }

        private void DisconnectGate()
        {
            Arduino.Disconnect(_serialPort);
        }

        private void updateStatusDevice()
        {
            if (_frontCameraId != null)
            {
                lbFrontCameraStatus.Text = "Connected";
                lbFrontCameraStatus.ForeColor = Color.Green;
            }
            else
            {

                lbFrontCameraStatus.Text = "Disconnected";
                lbFrontCameraStatus.ForeColor = Color.Red;
            }
            if (_backCameraId != null)
            {
                lbBackCameraStatus.Text = "Connected";
                lbBackCameraStatus.ForeColor = Color.Green;
            }
            else
            {
                lbBackCameraStatus.Text = "Disconnected";
                lbBackCameraStatus.ForeColor = Color.Red;
            }
            if (_serialPort != null)
            {
                lbBoomGateStatus.Text = "Connected";
                lbBoomGateStatus.ForeColor = Color.Green;
            }
            else
            {
                lbBoomGateStatus.Text = "Disconnected";
                lbBoomGateStatus.ForeColor = Color.Red;
            }
            if (_frontCameraId != null && _backCameraId != null && _serialPort != null)
            {
                lbProcessState.Text = ProcessState.Ready.ToString();
                _processState = ProcessState.Ready;
            }
            else
            {
                lbProcessState.Text = ProcessState.Preparing.ToString();
                _processState = ProcessState.Preparing;
            }
        }

        private void btnOpen_Resize(object sender, System.EventArgs e)
        {
            if (this.Size.Width > 1800)
            {
                btnOpen.Font = new System.Drawing.Font("Helvetica", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            else
            {
                btnOpen.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

        private void uiTableLayoutPanel4_Resize(object sender, System.EventArgs e)
        {

            foreach (Label lable in uiTableLayoutPanel4.Controls)
            {
                if (this.Size.Width > 1800)
                {
                    lable.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else
                {
                    lable.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }

        }

        private void uiTableLayoutPanel5_Resize(object sender, System.EventArgs e)
        {
            foreach (Label lable in uiTableLayoutPanel5.Controls)
            {
                if (this.Size.Width > 1800)
                {
                    lable.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else
                {
                    lable.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void uiTableLayoutPanel3_Resize(object sender, System.EventArgs e)
        {
            foreach (Label lable in uiTableLayoutPanel3.Controls)
            {
                if (this.Size.Width > 1800)
                {
                    lable.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else
                {
                    lable.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void CheckOutForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                //SettingForm settingForm = new SettingForm();
                //settingForm.Show();

            }
        }

        private void uiTableLayoutPanel2_Resize(object sender, System.EventArgs e)
        {
            foreach (Label lable in uiTableLayoutPanel2.Controls)
            {
                if (this.Size.Width > 1800)
                {
                    lable.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else
                {
                    lable.Font = new System.Drawing.Font("Helvetica", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void CheckOutFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                ShowSettingForm();
            }
        }
    }
}
