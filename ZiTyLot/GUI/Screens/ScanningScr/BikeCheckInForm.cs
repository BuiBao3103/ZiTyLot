using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ZiTyLot.GUI.Screens.ScanningScr
{
    public partial class BikeCheckInForm : Form
    {
        private SettingForm _settingForm;
        private readonly FilterInfoCollection cameras;
        private VideoCaptureDevice frontCamera;
        private VideoCaptureDevice backCamera;
        private string frontCameraId;
        private string backCameraId;
        private Dictionary<string, int> cameraUsageCount; // Đếm số lượng camera đang sử dụng cùng một nguồn
        private Dictionary<string, VideoCaptureDevice> sharedDevices; // Quản lý các thiết bị được chia sẻ
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
                _settingForm = new SettingForm(frontCameraId, backCameraId);
                _settingForm.ConnectCameraFront += (sender, cameraId) => StartFrontCamera(cameraId);
                _settingForm.ConnectCameraBack += (sender, cameraId) => StartBackCamera(cameraId);
                _settingForm.DisconnectCameraFront += (sender, e) => StopFrontCamera();
                _settingForm.DisconnectCameraBack += (sender, e) => StopBackCamera();
                _settingForm.Show();
            }
            else
            {
                if (_settingForm.WindowState == FormWindowState.Minimized)
                    _settingForm.WindowState = FormWindowState.Normal;
                _settingForm.BringToFront();
            }
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
            if (e.KeyChar == (char)Keys.Escape)
            {
                ShowSettingForm();
            }
        }



        private void btnOpen_Click(object sender, EventArgs e)
        {

        }
    }
}
