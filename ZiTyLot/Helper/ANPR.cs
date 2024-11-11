using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Text;
using System.Linq;
using Newtonsoft.Json;

namespace ZiTyLot.Helper
{
    public static class ANPR
    {
        private const string LPR_ENDPOINT_NAME = "LPD_Endpoint";
        private const string LP_OCR_ENDPOINT_NAME = "LP_OCR_Endpoint";

        #region Models
        private class PlateDetectionResult
        {
            public string inference_id { get; set; }
            public double time { get; set; }
            public ImageInfo image { get; set; }
            public List<Prediction> predictions { get; set; }
        }

        private class OcrResult
        {
            public List<OcrPrediction> predictions { get; set; }
        }

        private class ImageInfo
        {
            public int width { get; set; }
            public int height { get; set; }
        }

        private class Prediction
        {
            public double x { get; set; }
            public double y { get; set; }
            public double width { get; set; }
            public double height { get; set; }
            public double confidence { get; set; }
            public string @class { get; set; }
            public int class_id { get; set; }
            public string detection_id { get; set; }
        }

        private class OcrPrediction
        {
            public double x { get; set; }
            public double y { get; set; }
            public double width { get; set; }
            public double height { get; set; }
            public double confidence { get; set; }
            public string @class { get; set; }
            public int class_id { get; set; }
            public string detection_id { get; set; }
        }

        public class PlateResult
        {
            public string ImagePath { get; set; }
            public string PlateNumber { get; set; }
            public double Confidence { get; set; }
        }
        #endregion


        public static PlateResult ProcessImage(string imagePath, string outputDirectory)
        {
            try
            {
                //check output directory is exist
                if (!Directory.Exists(outputDirectory))
                {
                    throw new DirectoryNotFoundException("Output directory not found");
                }
                // Detect license plates
                string detectionResult = InferenceLocal(imagePath, LPR_ENDPOINT_NAME);

                // If error occurred during detection
                if (detectionResult.StartsWith("Error:"))
                {
                    Console.WriteLine(detectionResult);
                    return null; ;
                }

                // Extract the license plates and perform OCR
                return ProcessDetectedPlates(imagePath, detectionResult, outputDirectory);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing image: {ex.Message}");
                return null;
            }
        }

        private static string InferenceLocal(string imagePath, string modelName)
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

                byte[] imageArray = File.ReadAllBytes(imagePath);
                string encoded = Convert.ToBase64String(imageArray);
                byte[] data = Encoding.ASCII.GetBytes(encoded);

                string fullUploadURL = $"{uploadURL}/{modelEndpoint}?api_key={apiKey}&name={Path.GetFileName(imagePath)}";

                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                WebRequest request = WebRequest.Create(fullUploadURL);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                using (WebResponse response = request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader sr = new StreamReader(stream))
                {
                    return sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        private static PlateResult ProcessDetectedPlates(string originalImagePath, string detectionJson, string outputDirectory)
        {
            try
            {
                var detectionResult = JsonConvert.DeserializeObject<PlateDetectionResult>(detectionJson);
                if (detectionResult?.predictions == null || detectionResult.predictions.Count == 0)
                {
                    throw new Exception("No license plate detected in the result");
                }

                if (!Directory.Exists(outputDirectory))
                {
                    Directory.CreateDirectory(outputDirectory);
                }

                using (var image = Image.FromFile(originalImagePath))
                {
                    foreach (var prediction in detectionResult.predictions)
                    {
                        // Calculate crop coordinates with padding
                        int x = (int)(prediction.x - (prediction.width / 2));
                        int y = (int)(prediction.y - (prediction.height / 2));
                        int width = (int)prediction.width;
                        int height = (int)prediction.height;

                        // Ensure coordinates are within image bounds
                        x = Math.Max(0, x);
                        y = Math.Max(0, y);
                        width = Math.Min(width, image.Width - x);
                        height = Math.Min(height, image.Height - y);

                        // Add padding
                        int paddingX = (int)(width * 0.1);
                        int paddingY = (int)(height * 0.1);

                        x = Math.Max(0, x - paddingX);
                        y = Math.Max(0, y - paddingY);
                        width = Math.Min(width + (paddingX * 2), image.Width - x);
                        height = Math.Min(height + (paddingY * 2), image.Height - y);

                        Rectangle cropArea = new Rectangle(x, y, width, height);

                        using (Bitmap bmp = new Bitmap(image))
                        using (Bitmap cropBmp = bmp.Clone(cropArea, bmp.PixelFormat))
                        {
                            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                            string confidence = (prediction.confidence * 100).ToString("0.00");
                            string outputPath = Path.Combine(outputDirectory,
                                $"license_plate_{timestamp}_conf{confidence}.jpg");

                            cropBmp.Save(outputPath, ImageFormat.Jpeg);

                            // Perform OCR on the cropped plate
                            string ocrResult = InferenceLocal(outputPath, LP_OCR_ENDPOINT_NAME);
                            if (!ocrResult.StartsWith("Error:"))
                            {
                                var plateNumber = ExtractPlateNumber(ocrResult);
                                return new PlateResult
                                {
                                    ImagePath = outputPath,
                                    PlateNumber = plateNumber.number,
                                    Confidence = plateNumber.confidence
                                };
                            }
                            else
                            {
                                Console.WriteLine($"OCR Error for {outputPath}: {ocrResult}");
                            }
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

        private static (string number, double confidence) ExtractPlateNumber(string ocrJson)
        {
            try
            {
                var ocrResult = JsonConvert.DeserializeObject<OcrResult>(ocrJson);
                if (ocrResult?.predictions == null || ocrResult.predictions.Count == 0)
                {
                    return ("", 0);
                }

                // Tìm chiều cao trung bình của các ký tự
                double avgHeight = ocrResult.predictions.Average(p => p.height);

                // Nhóm các ký tự thành các hàng dựa trên tọa độ y
                // Các ký tự được coi là cùng hàng nếu khoảng cách y giữa chúng nhỏ hơn 1/2 chiều cao trung bình
                var rows = new List<List<OcrPrediction>>();

                foreach (var pred in ocrResult.predictions)
                {
                    bool addedToExistingRow = false;
                    foreach (var row in rows)
                    {
                        double rowY = row[0].y;
                        if (Math.Abs(pred.y - rowY) < avgHeight / 2)
                        {
                            row.Add(pred);
                            addedToExistingRow = true;
                            break;
                        }
                    }

                    if (!addedToExistingRow)
                    {
                        rows.Add(new List<OcrPrediction> { pred });
                    }
                }

                // Sắp xếp các hàng theo tọa độ y (từ trên xuống)
                rows = rows.OrderBy(row => row[0].y).ToList();

                // Trong mỗi hàng, sắp xếp các ký tự từ trái sang phải
                StringBuilder plateNumber = new StringBuilder();
                double totalConfidence = 0;
                int totalChars = 0;

                foreach (var row in rows)
                {
                    var sortedRow = row.OrderBy(p => p.x).ToList();
                    foreach (var char_pred in sortedRow)
                    {
                        plateNumber.Append(char_pred.@class);
                        totalConfidence += char_pred.confidence;
                        totalChars++;
                    }
                }

                double avgConfidence = (totalConfidence / totalChars) * 100;

                return (plateNumber.ToString(), avgConfidence);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error extracting plate number: {ex.Message}");
                return ("", 0);
            }
        }
    }
}