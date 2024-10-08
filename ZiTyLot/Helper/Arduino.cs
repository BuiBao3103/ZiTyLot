using System.IO.Ports;

namespace ZiTyLot.Helper
{
    public static class Arduino
    {
        private const int BAUD_RATE = 9600;
        public static SerialPort Connect(string portName)
        {
            SerialPort serialPort = new SerialPort(portName, BAUD_RATE);
            serialPort.Open();
            return serialPort;
        }
        public static void DoAction(SerialPort serialPort, string action)
        {
            if (serialPort == null)
                return;
            serialPort.WriteLine(action);

        }
    }
}
