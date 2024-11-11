using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.Utils;
using ZiTyLot.Helper;

namespace ZiTyLot.GUI.Screens.ScanningScr
{
    public partial class BikeCheckInForm : Form
    {
        private readonly CardBUS _cardBUS = new CardBUS();

        private SettingForm _settingForm;
        private readonly FilterInfoCollection cameras;
        private VideoCaptureDevice frontCamera;
        private VideoCaptureDevice backCamera;
        private string frontCameraId;
        private string backCameraId;
        private Dictionary<string, int> cameraUsageCount; // Đếm số lượng camera đang sử dụng cùng một nguồn
        private Dictionary<string, VideoCaptureDevice> sharedDevices; // Quản lý các thiết bị được chia sẻ

        private SerialPort _serialPort;
        private readonly RFIDReader _rfidReader;
        private bool _isGateOpen = false;
        public BikeCheckInForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.KeyPreview = true;
            btnOpen.Resize += btnOpen_Resize;
            uiTableLayoutPanel4.Resize += uiTableLayoutPanel4_Resize;
            uiTableLayoutPanel5.Resize += uiTableLayoutPanel5_Resize;
            uiTableLayoutPanel3.Resize += uiTableLayoutPanel3_Resize;
            uiTableLayoutPanel2.Resize += uiTableLayoutPanel2_Resize;

            // Khởi tạo các collection
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            cameraUsageCount = new Dictionary<string, int>();
            sharedDevices = new Dictionary<string, VideoCaptureDevice>();

            // Cấu hình PictureBox
            this.pbFrontCamera.SizeMode = PictureBoxSizeMode.Zoom;
            this.pbBackCamera.SizeMode = PictureBoxSizeMode.Zoom;
            this.pbFrontRecord.SizeMode = PictureBoxSizeMode.Zoom;
            this.pbBackRecord.SizeMode = PictureBoxSizeMode.Zoom;
            this.pbPlateRecord.SizeMode = PictureBoxSizeMode.Zoom;

            _rfidReader = new RFIDReader();
            _rfidReader.RFIDScanned += RfidReader_RFIDScanned; // Đăng ký sự kiện
        }
        private VideoCaptureDevice GetOrCreateDevice(string cameraId)
        {
            if (!sharedDevices.ContainsKey(cameraId))
            {
                var device = new VideoCaptureDevice(cameraId);
                sharedDevices[cameraId] = device;
                cameraUsageCount[cameraId] = 0;
            }
            cameraUsageCount[cameraId]++;
            return sharedDevices[cameraId];
        }
        private void ReleaseDevice(string cameraId)
        {
            if (string.IsNullOrEmpty(cameraId)) return;

            if (cameraUsageCount.ContainsKey(cameraId))
            {
                cameraUsageCount[cameraId]--;
                if (cameraUsageCount[cameraId] <= 0)
                {
                    if (sharedDevices.ContainsKey(cameraId))
                    {
                        var device = sharedDevices[cameraId];
                        if (device.IsRunning)
                        {
                            device.SignalToStop();
                            device.WaitForStop();
                        }
                        sharedDevices.Remove(cameraId);
                    }
                    cameraUsageCount.Remove(cameraId);
                }
            }
        }
        public void StartFrontCamera(string cameraId)
        {
            if (frontCamera != null)
            {
                ReleaseDevice(frontCameraId);
            }

            frontCameraId = cameraId;
            frontCamera = GetOrCreateDevice(cameraId);

            if (!frontCamera.IsRunning)
            {
                frontCamera.NewFrame += FrontCamera_NewFrame;
                frontCamera.Start();
            }
            else
            {
                frontCamera.NewFrame += FrontCamera_NewFrame;
            }
        }

        public void StartBackCamera(string cameraId)
        {
            if (backCamera != null)
            {
                ReleaseDevice(backCameraId);
            }

            backCameraId = cameraId;
            backCamera = GetOrCreateDevice(cameraId);

            if (!backCamera.IsRunning)
            {
                backCamera.NewFrame += BackCamera_NewFrame;
                backCamera.Start();
            }
            else
            {
                backCamera.NewFrame += BackCamera_NewFrame;
            }
        }

        private void FrontCamera_NewFrame(object sender, NewFrameEventArgs args)
        {
            if (pbFrontCamera.IsDisposed) return;

            try
            {
                var frame = (Bitmap)args.Frame.Clone();
                pbFrontCamera.Invoke(new Action(() => pbFrontCamera.Image = frame));
            }
            catch (ObjectDisposedException)
            {
                StopFrontCamera();
            }
        }

        private void BackCamera_NewFrame(object sender, NewFrameEventArgs args)
        {
            if (pbBackCamera.IsDisposed) return;

            try
            {
                var frame = (Bitmap)args.Frame.Clone();
                pbBackCamera.Invoke(new Action(() => pbBackCamera.Image = frame));
            }
            catch (ObjectDisposedException)
            {
                StopBackCamera();
            }
        }

        public void StopFrontCamera()
        {
            if (frontCamera != null)
            {
                frontCamera.NewFrame -= FrontCamera_NewFrame;
                ReleaseDevice(frontCameraId);
                frontCamera = null;
                frontCameraId = null;
            }
            if (pbFrontCamera != null && !pbFrontCamera.IsDisposed)
            {
                pbFrontCamera.Image = null;
            }
        }

        public void StopBackCamera()
        {
            if (backCamera != null)
            {
                backCamera.NewFrame -= BackCamera_NewFrame;
                ReleaseDevice(backCameraId);
                backCamera = null;
                backCameraId = null;
            }
            if (pbBackCamera != null && !pbBackCamera.IsDisposed)
            {
                pbBackCamera.Image = null;
            }
        }

        public void StopAllCameras()
        {
            StopFrontCamera();
            StopBackCamera();
        }

        private void BikeCheckInForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            StopAllCameras();
            base.OnFormClosing(e);
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

        private void ShowSettingForm()
        {
            if (_settingForm == null || _settingForm.IsDisposed)
            {
                _settingForm = new SettingForm(frontCameraId, backCameraId, _serialPort?.PortName);
                _settingForm.ConnectCameraFront += (sender, cameraId) => StartFrontCamera(cameraId);
                _settingForm.ConnectCameraBack += (sender, cameraId) => StartBackCamera(cameraId);
                _settingForm.DisconnectCameraFront += (sender, e) => StopFrontCamera();
                _settingForm.DisconnectCameraBack += (sender, e) => StopBackCamera();
                _settingForm.ConnectGate += (sender, port) => ConnectGate(port);
                _settingForm.DisconnectGate += (sender, e) => DisconnectGate();
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
        private void uiTableLayoutPanel2_Resize(object sender, EventArgs e)
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

        private void BikeCheckInForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            _rfidReader.ProcessInput(e.KeyChar);
            if (e.KeyChar == (char)Keys.Escape)
            {
                ShowSettingForm();
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                StartVisitorProgress("rfid");
            }
            if (e.KeyChar == (char)Keys.Space)
            {
                if (_isGateOpen)
                {
                    _isGateOpen = false;
                    Arduino.CloseBarrier(_serialPort);
                }
                else
                {
                    _isGateOpen = true;
                    Arduino.OpenBarrier(_serialPort);
                }
            }

        }

        private async void StartVisitorProgress(string rfid)
        {
            //List<FilterCondition> filters = new List<FilterCondition>()
            //{
            //    new FilterCondition(nameof(Card.Rfid), CompOp.Equals, rfid)
            //};
            //Card card = _cardBUS.GetAll(filters)?.FirstOrDefault();
            //if (!ValidateVisitorCard(card)) return;

            //take photo from camera front and back at a pbCameraFront and pbCameraBack component
            if (pbFrontCamera.Image == null || pbBackCamera.Image == null)
            {
                MessageHelper.ShowError("Please connect camera before scanning!");
                return;
            }

            //take photo from camera front and back
            System.Drawing.Image frontImage = pbFrontCamera.Image;
            System.Drawing.Image backImage = pbBackCamera.Image;
            pbFrontRecord.Image = frontImage;
            pbBackRecord.Image = backImage;


            DateTime start = DateTime.Now;
            var result = await ANPR.ProcessImageAsync(backImage);
            DateTime end = DateTime.Now;

            string time = (end - start).TotalSeconds.ToString();
            MessageBox.Show("Time: " + time);
            if (result != null)
            {
                //setImage to pbPlate

                pbPlateRecord.Image = result.Image;
                lbVehicalPlate.Text = result.PlateNumber;

                //save image to file and get path
                ImageHelper.SaveImage(frontImage);
                ImageHelper.SaveImage(backImage);
                ImageHelper.SaveImage(result.Image);
            }
            else
            {
                MessageHelper.ShowError("Cannot detect plate number!");
            }

        }


        private void RfidReader_RFIDScanned(object sender, string rfidCode)
        {
            Debug.WriteLine("RFID Scanned: " + rfidCode);
            StartVisitorProgress(rfidCode);
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateVisitorCard(Card card)
        {
            if (card == null)
            {
                MessageHelper.ShowError("Card not found!");
                return false;
            }
            if (card.Resident_id != null)
            {
                MessageHelper.ShowError("This card is not for visitor!");
                return false;
            }
            return true;
        }
    }
}
