using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiTyLot.DAO;
using ZiTyLot.ENTITY;
using ZiTyLot.Helper;

namespace ZiTyLot.BUS
{
    internal class CardBUS : IBUS<Card>
    {
        private readonly CardDAO cardDAO;
        private readonly VehicleTypeDAO vehicleTypeDAO;
        private readonly SessionDAO sessionDAO;
        private readonly LostHistoryDAO lostHistoryDAO;
        private readonly ResidentDAO residentDAO;
        private readonly IssueDAO issueDAO;

        public CardBUS()
        {
            this.cardDAO = new CardDAO();
            this.vehicleTypeDAO = new VehicleTypeDAO();
            this.sessionDAO = new SessionDAO();
            this.lostHistoryDAO = new LostHistoryDAO();
            this.residentDAO = new ResidentDAO();
            this.issueDAO = new IssueDAO();
        }

        public void Add(Card item)
        {
            Validate(item);
            try
            {
                cardDAO.Add(item);
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
                cardDAO.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Card> GetAll(List<FilterCondition> filters = null)
        {
            try
            {
                return cardDAO.GetAll(filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Page<Card> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            try
            {
                return cardDAO.GetAllPagination(pageable, filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Card GetById(object id)
        {
            EnsureRecordExists(id);
            try
            {
                return cardDAO.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Card item)
        {
            EnsureRecordExists(item.Id);
            Validate(item);
            try
            {
                cardDAO.Update(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //
        private void Validate(Card item)
        {
            if (string.IsNullOrWhiteSpace(item.Rfid))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(item.Rfid));
            }

            // Add other validation rules as needed
        }

        private void EnsureRecordExists(object id)
        {
            var existingItem = cardDAO.GetById(id);
            if (existingItem == null)
            {
                throw new KeyNotFoundException($"Record with ID {id} not found.");
            }
        }

        // Population

        public Card PopulateVehicleType(Card item)
        {
            try
            {
                VehicleType vehicleType = vehicleTypeDAO.GetById(item.Vehicle_type_id);
                item.Vehicle_type = vehicleType;
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Card PopulateLostHistories(Card item)
        {
            try
            {
                List<FilterCondition> filters = new List<FilterCondition>
                {
                    new FilterCondition("card_id", ComparisonOperator.Equals, item.Id)
                };
                List<LostHistory> lostHistories = lostHistoryDAO.GetAll(filters);
                item.Lost_histories = lostHistories;
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Card PopulateSessions(Card item)
        {
            try
            {
                List<FilterCondition> filters = new List<FilterCondition>
                {
                    new FilterCondition("card_id", ComparisonOperator.Equals, item.Id)
                };
                List<Session> sessions = sessionDAO.GetAll(filters);
                item.Sessions = sessions;
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Card PopulateResident(Card item)
        {
            try
            {
                Resident resident = residentDAO.GetById(item.Resident_id);
                item.Resident = resident;
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Card PopulateIssues(Card item)
        {
            try
            {
                List<FilterCondition> filters = new List<FilterCondition>
                {
                    new FilterCondition("card_id", ComparisonOperator.Equals, item.Id)
                };
                List<Issue> issues = issueDAO.GetAll(filters);
                item.Issues = issues;
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
