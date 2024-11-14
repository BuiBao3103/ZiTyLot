using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Windows.Forms;
using ZiTyLot.Constants;
using ZiTyLot.Helper;

namespace ZiTyLot.GUI.Screens
{
    public partial class ArduinoRFIDReader : Form
    {
        private SerialPort serialPort;
        private RFIDHelper rfidReader;

        public ArduinoRFIDReader()
        {
            InitializeComponent();
            btnDisconnect.Enabled = false;
            this.KeyPreview = true;

            rfidReader = new RFIDHelper();
            rfidReader.RFIDScanned += RfidReader_RFIDScanned; // Đăng ký sự kiện
        }

        private void ArduinoScreen_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cbPort.Items.AddRange(ports);
            if (ports.Length > 0)
            {
                cbPort.SelectedIndex = 0;
            }
        }



        private void Connect_Click(object sender, EventArgs e)
        {
            if (cbPort.SelectedItem != null)
            {
                string selectedPort = cbPort.SelectedItem.ToString();
                serialPort = Arduino.Connect(selectedPort);
                btnDisconnect.Enabled = true;
                btnConnect.Enabled = false;
                this.ActiveControl = null;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Arduino.Disconnect(serialPort);
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
        }

        private void ArduinoRFIDReader_KeyPress(object sender, KeyPressEventArgs e)
        {
            rfidReader.ProcessInput(e.KeyChar);
            if (e.KeyChar == (char)32)
            {
                Arduino.CloseBarrier(serialPort);
            }
        }

        private void RfidReader_RFIDScanned(object sender, string rfidCode)
        {
            Debug.WriteLine("RFID Scanned: " + rfidCode);
            lbRFID.Text = rfidCode;
            Arduino.OpenBarrier(serialPort);
        }

    }
}
