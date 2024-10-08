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
            using (SoundPlayer player = new SoundPlayer("../../Resource/enter.wav"))
            {
                player.Play();
            }
            Arduino.DoAction(serialPort, ArduinoAction.RED_OFF);
            Arduino.DoAction(serialPort, ArduinoAction.GREEN_ON);
            Arduino.DoAction(serialPort, ArduinoAction.BARIE_OPEN);
            close.Enabled = true;
            open.Enabled = false;
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            if (cbPort.SelectedItem != null)
            {
                string selectedPort = cbPort.SelectedItem.ToString();
                serialPort = Arduino.Connect(selectedPort);
                Arduino.DoAction(serialPort, ArduinoAction.RED_ON);
                Arduino.DoAction(serialPort, ArduinoAction.BARIE_CLOSE);
                MessageBox.Show("Connected to " + selectedPort);
                open.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please select a COM port.");
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Arduino.DoAction(serialPort, ArduinoAction.GREEN_OFF);
            Arduino.DoAction(serialPort, ArduinoAction.BARIE_CLOSE);
            Arduino.DoAction(serialPort, ArduinoAction.RED_ON);
            close.Enabled = false;
            open.Enabled = true;
        }
    }
}
