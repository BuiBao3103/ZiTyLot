using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using ZiTyLot.Config;
using ZiTyLot.ENTITY;

namespace ZiTyLot.DAO
{
    public class StatisticDAO
    {
        public List<RevenueStatistic> GetRevenueStatistics(DateTime startDate, DateTime endDate, string groupingType)
        {
            List<RevenueStatistic> result = new List<RevenueStatistic>();
            Console.WriteLine($"Processing date range: {startDate} to {endDate}, type: {groupingType}");

            string dateFormat;
            string periodFormat;
            switch (groupingType.ToUpper())
            {
                case "MONTH":
                    dateFormat = "DATE_FORMAT(DATE(created_at), '%Y-%m')";
                    periodFormat = "yyyy-MM";
                    break;
                case "YEAR":
                    dateFormat = "DATE_FORMAT(DATE(created_at), '%Y')";
                    periodFormat = "yyyy";
                    break;
                case "DAY":
                default:
                    dateFormat = "DATE_FORMAT(DATE(created_at), '%Y-%m-%d')"; // Changed this line
                    periodFormat = "yyyy-MM-dd";
                    break;
            }

            string query = $@"
                    SELECT 
                        {dateFormat} AS period,
                        SUM(total_fee) AS total_amount
                    FROM 
                        bills
                    WHERE 
                        created_at BETWEEN @startDate AND @endDate
                    GROUP BY 
                        period
                    ORDER BY 
                        period;";

            try
            {
                using (var connection = DBConfig.GetConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@endDate", endDate.AddDays(1));
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string periodString = reader.GetString("period");
                                decimal totalAmount = reader.GetDecimal("total_amount");
                                result.Add(new RevenueStatistic(periodString, totalAmount));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            return result;
        }

    }
}
