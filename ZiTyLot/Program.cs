using System;
using System.Windows.Forms;
using ZiTyLot.Config;
using ZiTyLot.GUI;
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
