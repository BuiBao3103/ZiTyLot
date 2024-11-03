using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ZiTyLot.Helper
{
    public class ANPR
    {
        const string LPR_ENDPOINT_NAME = "LPD_Endpoint";
        const string LP_OCR_ENDPOINT_NAME = "LP_OCR_Endpoint";
        public static string InferenceLocal(string imagePath, string modelName)
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

                // Construct the full URL
                string fullUploadURL = $"{uploadURL}/{modelEndpoint}?api_key={apiKey}&name={Path.GetFileName(imagePath)}";

                // Service Request Config
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                // Configure Request
                WebRequest request = WebRequest.Create(fullUploadURL);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                // Write Data
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                // Get Response
                string responseContent = null;
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader sr = new StreamReader(stream))
                        {
                            responseContent = sr.ReadToEnd();
                        }
                    }
                }

                return responseContent;
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
        public static void test()
        {
            string imagePath = @"../../Helper/images/car.jpg";

            // Example usage: calling with different model names
            string result1 = InferenceLocal(imagePath, LPR_ENDPOINT_NAME);
            Console.WriteLine("License Plate Recognition Result:");
            Console.WriteLine(result1);

            //string result2 = InferenceLocal(imagePath, L_OCR_ENDPOINT_NAME);
            //Console.WriteLine("\nLicense OCR Result:");
            //Console.WriteLine(result2);
        }
    }
}
