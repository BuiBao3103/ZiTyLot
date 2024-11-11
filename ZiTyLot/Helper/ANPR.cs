using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace ZiTyLot.Helper
{
    public static class ANPR
    {
        private const string LPR_ENDPOINT_NAME = "LPD_Endpoint";
        private const string LP_OCR_ENDPOINT_NAME = "LP_OCR_Endpoint";
        private static readonly HttpClient httpClient;

        static ANPR()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.ConnectionClose = false; // Enable connection reuse
            ServicePointManager.DefaultConnectionLimit = 10; // Increase concurrent connection limit
        }

        #region Models
        private class PlateDetectionResult
        {
            public List<Prediction> predictions { get; set; }
        }

        private class OcrResult
        {
            public List<OcrPrediction> predictions { get; set; }
        }

        private class Prediction
        {
            public double x { get; set; }
            public double y { get; set; }
            public double width { get; set; }
            public double height { get; set; }
        }

        private class OcrPrediction
        {
            public double x { get; set; }
            public double y { get; set; }
            public double height { get; set; }
            public double confidence { get; set; }
            public string @class { get; set; }
            public int class_id { get; set; }
            public string detection_id { get; set; }
        }

        public class PlateResult
        {
            public Image Image { get; set; }
            public string PlateNumber { get; set; }
            public double Confidence { get; set; }
        }
        #endregion

        public static async Task<PlateResult> ProcessImageAsync(Image imagePlate)
        {
            try
            {
                // Đọc file và chuyển thành base64
                byte[] imageBytes = null;
                using (var memoryStream = new MemoryStream())
                {
                    imagePlate.Save(memoryStream, ImageFormat.Jpeg);
                    imageBytes = memoryStream.ToArray();
                }
                string base64Image = Convert.ToBase64String(imageBytes);

                // Thực hiện detect plate
                string detectionResult = await InferenceLocalAsync(base64Image, LPR_ENDPOINT_NAME);
                if (detectionResult.StartsWith("Error:"))
                {
                    Console.WriteLine(detectionResult);
                    return null;
                }

                // Xử lý ảnh trong memory
                using (var memoryStream = new MemoryStream(imageBytes))
                {
                    using (var image = Image.FromStream(memoryStream))
                    {
                        return await ProcessDetectedPlatesAsync(image, detectionResult);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing image: {ex.Message}");
                return null;
            }
        }

        private static async Task<string> InferenceLocalAsync(string base64Image, string modelName)
        {
            try
            {
                string apiKey = ConfigurationManager.AppSettings["ApiKey"];
                string uploadURL = ConfigurationManager.AppSettings["RoboflowEndpoint"];
                string modelEndpoint = ConfigurationManager.AppSettings[modelName];

                if (string.IsNullOrEmpty(modelEndpoint))
                {
                    throw new Exception($"Model endpoint not found for {modelName}");
                }

                string fullUploadURL = $"{uploadURL}/{modelEndpoint}?api_key={apiKey}";

                var content = new StringContent(base64Image, Encoding.ASCII, "application/x-www-form-urlencoded");
                var response = await httpClient.PostAsync(fullUploadURL, content);
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        private static async Task<PlateResult> ProcessDetectedPlatesAsync(Image originalImage, string detectionJson)
        {
            try
            {
                var detectionResult = JsonConvert.DeserializeObject<PlateDetectionResult>(detectionJson);
                if (detectionResult?.predictions == null || !detectionResult.predictions.Any())
                {
                    throw new Exception("No license plate detected in the result");
                }

                foreach (var prediction in detectionResult.predictions)
                {
                    // Tính toán vùng cắt với padding
                    var cropArea = CalculateCropArea(prediction, originalImage.Width, originalImage.Height);

                    using (var memStream = new MemoryStream())
                    {
                        using (Bitmap bmp = new Bitmap(originalImage))
                        using (Bitmap cropBmp = bmp.Clone(cropArea, bmp.PixelFormat))
                        {
                            cropBmp.Save(memStream, ImageFormat.Jpeg);
                        }

                        // Convert to base64 và gọi OCR API
                        string base64Crop = Convert.ToBase64String(memStream.ToArray());
                        string ocrResult = await InferenceLocalAsync(base64Crop, LP_OCR_ENDPOINT_NAME);

                        if (!ocrResult.StartsWith("Error:"))
                        {
                            var plateInfo = ExtractPlateNumber(ocrResult);



                            return new PlateResult
                            {
                                Image = Image.FromStream(memStream),
                                PlateNumber = plateInfo.Item1,
                                Confidence = plateInfo.Item2
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing plates: {ex.Message}");
            }

            return null;
        }
        private static Rectangle CalculateCropArea(Prediction prediction, int imageWidth, int imageHeight)
        {
            int x = (int)(prediction.x - (prediction.width / 2));
            int y = (int)(prediction.y - (prediction.height / 2));
            int width = (int)prediction.width;
            int height = (int)prediction.height;

            // Adjust bounds
            x = Math.Max(0, x);
            y = Math.Max(0, y);
            width = Math.Min(width, imageWidth - x);
            height = Math.Min(height, imageHeight - y);

            // Add padding
            int paddingX = (int)(width * 0.1);
            int paddingY = (int)(height * 0.1);

            x = Math.Max(0, x - paddingX);
            y = Math.Max(0, y - paddingY);
            width = Math.Min(width + (paddingX * 2), imageWidth - x);
            height = Math.Min(height + (paddingY * 2), imageHeight - y);

            return new Rectangle(x, y, width, height);
        }

        private static string GetOutputFilePath(string outputDirectory, double confidence)
        {
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string confidenceStr = (confidence * 100).ToString("0.00");
            return Path.Combine(outputDirectory, $"license_plate_{timestamp}_conf{confidenceStr}.jpg");
        }

        private static Tuple<string, double> ExtractPlateNumber(string ocrJson)
        {
            try
            {
                var ocrResult = JsonConvert.DeserializeObject<OcrResult>(ocrJson);
                if (ocrResult?.predictions == null || !ocrResult.predictions.Any())
                {
                    return Tuple.Create(string.Empty, 0.0);
                }

                var predictions = ocrResult.predictions;
                double avgHeight = predictions.Average(p => p.height);

                // Group characters by rows
                var rows = predictions
                    .GroupBy(p => (int)(p.y / (avgHeight / 2)))
                    .OrderBy(g => g.Key)
                    .Select(g => g.OrderBy(p => p.x).ToList())
                    .ToList();

                // Build plate number
                var plateBuilder = new StringBuilder();
                foreach (var row in rows)
                {
                    foreach (var pred in row)
                    {
                        plateBuilder.Append(pred.@class);
                    }
                }

                double avgConfidence = predictions.Average(p => p.confidence) * 100;
                return Tuple.Create(plateBuilder.ToString(), avgConfidence);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error extracting plate number: {ex.Message}");
                return Tuple.Create(string.Empty, 0.0);
            }
        }
    }
}