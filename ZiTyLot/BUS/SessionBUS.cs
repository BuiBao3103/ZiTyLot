using OfficeOpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using ZiTyLot.Constants.Enum;
using ZiTyLot.DAO;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.Utils;
using ZiTyLot.Helper;

namespace ZiTyLot.BUS
{
    internal class SessionBUS : IBUS<Session>
    {
        private readonly SessionDAO sessionDAO;
        private readonly CardDAO cardDAO;
        private readonly ImageDAO imageDAO;

        public SessionBUS()
        {
            this.sessionDAO = new SessionDAO();
            this.cardDAO = new CardDAO();
            this.imageDAO = new ImageDAO();
        }

        public Session CreateFull(Session newSession, List<Image> images)
        {
            try
            {
                newSession.Created_at = DateTime.Now;
                newSession = sessionDAO.AddAndGet(newSession);
                foreach (Image image in images)
                {
                    image.Created_at = DateTime.Now;
                    image.Session_id = newSession.Id;
                    imageDAO.Add(image);
                }

                //UPDATE STATUS OF SLOT
                return newSession;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Add(Session item)
        {
            Validate(item);
            try
            {
                item.Created_at = DateTime.Now;
                sessionDAO.Add(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(object id)
        {
            EnsureRecordExists(id);
            try
            {
                sessionDAO.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Session> GetAll(List<FilterCondition> filters = null)
        {
            try
            {
                return sessionDAO.GetAll(filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Page<Session> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            try
            {
                return sessionDAO.GetAllPagination(pageable, filters);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw new Exception(ex.Message);
            }
        }

        public Session GetById(object id)
        {
            EnsureRecordExists(id);
            try
            {
                return sessionDAO.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Session item)
        {
            EnsureRecordExists(item.Id);
            Validate(item);
            try
            {
                sessionDAO.Update(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //
        private void Validate(Session item)
        {

        }

        private void EnsureRecordExists(object id)
        {
            var existingItem = sessionDAO.GetById(id);
            if (existingItem == null)
            {
                throw new KeyNotFoundException($"Record with ID {id} not found.");
            }
        }

        // Population

        public Session PopulateCard(Session item)
        {
            try
            {
                if (item.Card_id.HasValue)
                {
                    Card card = cardDAO.GetById(item.Card_id.Value);
                    item.Card = card;
                    return item;
                }
                else
                {
                    throw new KeyNotFoundException($"CardID is null, no record to search.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Session PopulateImages(Session item)
        {
            try
            {
                List<FilterCondition> filters = new List<FilterCondition>
                {
                    new FilterCondition("session_id", CompOp.Equals, item.Id)
                };
                List<Image> images = imageDAO.GetAll(filters);
                item.Images = images;
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public double CalculateParkingTurnFee(DateTime startTime, DateTime endTime, double morningFee, double eveningFee)
        {
            Console.WriteLine($"Start time: {startTime}");
            Console.WriteLine($"End time: {endTime}");
            double totalFee = 0;

            //Lấy ra ngày của ngày bắt đầu 
            DateTime currentDay = startTime.Date;

            while (currentDay <= endTime.Date)
            {
                Console.WriteLine($"\n--- Processing date: {currentDay:yyyy-MM-dd} ---");

                //Các mốc thời gian trong ngày của ngày bắt đầu 
                //Ví dụ ngày bắt đầu là 2024-11-17
                //thời gian tính của buổi sáng là từ 6:00 sáng đến 18:00 tối cùng ngày
                //thời gian tính của buổi tối là từ 18:00 tối cùng ngày đến 6:00 sáng hôm sau
                DateTime morningStart = currentDay.AddHours(6);  // 6:00 sáng
                DateTime morningEnd = currentDay.AddHours(18);   // 18:00 tối
                DateTime nightStart = morningEnd;                // 18:00 tối
                DateTime nightEnd = currentDay.AddDays(1).AddHours(6);  // 6:00 sáng hôm sau

                Console.WriteLine($"Morning start: {morningStart}, Morning end: {morningEnd}");
                Console.WriteLine($"Night start: {nightStart}, Night end: {nightEnd}");

                //Điều chỉnh ngày bắt đầu sẽ bằng chính ("thời gian hiện tại") nếu như thời gian bắt đầu lớn hơn 6:00 sáng
                DateTime adjustedStart = (startTime > morningStart) ? startTime : morningStart;

                //Điều chỉnh ngày kết thúc sẽ bằng chính ("thời gian hiện tại") nếu như thời gian kết thúc nhỏ hơn 6:00 sáng hôm sau
                DateTime adjustedEnd = (endTime < nightEnd) ? endTime : nightEnd;

                Console.WriteLine($"Adjusted start time: {adjustedStart}");
                Console.WriteLine($"Adjusted end time: {adjustedEnd}");

                if (adjustedStart < morningEnd && adjustedEnd > morningStart)
                {
                    totalFee += morningFee;
                    Console.WriteLine($"Morning fee applied: {morningFee}");
                }

                if (adjustedStart < nightEnd && adjustedEnd > nightStart)
                {
                    totalFee += eveningFee;
                    Console.WriteLine($"Evening fee applied: {eveningFee}");
                }

                currentDay = currentDay.AddDays(1);
            }

            Console.WriteLine($"\nTotal parking fee: {totalFee}");
            return totalFee;
        }

        public double CalculateParkingHourPerTurnFee(DateTime startTime, DateTime endTime, double hoursPerTurn, double morningFee, double eveningFee)
        {
            Console.WriteLine($"Start time: {startTime}");
            Console.WriteLine($"End time: {endTime}");
            double totalFee = 0;
            DateTime currentDay = startTime.Date;

            while (currentDay <= endTime.Date)
            {
                Console.WriteLine($"\n--- Processing day: {currentDay:yyyy-MM-dd} ---");

                DateTime morningStart = currentDay.AddHours(6);  // 6:00 sáng
                DateTime morningEnd = currentDay.AddHours(18);   // 18:00 tối
                DateTime nightStart = morningEnd;                // 18:00 tối
                DateTime nightEnd = currentDay.AddDays(1).AddHours(6);  // 6:00 sáng hôm sau

                Console.WriteLine($"Morning start: {morningStart}, Morning end: {morningEnd}");
                Console.WriteLine($"Night start: {nightStart}, Night end: {nightEnd}");

                DateTime adjustedStart = (startTime > morningStart) ? startTime : morningStart;
                DateTime adjustedEnd = (endTime < nightEnd) ? endTime : nightEnd;

                Console.WriteLine($"Adjusted start time: {adjustedStart}");
                Console.WriteLine($"Adjusted end time: {adjustedEnd}");

                double totalHour = Math.Ceiling((adjustedEnd - adjustedStart).TotalHours);
                Console.WriteLine($"Total hours calculated: {totalHour}");

                double totalTurn = Math.Ceiling(totalHour / hoursPerTurn);
                Console.WriteLine($"Total turns (each turn = {hoursPerTurn} hours): {totalTurn}");

                if (adjustedStart < morningEnd)
                {
                    double morningHours = Math.Min((morningEnd - adjustedStart).TotalHours, totalHour);
                    double morningTurns = Math.Ceiling(morningHours / hoursPerTurn);
                    Console.WriteLine($"Morning hours: {morningHours}, Morning turns: {morningTurns}");

                    totalFee += morningTurns * morningFee;
                    Console.WriteLine($"Added morning fee: {morningTurns * morningFee}");
                }

                if (adjustedEnd > nightStart)
                {
                    double nightHours = Math.Min((adjustedEnd - nightStart).TotalHours, totalHour);
                    double nightTurns = Math.Ceiling(nightHours / hoursPerTurn);
                    Console.WriteLine($"Night hours: {nightHours}, Night turns: {nightTurns}");

                    totalFee += nightTurns * eveningFee;
                    Console.WriteLine($"Added night fee: {nightTurns * eveningFee}");
                }

                currentDay = currentDay.AddDays(1);
            }

            Console.WriteLine($"\nTotal fee calculated: {totalFee}");
            return totalFee;
        }

        public double CalculateFirstNAndNextMHour(DateTime startTime, DateTime endTime, double firstNHour, double nextMHour)
        {
            double totalFee = 0;
            Console.WriteLine($"Initial total fee: {totalFee}");

            DateTime currentDate = startTime.Date;
            Console.WriteLine($"Current date (ignoring time): {currentDate}");

            TimeSpan difference = endTime - startTime;
            Console.WriteLine($"Time difference between startTime and endTime: {difference.TotalHours} hours");

            if (difference.TotalHours < 2)
            {
                Console.WriteLine($"Time difference is less than 2 hours. Returning firstNHour fee: {firstNHour}");
                return firstNHour;
            }
            else
            {
                totalFee += firstNHour;
                Console.WriteLine($"Adding firstNHour fee: {firstNHour}, total fee now: {totalFee}");

                difference = difference.Subtract(new TimeSpan(2, 0, 0));
                Console.WriteLine($"Remaining time after subtracting 2 hours: {difference.TotalHours} hours");

                double nextHoursFee = Math.Ceiling(difference.TotalHours) * nextMHour;
                Console.WriteLine($"Additional fee for remaining hours: {nextHoursFee} ({Math.Ceiling(difference.TotalHours)} hours * {nextMHour} per hour)");

                totalFee += nextHoursFee;
            }

            Console.WriteLine($"\nTotal fee calculated: {totalFee}");
            return totalFee;
        }


        public double CalculateFee(Session item)
        {
            try
            {
                item = PopulateCard(item);
                item.Card = (new CardBUS()).PopulateVehicleType(item.Card);
                item.Card.Vehicle_type = (new VehicleTypeBUS()).PopulateVisitorFee(item.Card.Vehicle_type);
                VisitorFee visitorFee = item.Card.Vehicle_type.Visitor_fee;
                Console.WriteLine(visitorFee.Fee_type);
                switch (visitorFee.Fee_type)
                {
                    case FeeType.TURN:
                        return CalculateParkingTurnFee(item.Checkin_time.Value, item.Checkout_time.Value, visitorFee.Day_fee.Value, visitorFee.Night_fee.Value);
                    case FeeType.HOUR_PER_TURN:
                        return CalculateParkingHourPerTurnFee(item.Checkin_time.Value, item.Checkout_time.Value, visitorFee.Hours_per_turn.Value, visitorFee.Day_fee.Value, visitorFee.Night_fee.Value);
                    case FeeType.FIRST_N_AND_NEXT_M_HOUR:
                        return CalculateFirstNAndNextMHour(item.Checkin_time.Value, item.Checkout_time.Value, visitorFee.First_n_hours_fee.Value, visitorFee.Additional_m_hours_fee.Value);
                    default:
                        throw new Exception("Fee type is not valid.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
