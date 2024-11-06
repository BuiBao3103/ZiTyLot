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

           public static bool ValidateEmail(string email)
           {
               if (string.IsNullOrEmpty(email))
               {
                   return false;
               }
               return System.Text.RegularExpressions.Regex.IsMatch(email,
                   @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
           }

            public static bool ValidatePhoneNumber(string phone)
              {
                if (string.IsNullOrEmpty(phone))
                {
                     return false;
                }
                return System.Text.RegularExpressions.Regex.IsMatch(phone,
                     @"^0(3|5|7|8|9)\d{8}$");
              }

            public static bool ValidateRfid(string rfid)
            {
                if (string.IsNullOrEmpty(rfid))
                {
                    return false;
                }
                return System.Text.RegularExpressions.Regex.IsMatch(rfid,
                    @"^([0-9]{10})$");
            }

            public static bool ValidateNationalId(string nationalId)
            {
                if (string.IsNullOrEmpty(nationalId))
                {
                    return false;
                }
                return System.Text.RegularExpressions.Regex.IsMatch(nationalId,
                    @"^([0-9]{12})$");
            }

           
        }

    }
