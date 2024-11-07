using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZiTyLot.BUS;
using ZiTyLot.Config;
using ZiTyLot.Constants.Enum;
using ZiTyLot.ENTITY;
using ZiTyLot.Helper;
using ZiTyLot.GUI;
using ZiTyLot.GUI.Utils;
namespace ZiTyLot
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //ANPR.Test();
            try
            {
                using (var connection = DBConfig.GetConnection())
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Home());


            StatisticBUS statisticBUS = new StatisticBUS();
            string[] inputs = {
                    "2024-10-04 to 2024-11-07",
                    "2024-03 to 2025-12",
                    "2001 to 2025"
            };

            foreach (string input in inputs)
            {
                try
                {
                    Console.WriteLine($"\nProcessing date range: {input}");
                    var statistics = statisticBUS.GetRevenueStatistics(input);

                    foreach (var stat in statistics)
                    {
                        Console.WriteLine($"Period: {stat.Period}, Total Amount: {stat.TotalAmount}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected Error: {ex.Message}");
                }
            }
        }
    }
}
