﻿using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.Constants;
using ZiTyLot.Constants.Enum;
using ZiTyLot.DTOS;
using ZiTyLot.GUI.Utils;
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
        private readonly RFIDHelper _rfidReader = new RFIDHelper();

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
            btnOpenGate.Resize += btnOpen_Resize;
            uiTableLayoutPanel4.Resize += uiTableLayoutPanel4_Resize;
            uiTableLayoutPanel5.Resize += uiTableLayoutPanel5_Resize;
            uiTableLayoutPanel3.Resize += uiTableLayoutPanel3_Resize;
            uiTableLayoutPanel2.Resize += uiTableLayoutPanel2_Resize;

            _parkingLotType = parkingLotType;
            _rfidReader.RFIDScanned += RfidReader_RFIDScanned;
            lbCheckOutSession.Text += parkingLotType == ParkingLotType.TWO_WHEELER ? " Two-wheeler" : " Four-wheeler";
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
                ChangeState(ProcessState.Ready);
            }
            else
            {
                ChangeState(ProcessState.Preparing);
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
                    Arduino.OpenBarrier(_serialPort, false);
                    btnOpenGate.Text = btnOpenGate.Text.Replace("OPEN", "CLOSE");
                }
                else
                {
                    _isGateClose = true;
                    Arduino.CloseBarrier(_serialPort);
                    btnOpenGate.Enabled = false;
                    btnOpenGate.Text = btnOpenGate.Text.Replace("CLOSE", "OPEN");

                    UpdateSession();

                    ChangeState(ProcessState.Ready);
                }
            }
            if (e.KeyChar == (char)Keys.Back && _processState == ProcessState.Done)
            {
                DialogResult result = MessageHelper.ShowConfirm("Are you sure you want to cancel this process?");
                if (result == DialogResult.Yes)
                {
                    ChangeState(ProcessState.Ready);
                }
            }
        }
        private void UpdateSession()
        {

            DTOS.Image frontImage = new DTOS.Image()
            {
                Url = ImageHelper.SaveImage(_currentFrontImage),
                Type = ImageType.BEFORE_CHECKOUT,
                Session_id = _currentSession.Id

            };
            _imageBUS.Add(frontImage);
            DTOS.Image backImage = new DTOS.Image()
            {
                Url = ImageHelper.SaveImage(_currentBackImage),
                Type = ImageType.AFTER_CHECKOUT,
                Session_id = _currentSession.Id

            };
            _imageBUS.Add(backImage);

            if (_currentPlateImage != null)
            {
                DTOS.Image plateImage = new DTOS.Image()
                {
                    Url = ImageHelper.SaveImage(_currentPlateImage),
                    Type = ImageType.LICENSE_PLATE_CHECKOUT,
                    Session_id = _currentSession.Id

                };
                _imageBUS.Add(plateImage);
            }
            _sessionBUS.Update(_currentSession);

        }
        private async void StartVisitorProcess()
        {
            ChangeState(ProcessState.Scanning);

            _currentFrontImage = _cameraHelper.GetImageFromPictureBox(pbFrontCamera);
            _currentBackImage = _cameraHelper.GetImageFromPictureBox(pbBackCamera);
            _currentPlateImage = null;

            //set image to record
            pbFrontRecord.Image = _currentFrontImage;
            pbBackRecord.Image = _currentBackImage;
            pbPlateRecord.Image = _currentPlateImage;
            pbCheckInPlate.Image = null;

            SetCurrentSessionCheckinImage();

            _currentSession.Checkout_time = DateTime.Now;

            lbCardRfid.Text = _currentSession.Card.Rfid;
            lbCardType.Text = _currentSession.Card.Type.ToString();
            lbVehicalType.Text = _currentSession.Card.Vehicle_type.Name;
            lbCheckInTime.Text = _currentSession.Checkin_time?.ToString("dd/MM/yyyy\nHH:mm:ss");
            lbCheckOutTime.Text = _currentSession.Checkout_time?.ToString("dd/MM/yyyy\nHH:mm:ss");

            TimeSpan totalTime = _currentSession.Checkout_time.Value - _currentSession.Checkin_time.Value;
            lbTotalTime.Text = totalTime.ToString(@"hh\:mm\:ss");
            _currentSession.Fee = _sessionBUS.CalculateFee(_currentSession);
            lbTotalPrice.Text = _currentSession.Fee?.ToString("C0", new System.Globalization.CultureInfo("vi-VN"));


            if (_currentSession.Card.Vehicle_type.Id == VehicleTypeID.BICYCLE)
            {
                lbVehicalPlate.Text = "";
            }
            else
            {
                lbVehicalPlate.Text = "Scanning...";
                var result = await ANPR.ProcessImageAsync(_currentBackImage);
                if (result != null)
                {

                    _currentPlateImage = result.Image;
                    pbPlateRecord.Image = _currentPlateImage;
                    lbVehicalPlate.Text = $"in:{_currentSession.License_plate}\nout:{result.PlateNumber}";

                    if (_currentSession.License_plate != result.PlateNumber)
                    {
                        DialogResult dialogResult = MessageBox.Show(
                              "License plate does not match with the card! Do you want to continue?",
                              "Warning",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Warning,
                              MessageBoxDefaultButton.Button2
                          );

                        if (dialogResult == DialogResult.No)
                        {
                            ChangeState(ProcessState.Ready);
                            return;
                        }
                    }
                }
                else
                {
                    MessageHelper.ShowError("Cannot recognize license plate!, please try again!");
                    lbProcessState.Text = ProcessState.Ready.ToString();
                    _processState = ProcessState.Ready;
                    lbVehicalPlate.Text = "";
                    return;
                }
            }
            btnOpenGate.Enabled = true;
            ChangeState(ProcessState.Done);
            await Arduino.PlaySoundAsync($"{_currentSession.Fee}.mp3");
        }
        private void SetCurrentSessionCheckinImage()
        {
            foreach (ZiTyLot.DTOS.Image image in _currentSession.Images)
            {
                if (image.Type == ImageType.BEFORE_CHECKIN)
                {
                    pbCheckInFront.Image = ImageHelper.LoadImage(image.Url);
                }
                else if (image.Type == ImageType.AFTER_CHECKIN)
                {
                    pbCheckInBack.Image = ImageHelper.LoadImage(image.Url);
                }
                else if (image.Type == ImageType.LICENSE_PLATE_CHECKIN)
                {
                    pbCheckInPlate.Image = ImageHelper.LoadImage(image.Url);
                }
            }
        }
        private async void StartResidentProcess(Card card, List<Session> sessions)
        {
            ChangeState(ProcessState.Scanning);
            _currentFrontImage = _cameraHelper.GetImageFromPictureBox(pbFrontCamera);
            _currentBackImage = _cameraHelper.GetImageFromPictureBox(pbBackCamera);
            _currentPlateImage = null;
            //set image to record
            pbFrontRecord.Image = _currentFrontImage;
            pbBackRecord.Image = _currentBackImage;
            pbPlateRecord.Image = _currentPlateImage;
            pbCheckInPlate.Image = null;
            pbCheckInBack.Image = null;
            pbCheckInFront.Image = null;

            card = _cardBUS.PopulateResident(card);
            lbCardRfid.Text = card.Rfid;
            lbCardType.Text = card.Type.ToString();
            lbFullname.Text = card.Resident.Full_name;
            lbApartment.Text = card.Resident.Apartment_id;
            lbTotalPrice.Text = "";

            lbVehicalPlate.Text = "Scanning...";
            var result = await ANPR.ProcessImageAsync(_currentBackImage);


            if (_parkingLotType == ParkingLotType.TWO_WHEELER)
            {
                if (result == null)
                {
                    lbVehicalPlate.Text = "";
                    lbVehicalType.Text = "BICYCLE";
                    _currentSession = sessions.Find(s => s.License_plate == null);
                    if (_currentSession == null)
                    {
                        MessageHelper.ShowError("Session not found!");
                        ChangeState(ProcessState.Ready);
                        return;
                    }
                    _currentSession = _sessionBUS.PopulateImages(_currentSession);
                    _currentSession.Checkout_time = DateTime.Now;
                    SetCurrentSessionCheckinImage();
                    lbCheckInTime.Text = _currentSession.Checkin_time?.ToString("dd/MM/yyyy\nHH:mm:ss");
                    lbCheckOutTime.Text = _currentSession.Checkout_time?.ToString("dd/MM/yyyy\nHH:mm:ss");
                    TimeSpan totalTime = _currentSession.Checkout_time.Value - _currentSession.Checkin_time.Value;
                    lbTotalTime.Text = totalTime.ToString(@"hh\:mm\:ss");
                }
                else
                {
                    lbVehicalType.Text = "MOTORBIKE";
                    lbVehicalPlate.Text = result.PlateNumber;
                    pbPlateRecord.Image = result.Image;
                    _currentSession = sessions.Find(s => s.License_plate == result.PlateNumber);
                    if (_currentSession == null)
                    {
                        MessageHelper.ShowError("Session not found!");
                        ChangeState(ProcessState.Ready);
                        return;
                    }
                    _currentSession = _sessionBUS.PopulateImages(_currentSession);
                    _currentSession.Checkout_time = DateTime.Now;
                    _currentPlateImage = result.Image;
                    SetCurrentSessionCheckinImage();
                    lbCheckInTime.Text = _currentSession.Checkin_time?.ToString("dd/MM/yyyy\nHH:mm:ss");
                    lbCheckOutTime.Text = _currentSession.Checkout_time?.ToString("dd/MM/yyyy\nHH:mm:ss");
                    TimeSpan totalTime = _currentSession.Checkout_time.Value - _currentSession.Checkin_time.Value;
                    lbTotalTime.Text = totalTime.ToString(@"hh\:mm\:ss");
                }
            }
            else
            {
                lbVehicalType.Text = "CAR";
                if (result != null)
                {
                    List<Issue> issues = _cardBUS.GetAllValidIssues(card.Id);
                    lbVehicalPlate.Text = result.PlateNumber;
                    pbPlateRecord.Image = result.Image;
                    _currentSession = sessions.Find(s => s.License_plate == result.PlateNumber);
                    if (_currentSession == null)
                    {
                        MessageHelper.ShowError("Session not found!");
                        ChangeState(ProcessState.Ready);
                        return;
                    }
                    _currentSession = _sessionBUS.PopulateImages(_currentSession);
                    _currentSession.Checkout_time = DateTime.Now;
                    _currentPlateImage = result.Image;
                    SetCurrentSessionCheckinImage();
                    lbCheckInTime.Text = _currentSession.Checkin_time?.ToString("dd/MM/yyyy\nHH:mm:ss");
                    lbCheckOutTime.Text = _currentSession.Checkout_time?.ToString("dd/MM/yyyy\nHH:mm:ss");
                    TimeSpan totalTime = _currentSession.Checkout_time.Value - _currentSession.Checkin_time.Value;
                    lbTotalTime.Text = totalTime.ToString(@"hh\:mm\:ss");
                }
                else
                {
                    lbVehicalPlate.Text = "";
                    MessageHelper.ShowError("Cannot recognize license plate!, please try again!");
                    ChangeState(ProcessState.Ready);
                    return;
                }
            }

            ChangeState(ProcessState.Done);
        }

        private void ChangeState(ProcessState state)
        {
            lbProcessState.Text = state.ToString();
            _processState = state;

            if (state == ProcessState.Done)
            {
                btnOpenGate.Enabled = true;
            }
            else
            {
                btnOpenGate.Enabled = false;
            }
        }
        private void RfidReader_RFIDScanned(object sender, string rfidCode)
        {
            Debug.WriteLine("RFID Scanned: " + rfidCode);
            if (_processState == ProcessState.Preparing)
            {
                MessageHelper.ShowError("Please configure all devices before scanning!");
                return;
            }
            if (_processState != ProcessState.Ready)
            {
                MessageHelper.ShowError("Please wait for the current process to finish!");
                return;
            }
            List<FilterCondition> cardFilters = new List<FilterCondition>()
            {
                new FilterCondition(nameof(Card.Rfid), CompOp.Equals, rfidCode)
            };
            Card card = _cardBUS.GetAll(cardFilters)?.FirstOrDefault();
            if (!ValidateCard(card)) return;
            List<FilterCondition> sessionFilters = new List<FilterCondition>()
                {
                    new FilterCondition(nameof(Session.Card_id), CompOp.Equals, card.Id),
                    new FilterCondition(nameof(Session.Checkout_time), CompOp.Equals, null)
                };
            List<Session> sessions = _sessionBUS.GetAll(sessionFilters);
            if (card.Type == CardType.VISITOR)
            {

                _currentSession = sessions?.FirstOrDefault();
                if (_currentSession == null)
                {
                    MessageHelper.ShowError("Session check in not found!");
                    return;
                }
                _currentSession = _sessionBUS.PopulateImages(_currentSession);
                _currentSession.Card = _cardBUS.PopulateVehicleType(card);
                StartVisitorProcess();
            }
            else
            {

                StartResidentProcess(card, sessions);
            }


        }
        private bool ValidateCard(Card card)
        {
            if (card == null)
            {
                MessageHelper.ShowError("Card not found!");
                return false;
            }
            if (card.Type == CardType.RESIDENT && card.Status == CardStatus.EMPTY)
            {
                MessageHelper.ShowError("This resident card is empty!");
                return false;
            }
            if (card.Type == CardType.RESIDENT && card.Status == CardStatus.LOST)
            {
                MessageHelper.ShowError("This resident card is lost!");
                return false;
            }
            if (card.Type == CardType.RESIDENT && card.Status == CardStatus.BLOCKED)
            {
                MessageHelper.ShowError("This resident card is blocked!");
                return false;
            }
            if (card.Type == CardType.VISITOR)
            {

                if (_parkingLotType == ParkingLotType.TWO_WHEELER && card.Vehicle_type_id == VehicleTypeID.CAR)
                {
                    MessageHelper.ShowError("This line is for two-wheeler only so this card is not valid!");
                    return false;
                }
                if (_parkingLotType == ParkingLotType.FOUR_WHEELER
                    && (card.Vehicle_type_id == VehicleTypeID.MOTORBIKE || card.Vehicle_type_id == VehicleTypeID.BICYCLE))
                {
                    MessageHelper.ShowError("This line is for four-wheeler only so this card is not valid!");
                    return false;
                }
            }
            return true;
        }

        private void btnOpenGate_Click(object sender, EventArgs e)
        {
            if (_isGateClose && _processState == ProcessState.Done)
            {
                _isGateClose = false;
                Arduino.OpenBarrier(_serialPort, false);
                btnOpenGate.Text = btnOpenGate.Text.Replace("OPEN", "CLOSE");
            }
            else if (!_isGateClose && _processState == ProcessState.Done)
            {
                _isGateClose = true;
                Arduino.CloseBarrier(_serialPort);
                btnOpenGate.Enabled = false;
                btnOpenGate.Text = btnOpenGate.Text.Replace("CLOSE", "OPEN");

                UpdateSession();

                lbProcessState.Text = ProcessState.Ready.ToString();
                _processState = ProcessState.Ready;
            }
            this.Focus();
        }

        private async void CheckOutFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isClosing) return;

            DisconnectGate();
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
    }
}
