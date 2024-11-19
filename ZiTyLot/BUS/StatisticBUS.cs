using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ZiTyLot.DAO;
using ZiTyLot.DTOS;
using ZiTyLot.GUI.Utils;

namespace ZiTyLot.BUS
{
    public class StatisticBUS
    {
        private readonly StatisticDAO _statisticDAO;

        public StatisticBUS()
        {
            _statisticDAO = new StatisticDAO();
        }

        public List<RevenueStatistic> GetRevenueStatistics(string dateRangeInput)
        {
            var (startDate, endDate, groupingType) = ParseDateRange(dateRangeInput);
            return _statisticDAO.GetRevenueStatistics(startDate, endDate, groupingType);
        }

        public List<SessionStatistic> GetSessionStatistics(string dateRangeInput)
        {
            var (startDate, endDate, groupingType) = ParseDateRange(dateRangeInput);
            return _statisticDAO.GetSessionStatistics(startDate, endDate, groupingType);
        }

        public SlotStatistic GetSlotStatistics()
        {
            return _statisticDAO.GetSlotStatistics();
        }

        private (DateTime startDate, DateTime endDate, string groupingType) ParseDateRange(string input)
        {
            if (Regex.IsMatch(input, @"^\d{4}-\d{2}-\d{2} to \d{4}-\d{2}-\d{2}$"))
            {
                string[] dates = input.Split(" to ");
                return (
                    DateTime.ParseExact(dates[0], "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    DateTime.ParseExact(dates[1], "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    "DAY"
                );
            }
            else if (Regex.IsMatch(input, @"^\d{4}-\d{1,2} to \d{4}-\d{1,2}$"))
            {
                string[] dates = input.Split(" to ");
                return (
                    DateTime.ParseExact(dates[0], "yyyy-M", CultureInfo.InvariantCulture),
                    DateTime.ParseExact(dates[1], "yyyy-M", CultureInfo.InvariantCulture),
                    "MONTH"
                );
            }
            else if (Regex.IsMatch(input, @"^\d{4} to \d{4}$"))
            {
                string[] dates = input.Split(" to ");
                return (
                    DateTime.ParseExact(dates[0], "yyyy", CultureInfo.InvariantCulture),
                    DateTime.ParseExact(dates[1], "yyyy", CultureInfo.InvariantCulture),
                    "YEAR"
                );
            }
            throw new ValidationInputException("Invalid date range format");
        }
    }
}
