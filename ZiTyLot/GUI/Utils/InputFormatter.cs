using System.Windows.Forms;

namespace ZiTyLot.GUI.Utils
{ 
    public static class InputFormatter
    {
        public static string FormatNumericText(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            string cleanText = text.Replace(",", "");
            if (int.TryParse(cleanText, out int number))
            {
                return string.Format("{0:#,##0}", number);
            }

            return text;
        }

        public static string GetRawNumericValue(string formattedText)
        {
            return formattedText?.Replace(",", "") ?? string.Empty;
        }
    }

}
