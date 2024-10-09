using System.IO.Ports;
using System.Media;
using ZiTyLot.Constants;

namespace ZiTyLot.Helper
{
    public static class Arduino
    {
        private const int BAUD_RATE = 9600;
        public static SerialPort Connect(string portName)
        {
            SerialPort serialPort = new SerialPort(portName, BAUD_RATE);
            serialPort.Open();
            CloseBarrier(serialPort);
            return serialPort;
        }

        public static void Disconnect(SerialPort serialPort)
        {
            if (serialPort == null) return;
            serialPort.WriteLine(ArduinoAction.RED_OFF);
            serialPort.WriteLine(ArduinoAction.GREEN_OFF);
            serialPort.WriteLine(ArduinoAction.BARIE_CLOSE);
            serialPort.Close();
        }

        public static void OpenBarrier(SerialPort serialPort)
        {
            if (serialPort == null) return;
            using (SoundPlayer player = new SoundPlayer("../../Resource/enter.wav"))
            {
                player.Play();
            }
            serialPort.WriteLine(ArduinoAction.RED_OFF);
            serialPort.WriteLine(ArduinoAction.GREEN_ON);
            serialPort.WriteLine(ArduinoAction.BARIE_OPEN);
        }

        public static void CloseBarrier(SerialPort serialPort)
        {
            if (serialPort == null) return;
            serialPort.WriteLine(ArduinoAction.GREEN_OFF);
            serialPort.WriteLine(ArduinoAction.BARIE_CLOSE);
            serialPort.WriteLine(ArduinoAction.RED_ON);
        }
        public static void DoAction(SerialPort serialPort, string action)
        {
            serialPort.WriteLine(action);
        }
    }
}
