namespace ZiTyLot.Config
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Configuration;

    public static class DBConfig
    {
        public static MySqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Database connection string is not set properly in the app.config.");
            }

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open(); // Attempt to open the connection to verify it
            return connection;
        }
    }
}
