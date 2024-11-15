using NAudio.Wave;
using System;
using System.IO;
using System.IO.Ports;
using System.Media;
using System.Speech.Synthesis;
using System.Threading;
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

        public static void OpenBarrier(SerialPort serialPort, bool isCheckin)
        {
            if (serialPort == null) return;

            string soundFilePath = isCheckin ? "../../Resource/sound/checkin.mp3" : "../../Resource/sound/checkout.mp3";

            PlaySound(soundFilePath);


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

        private static void PlaySound(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Sound file not found: {filePath}");
                return;
            }

            try
            {
                using (var audioFile = new AudioFileReader(filePath))
                using (var outputDevice = new WaveOutEvent())
                {
                    outputDevice.Init(audioFile);
                    outputDevice.Play(); 
                    while (outputDevice.PlaybackState == PlaybackState.Playing)
                    {
                        System.Threading.Thread.Sleep(100);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error playing sound: {ex.Message}");
            }
        }
    }
}
