using System;
using System.Diagnostics;

namespace ZiTyLot.Helper
{
    public class RFIDReader
    {
        private string currentInput = "";
        private const int RFIDLength = 10;
        private Stopwatch inputStopwatch = new Stopwatch();
        private const int MaxInputTimeMs = 100;

        public event EventHandler<string> RFIDScanned;

        public void ProcessInput(char inputChar)
        {
            if (char.IsDigit(inputChar))
            {
                if (currentInput.Length == 0)
                {
                    inputStopwatch.Restart();
                }
                else if (inputStopwatch.ElapsedMilliseconds > MaxInputTimeMs)
                {
                    ResetInput();
                }

                currentInput += inputChar;
                if (currentInput.Length > RFIDLength)
                {
                    currentInput = currentInput.Substring(currentInput.Length - RFIDLength);
                }
            }
            else if (inputChar == (char)13) // Kiểm tra ký tự Enter
            {
                // Xử lý khi nhận được Enter
                if (currentInput.Length == RFIDLength && inputStopwatch.ElapsedMilliseconds <= MaxInputTimeMs)
                {
                    // Gọi sự kiện nếu chuỗi hợp lệ
                    OnRFIDScanned(currentInput);
                }
                ResetInput();
            }
            else
            {
                ResetInput(); // Reset nếu ký tự không hợp lệ
            }
        }

        private void ResetInput()
        {
            currentInput = "";
            inputStopwatch.Stop();
        }

        protected virtual void OnRFIDScanned(string rfidCode)
        {
            // Loại bỏ các ký tự không hợp lệ (nếu cần)
            rfidCode = rfidCode.Trim(); // Loại bỏ khoảng trắng, ký tự mới dòng

            if (!string.IsNullOrEmpty(rfidCode))
            {
                RFIDScanned?.Invoke(this, rfidCode);
            }
        }
    }
}
