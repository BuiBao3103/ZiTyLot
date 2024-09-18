using MySql.Data.MySqlClient;
using System;
using System.Configuration;
namespace ZiTyLot.Config
{
   

    public static class DBConfig
    {
        public static MySqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Database connection string is not set properly in the app.config.");
            }

            return new MySqlConnection(connectionString);
        }
    }
}
