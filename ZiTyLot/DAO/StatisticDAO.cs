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
        private const int CAR_ID = 1;
        private const int BIKECYCLE_ID = 2;
        private const int MOTORBIKE_ID = 3;

        public List<RevenueStatistic> GetRevenueStatistics(DateTime startDate, DateTime endDate, string groupingType)
        {
            Console.WriteLine($"Processing date range: {startDate} to {endDate}, type: {groupingType}");
            var (dateFormat, periodFormat) = GetDateFormatAndPeriodFormat(groupingType, "bills");

            var residentData = GetResidentRevenueData(startDate, endDate, groupingType);
            var visitorData = GetVisitorRevenueData(startDate, endDate, groupingType);


            List<RevenueStatistic> result = new List<RevenueStatistic>();
            foreach (var resident in residentData)
            {
                var visitor = visitorData.Find(v => v.Period == resident.Period);
                if (visitor == null)
                {
                    result.Add(new RevenueStatistic
                    {
                        Period = resident.Period,
                        ResidentAmount = resident.ResidentAmount,
                        VisitorAmount = 0
                    });
                }
                else
                {
                    result.Add(new RevenueStatistic
                    {
                        Period = resident.Period,
                        ResidentAmount = resident.ResidentAmount,
                        VisitorAmount = visitor.VisitorAmount
                    });
                    visitorData.Remove(visitor);
                }
            }
            foreach (var visitor in visitorData)
            {
                result.Add(new RevenueStatistic
                {
                    Period = visitor.Period,
                    ResidentAmount = 0,
                    VisitorAmount = visitor.VisitorAmount
                });
            }
            result.Sort((a, b) => DateTime.ParseExact(a.Period, periodFormat, CultureInfo.InvariantCulture)
                .CompareTo(DateTime.ParseExact(b.Period, periodFormat, CultureInfo.InvariantCulture)));
            return result;
        }
        public List<SessionStatistic> GetSessionStatistics(DateTime startDate, DateTime endDate, string groupingType)
        {
            Console.WriteLine($"Processing date range: {startDate} to {endDate}, type: {groupingType}");
            var (dateFormat, periodFormat) = GetDateFormatAndPeriodFormat(groupingType, "sessions");

            var carData = GetVehicleData(startDate, endDate, groupingType, CAR_ID);
            var motorbikeData = GetVehicleData(startDate, endDate, groupingType, MOTORBIKE_ID);
            var bikecycleData = GetVehicleData(startDate, endDate, groupingType, BIKECYCLE_ID);

            List<SessionStatistic> result = new List<SessionStatistic>();
            foreach (var car in carData)
            {
                var motorbike = motorbikeData.Find(v => v.Period == car.Period);
                var bikecycle = bikecycleData.Find(v => v.Period == car.Period);
                if (motorbike == null)
                {
                    motorbike = new SessionStatistic
                    {
                        Period = car.Period,
                        CountMotorbike = 0,
                        CountCar = 0,
                        CountBikecycle = 0
                    };
                }
                if (bikecycle == null)
                {
                    bikecycle = new SessionStatistic
                    {
                        Period = car.Period,
                        CountMotorbike = 0,
                        CountCar = 0,
                        CountBikecycle = 0
                    };
                }
                result.Add(new SessionStatistic
                {
                    Period = car.Period,
                    CountCar = car.CountCar,
                    CountMotorbike = motorbike.CountMotorbike,
                    CountBikecycle = bikecycle.CountBikecycle
                });
                motorbikeData.Remove(motorbike);
                bikecycleData.Remove(bikecycle);
            }
            foreach (var motorbike in motorbikeData)
            {
                var bikecycle = bikecycleData.Find(v => v.Period == motorbike.Period);
                if (bikecycle == null)
                {
                    bikecycle = new SessionStatistic
                    {
                        Period = motorbike.Period,
                        CountMotorbike = 0,
                        CountCar = 0,
                        CountBikecycle = 0
                    };
                }
                result.Add(new SessionStatistic
                {
                    Period = motorbike.Period,
                    CountCar = 0,
                    CountMotorbike = motorbike.CountMotorbike,
                    CountBikecycle = bikecycle.CountBikecycle
                });
                bikecycleData.Remove(bikecycle);
            }
            foreach (var bikecycle in bikecycleData)
            {
                result.Add(new SessionStatistic
                {
                    Period = bikecycle.Period,
                    CountCar = 0,
                    CountMotorbike = 0,
                    CountBikecycle = bikecycle.CountBikecycle
                });
            }
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
                            result.Add(new RevenueStatistic
                            {
                                Period = periodString,
                                ResidentAmount = residentAmount,
                                VisitorAmount = 0
                            });
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
                            result.Add(new RevenueStatistic
                            {
                                Period = periodString,
                                ResidentAmount = 0,
                                VisitorAmount = visitorAmount
                            });
                        }
                    }
                }
            }
            
            return result;
        }

        private List<SessionStatistic> GetVehicleData(DateTime startDate, DateTime endDate, string groupingType, int vehicle_id)
        {
            var (dateFormat, periodFormat) = GetDateFormatAndPeriodFormat(groupingType, "sessions");
            List<SessionStatistic> result = new List<SessionStatistic>();
            string sessionsQuery = $@"
                    SELECT 
                        {dateFormat} AS period,
                        Count(s.id) AS vehicle_count
                    FROM 
                        sessions s JOIN cards c ON s.card_id = c.id
                    WHERE 
                        s.checkout_time BETWEEN @startDate AND @endDate AND s.type = 'VISITOR' AND c.vehicle_type_id = @vehicleTypeId
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
                    sessionsCommand.Parameters.AddWithValue("@vehicleTypeId", vehicle_id);
                    using (var sessionsReader = sessionsCommand.ExecuteReader())
                    {
                        while (sessionsReader.Read())
                        {
                            string periodString = sessionsReader.GetString("period");
                            int vehicle_count = sessionsReader.GetInt32("vehicle_count");
                            result.Add(new SessionStatistic
                            {
                                Period = periodString,
                                CountBikecycle = vehicle_id == BIKECYCLE_ID ? vehicle_count : 0,
                                CountCar = vehicle_id == CAR_ID ? vehicle_count : 0,
                                CountMotorbike = vehicle_id == MOTORBIKE_ID ? vehicle_count : 0
                            });
                        }
                    }
                }
            }
        
            return result;
        }
    }
}
