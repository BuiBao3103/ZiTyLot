using System;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ZiTyLot.Helper
{
    public static class ImageHelper
    {
        //private static readonly string IMAGE_DIRECTORY = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
        private static readonly string IMAGE_DIRECTORY = ConfigurationManager.AppSettings["ImagePath"] ?? throw new ArgumentNullException("ImagePath not found in App.config");

        static ImageHelper()
        {
            if (!Directory.Exists(IMAGE_DIRECTORY))
            {
                Directory.CreateDirectory(IMAGE_DIRECTORY);
            }
        }
        public static string SaveImage(Image image)
        {
            try
            {
                if (image == null)
                    throw new ArgumentNullException(nameof(image));

                // Tạo tên file duy nhất dựa trên timestamp
                string fileName = $"img_{DateTime.Now:yyyyMMdd_HHmmss}_{Guid.NewGuid().ToString().Substring(0, 8)}.jpg";
                string fullPath = Path.Combine(IMAGE_DIRECTORY, fileName);

                // Lưu ảnh với định dạng JPEG
                using (var bitmap = new Bitmap(image))
                {
                    bitmap.Save(fullPath, ImageFormat.Jpeg);
                }

                return fullPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static Image LoadImage(string imagePath)
        {
            try
            {
                if (string.IsNullOrEmpty(imagePath))
                    throw new ArgumentNullException(nameof(imagePath));

                if (!File.Exists(imagePath))
                    throw new FileNotFoundException("Image file not found", imagePath);

                // Tải và trả về ảnh
                return Image.FromFile(imagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static bool DeleteImage(string imagePath)
        {
            try
            {
                if (string.IsNullOrEmpty(imagePath))
                    return false;

                if (File.Exists(imagePath))
                {
                    File.Delete(imagePath);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static string GetImageDirectory()
        {
            return IMAGE_DIRECTORY;
        }

        public static void ClearImageDirectory()
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(IMAGE_DIRECTORY);
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clearing image directory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}