using System;
using System.Collections.Generic;
using System.Diagnostics;
using ZiTyLot.Constants.Enum;
using ZiTyLot.DAO;
using ZiTyLot.ENTITY;
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

        public double CalculateFee(Session item)
        {
            try
            {
                item = PopulateCard(item);
                item.Card = (new CardBUS()).PopulateVehicleType(item.Card);
                item.Card.Vehicle_type = (new VehicleTypeBUS()).PopulateVisitorFee(item.Card.Vehicle_type);
                VisitorFee visitorFee = item.Card.Vehicle_type.Visitor_fee;
                TimeSpan total_time = item.Checkout_time.Value - item.Checkin_time.Value;
                double total_hour = Math.Ceiling(total_time.TotalHours);

                double fee = 100000;
                switch (visitorFee.Fee_type)
                {
                    case FeeType.TURN:
                        return fee;
                    case FeeType.HOUR_PER_TURN:
                        return fee;
                    case FeeType.FIRST_N_AND_NEXT_M_HOUR:
                        return fee;
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
