namespace ZiTyLot
{
    using System;
    using System.Windows.Forms;
    using ZiTyLot.Config;

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Attempt to connect to the database and fetch data using MyDao
            try
            {
                var connection = DBConfig.GetConnection();
                if (connection == null)
                {
                    MessageBox.Show("Database connection failed: connection is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Terminate the application
            }

            // Start the main form of the application
            //Application.Run(new Form1());
        }
    }
}
