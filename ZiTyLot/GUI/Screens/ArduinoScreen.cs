using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiTyLot.Helper;
using ZiTyLot.Constants;
using System.IO.Ports;
namespace ZiTyLot.GUI.Screens
{
    public partial class ArduinoScreen : UserControl
    {
        private readonly SerialPort serialPort;
        public ArduinoScreen()
        {
            InitializeComponent();
            serialPort = Arduino.Connect("COM5");
            Arduino.DoAction(serialPort, ArduinoAction.RED_ON);
            Arduino.DoAction(serialPort, ArduinoAction.BARIE_CLOSE);
        }

        private void btnQuet_Click(object sender, EventArgs e)
        {
            Arduino.DoAction(serialPort, ArduinoAction.RED_OFF);
            Arduino.DoAction(serialPort, ArduinoAction.GREEN_ON);
            Arduino.DoAction(serialPort, ArduinoAction.BARIE_OPEN);
        }

        private void ArduinoScreen_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Arduino.DoAction(serialPort, ArduinoAction.GREEN_OFF);
            Arduino.DoAction(serialPort, ArduinoAction.BARIE_CLOSE);
            Arduino.DoAction(serialPort, ArduinoAction.RED_ON);
        }
    }
}
