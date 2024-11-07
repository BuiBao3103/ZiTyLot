using MySql.Data.MySqlClient;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using ZiTyLot.Config;
using ZiTyLot.ENTITY;

namespace ZiTyLot.DAO
{
    public class StatisticDAO
    {
        public List<RevenueStatistic> GetRevenueStatistics(DateTime startDate, DateTime endDate, string groupingType)
        {
            Console.WriteLine($"Processing date range: {startDate} to {endDate}, type: {groupingType}");
            var (dateFormat, periodFormat) = GetDateFormatAndPeriodFormat(groupingType, "bills");

            var residentData = GetResidentRevenueData(startDate, endDate, groupingType);
            var visitorData = GetVisitorRevenueData(startDate, endDate, groupingType);

            var result = new List<RevenueStatistic>();
            result.AddRange(residentData);
            result.AddRange(visitorData);

            result.Sort((a, b) => DateTime.ParseExact(a.Period, periodFormat, CultureInfo.InvariantCulture)
                .CompareTo(DateTime.ParseExact(b.Period, periodFormat, CultureInfo.InvariantCulture)));

            return result;
        }

        private (string, string) GetDateFormatAndPeriodFormat(string groupingType, string source)
        {
            string dateFormat;
            string periodFormat;
            switch (groupingType.ToUpper())
            {
                case "MONTH":
                    if (source == "sessions")
                        dateFormat = "DATE_FORMAT(DATE(checkout_time), '%Y-%m')";
                    else
                        dateFormat = "DATE_FORMAT(DATE(created_at), '%Y-%m')";
                    periodFormat = "yyyy-MM";
                    break;
                case "YEAR":
                    if (source == "sessions")
                        dateFormat = "DATE_FORMAT(DATE(checkout_time), '%Y')";
                    else
                        dateFormat = "DATE_FORMAT(DATE(created_at), '%Y')";
                    periodFormat = "yyyy";
                    break;
                case "DAY":
                default:
                    if (source == "sessions")
                        dateFormat = "DATE_FORMAT(DATE(checkout_time), '%Y-%m-%d')";
                    else
                        dateFormat = "DATE_FORMAT(DATE(created_at), '%Y-%m-%d')";
                    periodFormat = "yyyy-MM-dd";
                    break;
            }
            return (dateFormat, periodFormat);
        }

        private List<RevenueStatistic> GetResidentRevenueData(DateTime startDate, DateTime endDate, string groupingType)
        {
            var (dateFormat, periodFormat) = GetDateFormatAndPeriodFormat(groupingType, "bills");
            List<RevenueStatistic> result = new List<RevenueStatistic>();
            string billsQuery = $@"
        SELECT 
            {dateFormat} AS period,
            SUM(total_fee) AS resident_amount
        FROM 
            bills
        WHERE 
            created_at BETWEEN @startDate AND @endDate
        GROUP BY 
            period
        ORDER BY 
            period;";

            using (var connection = DBConfig.GetConnection())
            {
                connection.Open();
                using (var billsCommand = new MySqlCommand(billsQuery, connection))
                {
                    billsCommand.Parameters.AddWithValue("@startDate", startDate);
                    billsCommand.Parameters.AddWithValue("@endDate", endDate.AddDays(1).ToUniversalTime());
                    using (var billsReader = billsCommand.ExecuteReader())
                    {
                        while (billsReader.Read())
                        {
                            string periodString = billsReader.GetString("period");
                            decimal residentAmount = billsReader.GetDecimal("resident_amount");
                            result.Add(new RevenueStatistic(periodString, residentAmount, 0));
                        }
                    }
                }
            }
            return result;
        }

        private List<RevenueStatistic> GetVisitorRevenueData(DateTime startDate, DateTime endDate, string groupingType)
        {
            var (dateFormat, periodFormat) = GetDateFormatAndPeriodFormat(groupingType, "sessions");
            List<RevenueStatistic> result = new List<RevenueStatistic>();
            string sessionsQuery = $@"
        SELECT 
            {dateFormat} AS period,
            SUM(fee) AS visitor_amount
        FROM 
            sessions
        WHERE 
            checkout_time BETWEEN @startDate AND @endDate AND type = 'VISITOR'
        GROUP BY 
            period
        ORDER BY 
            period;";

            using (var connection = DBConfig.GetConnection())
            {
                connection.Open();
                using (var sessionsCommand = new MySqlCommand(sessionsQuery, connection))
                {
                    sessionsCommand.Parameters.AddWithValue("@startDate", startDate);
                    sessionsCommand.Parameters.AddWithValue("@endDate", endDate.AddDays(1).ToUniversalTime());
                    using (var sessionsReader = sessionsCommand.ExecuteReader())
                    {
                        while (sessionsReader.Read())
                        {
                            string periodString = sessionsReader.GetString("period");
                            decimal visitorAmount = sessionsReader.GetDecimal("visitor_amount");
                            result.Add(new RevenueStatistic(periodString, 0, visitorAmount));
                        }
                    }
                }
            }
            return result;
        }
    }
}
