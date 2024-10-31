    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace ZiTyLot.GUI.component_extensions
    {
        public static class InputValidator
        {
            public static bool ValidateNumericKeyPress(string currentText, char keyChar, int maxDigits = 9)
            {
                // Block non-digit and non-control characters
                if (!char.IsControl(keyChar) && !char.IsDigit(keyChar))
                {
                    return true;
                }

                // Block leading zero
                if (string.IsNullOrEmpty(currentText) && keyChar == '0')
                {
                    return true;
                }

                // Block if exceeding maximum digits
                if (currentText.Replace(",", "").Length >= maxDigits && !char.IsControl(keyChar))
                {
                    return true;
                }

                return false;
            }
        }

    }
