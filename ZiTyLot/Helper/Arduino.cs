using System.IO.Ports;

namespace ZiTyLot.Helper
{
    public static class Arduino
    {
        public static SerialPort Connect(string portName)
        {
            SerialPort serialPort = new SerialPort(portName, 9600);
            serialPort.Open();
            return serialPort;
        }
        public static void DoAction(SerialPort serialPort, string action)
        {
           serialPort.WriteLine(action);
        }
    }
}
