using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiTyLot.Config;
using ZiTyLot.ENTITY;

namespace ZiTyLot.DAO
{
    internal class StatisticDAO
    {
        public List<RevenueStatistic> GetRevenueStatistics(DateTime startDate, DateTime endDate, string groupingType)
        {
            List<RevenueStatistic> result = new List<RevenueStatistic>();

            string dateFormat;
            string periodFormat;

            switch (groupingType.ToUpper())
            {
                case "MONTH":
                    dateFormat = "DATE_FORMAT(datetime_column, '%Y-%m')";
                    periodFormat = "yyyy-MM";
                    break;
                case "YEAR":
                    dateFormat = "DATE_FORMAT(datetime_column, '%Y')";
                    periodFormat = "yyyy";
                    break;
                case "DAY":
                default:
                    dateFormat = "DATE(datetime_column)";
                    periodFormat = "yyyy-MM-dd";
                    break;
            }

            string query = $@"
                SELECT 
                    {dateFormat} AS period,
                    SUM(amount_column) AS total_amount
                FROM 
                    your_table
                WHERE 
                    datetime_column BETWEEN @startDate AND @endDate
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
                        command.Parameters.AddWithValue("@endDate", endDate);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string periodRaw = reader.GetString("period");
                                decimal totalAmount = reader.GetDecimal("total_amount");

                                DateTime parsedPeriod = DateTime.Parse(periodRaw);
                                string formattedPeriod = parsedPeriod.ToString(periodFormat);

                                result.Add(new RevenueStatistic(formattedPeriod, totalAmount));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}
