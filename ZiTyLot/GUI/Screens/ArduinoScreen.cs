using System;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using ZiTyLot.Constants;
using ZiTyLot.Helper;

namespace ZiTyLot.GUI.Screens
{
    public partial class ArduinoScreen : UserControl
    {
        private SerialPort serialPort;

        public ArduinoScreen()
        {
            InitializeComponent();
            close.Enabled = false;
            open.Enabled = false;
            btnDisconnect.Enabled = false;
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

        private void btnQuet_Click(object sender, EventArgs e)
        {
            Arduino.OpenBarrier(serialPort);
            close.Enabled = true;
            open.Enabled = false;
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            if (cbPort.SelectedItem != null)
            {
                string selectedPort = cbPort.SelectedItem.ToString();
                serialPort = Arduino.Connect(selectedPort);
                MessageBox.Show("Connected to " + selectedPort);
                open.Enabled = true;
                btnDisconnect.Enabled = true;
                Connect.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please select a COM port.");
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Arduino.CloseBarrier(serialPort);
            close.Enabled = false;
            open.Enabled = true;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort != null)
            {
                Arduino.Disconnect(serialPort);
                MessageBox.Show("Disconnected");
                open.Enabled = false;
                close.Enabled = false;
                Connect.Enabled = true;
                btnDisconnect.Enabled = false;
            }
        }
    }
}
