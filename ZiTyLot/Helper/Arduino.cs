using System;
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
            serialPort.WriteLine(ArduinoAction.BARIE_CLOSE);
            serialPort.WriteLine(ArduinoAction.RED_OFF);
            serialPort.WriteLine(ArduinoAction.GREEN_OFF);
            System.Threading.Thread.Sleep(500);
            serialPort.Close();
        }

        public static void OpenBarrier(SerialPort serialPort)
        {
            if (serialPort == null) return;
            int random = new Random().Next(1, 5);
            if (random == 1)
            {
                using (SoundPlayer player = new SoundPlayer("../../Resource/AmongUs.wav"))
                {
                    player.Play();
                }
            }
            else
            {
                using (SoundPlayer player = new SoundPlayer("../../Resource/enter.wav"))
                {
                    player.Play();
                }
            }
            System.Threading.Thread.Sleep(1000);
           
            serialPort.WriteLine(ArduinoAction.RED_OFF);
            serialPort.WriteLine(ArduinoAction.GREEN_ON);
            serialPort.WriteLine(ArduinoAction.BARIE_OPEN);
        }

        public static void CloseBarrier(SerialPort serialPort)
        {
            if (serialPort == null) return;
            serialPort.WriteLine(ArduinoAction.GREEN_OFF);
            serialPort.WriteLine(ArduinoAction.RED_ON);
            serialPort.WriteLine(ArduinoAction.BARIE_CLOSE);
            System.Threading.Thread.Sleep(500);
        }
        public static void DoAction(SerialPort serialPort, string action)
        {
            serialPort.WriteLine(action);
        }
    }
}
