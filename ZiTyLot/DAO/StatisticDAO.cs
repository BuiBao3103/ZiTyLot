using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;
using ZiTyLot.Config;
using ZiTyLot.ENTITY;

namespace ZiTyLot.DAO
{
    public class StatisticDAO
    {
        private const int CAR_ID = 1;
        private const int MOTORBIKE_ID = 2;
        private const int BICYCLE_ID = 3;

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
            var bicycleData = GetVehicleData(startDate, endDate, groupingType, BICYCLE_ID);

            List<SessionStatistic> result = new List<SessionStatistic>();
            foreach (var car in carData)
            {
                var motorbike = motorbikeData.Find(v => v.Period == car.Period);
                var bicycle = bicycleData.Find(v => v.Period == car.Period);
                if (motorbike == null)
                {
                    motorbike = new SessionStatistic
                    {
                        Period = car.Period,
                        CountMotorbike = 0,
                        CountCar = 0,
                        CountBicycle = 0
                    };
                }
                if (bicycle == null)
                {
                    bicycle = new SessionStatistic
                    {
                        Period = car.Period,
                        CountMotorbike = 0,
                        CountCar = 0,
                        CountBicycle = 0
                    };
                }
                result.Add(new SessionStatistic
                {
                    Period = car.Period,
                    CountCar = car.CountCar,
                    CountMotorbike = motorbike.CountMotorbike,
                    CountBicycle = bicycle.CountBicycle
                });
                motorbikeData.Remove(motorbike);
                bicycleData.Remove(bicycle);
            }
            foreach (var motorbike in motorbikeData)
            {
                var bicycle = bicycleData.Find(v => v.Period == motorbike.Period);
                if (bicycle == null)
                {
                    bicycle = new SessionStatistic
                    {
                        Period = motorbike.Period,
                        CountMotorbike = 0,
                        CountCar = 0,
                        CountBicycle = 0
                    };
                }
                result.Add(new SessionStatistic
                {
                    Period = motorbike.Period,
                    CountCar = 0,
                    CountMotorbike = motorbike.CountMotorbike,
                    CountBicycle = bicycle.CountBicycle
                });
                bicycleData.Remove(bicycle);
            }
            foreach (var bicycle in bicycleData)
            {
                result.Add(new SessionStatistic
                {
                    Period = bicycle.Period,
                    CountCar = 0,
                    CountMotorbike = 0,
                    CountBicycle = bicycle.CountBicycle
                });
            }
            result.Sort((a, b) => DateTime.ParseExact(a.Period, periodFormat, CultureInfo.InvariantCulture)
                .CompareTo(DateTime.ParseExact(b.Period, periodFormat, CultureInfo.InvariantCulture)));

            return result;
        }
        public SlotStatistic GetSlotStatistics()
        {
            SlotStatistic result = new SlotStatistic();
            string querySlot = @"
                SELECT 
                    SUM(CASE WHEN parking_lot_type = 'TWO_WHEELER' THEN total_slot END) AS two_wheeler_slot,
                    SUM(CASE WHEN parking_lot_type = 'FOUR_WHEELER' THEN total_slot END) AS four_wheeler_slot
                FROM 
                    parking_lots 
                WHERE 
                     user_type = 'VISITOR' AND status = 'AVAILABLE';";
            string currentSlot = @"
                SELECT 
                    Count(CASE WHEN c.vehicle_type_id = @carId THEN 1 END) AS current_car,
                    Count(CASE WHEN c.vehicle_type_id = @bicycleId THEN 1 END) AS current_bicycle,
                    Count(CASE WHEN c.vehicle_type_id = @motorbikeId THEN 1 END) AS current_motorbike
                FROM 
                    sessions s join cards c on s.card_id = c.id
                WHERE 
                     s.type = 'VISITOR' AND s.checkout_time IS NULL;";

            using (var connection = DBConfig.GetConnection())
            {
                connection.Open();
                using (var totalSlotsCommand = new MySqlCommand(querySlot, connection))
                {
                    using (var totalSlotsReader = totalSlotsCommand.ExecuteReader())
                    {
                        while (totalSlotsReader.Read())
                        {
                            result.Total2Wheels = totalSlotsReader.GetInt32("two_wheeler_slot");
                            result.Total4Wheels = totalSlotsReader.GetInt32("four_wheeler_slot");
                        }
                    }
                }
                using (var currentSlotsCommand = new MySqlCommand(currentSlot, connection))
                {
                    currentSlotsCommand.Parameters.AddWithValue("@carId", CAR_ID);
                    currentSlotsCommand.Parameters.AddWithValue("@bicycleId", BICYCLE_ID);
                    currentSlotsCommand.Parameters.AddWithValue("@motorbikeId", MOTORBIKE_ID);
                    using (var currentSlotsReader = currentSlotsCommand.ExecuteReader())
                    {
                        while (currentSlotsReader.Read())
                        {
                            result.CurrentCar = currentSlotsReader.GetInt32("current_car");
                            result.CurrentBicycle = currentSlotsReader.GetInt32("current_bicycle");
                            result.CurrentMotorbike = currentSlotsReader.GetInt32("current_motorbike");
                        }
                    }
                }
            }
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
                                CountBicycle = vehicle_id == BICYCLE_ID ? vehicle_count : 0,
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
