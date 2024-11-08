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
            Application.Run(new Home());
        }
    }
}
