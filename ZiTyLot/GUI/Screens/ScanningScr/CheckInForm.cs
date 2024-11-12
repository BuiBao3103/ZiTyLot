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
using ZiTyLot.Constants;
using ZiTyLot.Constants.Enum;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.Utils;
using ZiTyLot.Helper;

namespace ZiTyLot.GUI.Screens.ScanningScr
{
    public partial class CheckInForm : Form
    {
        private readonly CardBUS _cardBUS = new CardBUS();

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
        private ProcessState _processState = ProcessState.Ready;
        private ParkingLotType _parkingLotType;

        public CheckInForm(ParkingLotType parkingLotType)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.KeyPreview = true;
            btnOpenGate.Resize += btnOpen_Resize;
            uiTableLayoutPanel4.Resize += uiTableLayoutPanel4_Resize;
            uiTableLayoutPanel5.Resize += uiTableLayoutPanel5_Resize;
            uiTableLayoutPanel3.Resize += uiTableLayoutPanel3_Resize;
            uiTableLayoutPanel2.Resize += uiTableLayoutPanel2_Resize;

            _parkingLotType = parkingLotType;

            // Cấu hình PictureBox
            this.pbFrontCamera.SizeMode = PictureBoxSizeMode.Zoom;
            this.pbBackCamera.SizeMode = PictureBoxSizeMode.Zoom;
            this.pbFrontRecord.SizeMode = PictureBoxSizeMode.Zoom;
            this.pbBackRecord.SizeMode = PictureBoxSizeMode.Zoom;
            this.pbPlateRecord.SizeMode = PictureBoxSizeMode.Zoom;

            _rfidReader = new RFIDReader();
            _rfidReader.RFIDScanned += RfidReader_RFIDScanned; // Đăng ký sự kiện
            _parkingLotType = parkingLotType;
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

        private async void ShowSettingForm()
        {
            if (_settingForm == null || _settingForm.IsDisposed)
            {
                _settingForm = new SettingForm(_frontCameraId, _backCameraId, _serialPort?.PortName);

                // Kết nối camera
                _settingForm.ConnectCameraFront += (sender, cameraId) =>
                {
                    StartFrontCamera(cameraId);
                    lbFrontCameraStatus.Text = "Connected";
                    lbFrontCameraStatus.ForeColor = Color.Green;

                };
                _settingForm.ConnectCameraBack += (sender, cameraId) =>
                {
                    StartBackCamera(cameraId);
                    lbBackCameraStatus.Text = "Connected";
                    lbBackCameraStatus.ForeColor = Color.Green;
                };

                // Ngắt kết nối camera - sử dụng async
                _settingForm.DisconnectCameraFront += async (sender, e) =>
                {
                    await StopFrontCameraAsync();
                    lbFrontCameraStatus.Text = "Disconnected";
                    lbFrontCameraStatus.ForeColor = Color.Red;
                };
                _settingForm.DisconnectCameraBack += async (sender, e) =>
                {
                    await StopBackCameraAsync();
                    lbBackCameraStatus.Text = "Disconnected";
                    lbBackCameraStatus.ForeColor = Color.Red;
                };

                // Gate events
                _settingForm.ConnectGate += (sender, port) =>
                {
                    ConnectGate(port);
                    lbBoomGateStatus.Text = "Connected";
                    lbBoomGateStatus.ForeColor = Color.Green;
                };
                _settingForm.DisconnectGate += (sender, e) =>
                {
                    DisconnectGate();
                    lbBoomGateStatus.Text = "Disconnected";
                    lbBoomGateStatus.ForeColor = Color.Red;
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
        private void btnOpen_Resize(object sender, System.EventArgs e)
        {
            if (this.Size.Width > 1800)
            {
                btnOpenGate.Font = new System.Drawing.Font("Helvetica", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            else
            {
                btnOpenGate.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            if (e.KeyChar == (char)Keys.Space && _processState == ProcessState.Done)
            {
                if (_isGateClose)
                {
                    _isGateClose = false;
                    Arduino.OpenBarrier(_serialPort);
                    btnOpenGate.Text = btnOpenGate.Text.Replace("OPEN", "CLOSE");
                }
                else
                {
                    _isGateClose = true;
                    Arduino.CloseBarrier(_serialPort);
                    btnOpenGate.Enabled = false;
                    btnOpenGate.Text = btnOpenGate.Text.Replace("CLOSE", "OPEN");
                    _processState = ProcessState.Ready;
                }
            }

        }
        private async void StartVisitorProcess(Card card)
        {
            _processState = ProcessState.Scanning;

            System.Drawing.Image frontImage = _cameraHelper.GetImageFromPictureBox(pbFrontCamera);
            System.Drawing.Image backImage = _cameraHelper.GetImageFromPictureBox(pbBackCamera);

            pbFrontRecord.Image = frontImage;
            pbBackRecord.Image = backImage;
            pbPlateRecord.Image = null;


            lbCardRfid.Text = card.Rfid;
            lbCardType.Text = card.Type.ToString();
            lbVehicalType.Text = card.Vehicle_type.Name;
            lbVehicalPlate.Text = "Scanning...";
            lbCheckInTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            lbCheckOutTime.Text = "";
            lbTotalTime.Text = "";
            lbTotalPrice.Text = "";

            if (card.Vehicle_type.Id == VehicleTypeID.CAR || card.Vehicle_type.Id == VehicleTypeID.MOTORBIKE)
            {
                var result = await ANPR.ProcessImageAsync(backImage);

                if (result != null)
                {
                    //setImage to pbPlate
                    pbPlateRecord.Image = result.Image;
                    lbVehicalPlate.Text = result.PlateNumber;

                    //save image to file and get path
                    //ImageHelper.SaveImage(frontImage);
                    //ImageHelper.SaveImage(backImage);
                    //ImageHelper.SaveImage(result.Image);
                    btnOpenGate.Enabled = true;

                }
                else
                {
                    MessageHelper.ShowError("Cannot detect plate number!");
                }
            }
            else
            {
                MessageHelper.ShowError("Bike only!");
            }
            _processState = ProcessState.Done;

        }


        private void RfidReader_RFIDScanned(object sender, string rfidCode)
        {
            if (_processState != ProcessState.Ready)
            {
                MessageHelper.ShowError("Please wait for the current process to finish!");
                return;
            }
            if (pbFrontCamera.Image == null || pbBackCamera.Image == null)
            {
                MessageHelper.ShowError("Please connect camera before scanning!");
                return;
            }
            if (_serialPort == null)
            {
                MessageHelper.ShowError("Please connect gate before scanning!");
                return;
            }
            List<FilterCondition> filters = new List<FilterCondition>()
            {
                new FilterCondition(nameof(Card.Rfid), CompOp.Equals, rfidCode)
            };
            Card card = _cardBUS.GetAll(filters)?.FirstOrDefault();
            if (!ValidateVisitorCard(card)) return;
            card = _cardBUS.PopulateVehicleType(card);
            StartVisitorProcess(card);
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
                MessageHelper.ShowError("Card is not for visitor!");
                return false;
            }
            if (_parkingLotType == ParkingLotType.TWO_WHEELER && card.Vehicle_type_id == VehicleTypeID.CAR)
            {
                MessageHelper.ShowError("This line is for two-wheeler only so this card is not valid!");
                return false;
            }
            if (_parkingLotType == ParkingLotType.FOUR_WHEELER
                && card.Vehicle_type_id == VehicleTypeID.MOTORBIKE || card.Vehicle_type_id == VehicleTypeID.BIKECYCLE)
            {
                MessageHelper.ShowError("This line is for four-wheeler only so this card is not valid!");
                return false;
            }
            return true;
        }

        private void CheckInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
