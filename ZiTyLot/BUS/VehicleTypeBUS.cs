using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiTyLot.DAO;
using ZiTyLot.DTOS;
using ZiTyLot.Helper;

namespace ZiTyLot.BUS
{
    internal class VehicleTypeBUS : IBUS<VehicleType>
    {
        private readonly VehicleTypeDAO vehicleTypeDAO;
        private readonly VisitorFeeDAO visitorFeeDAO;
        private readonly ResidentFeeDAO residentFeeDAO;
        private readonly CardDAO cardDAO;
        private readonly IssueDAO issueDAO;

        public VehicleTypeBUS()
        {
            this.vehicleTypeDAO = new VehicleTypeDAO();
            this.visitorFeeDAO = new VisitorFeeDAO();
            this.residentFeeDAO = new ResidentFeeDAO();
            this.cardDAO = new CardDAO();
            this.issueDAO = new IssueDAO();
        }

        public void Add(VehicleType item)
        {
            Validate(item);
            try
            {
                vehicleTypeDAO.Add(item);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(object id)
        {
            EnsureRecordExists(id);
            try
            {
                vehicleTypeDAO.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<VehicleType> GetAll(List<FilterCondition> filters = null)
        {
            try
            {
                return vehicleTypeDAO.GetAll(filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Page<VehicleType> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            try
            {
                return vehicleTypeDAO.GetAllPagination(pageable, filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public VehicleType GetById(object id)
        {
            EnsureRecordExists(id);
            try
            {
                return vehicleTypeDAO.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(VehicleType item)
        {
            EnsureRecordExists(item.Id);
            Validate(item);
            try
            {
                vehicleTypeDAO.Update(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //
        private void Validate(VehicleType item)
        {
            if (string.IsNullOrWhiteSpace(item.Name))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(item.Name));
            }

            // Add other validation rules as needed
        }

        private void EnsureRecordExists(object id)
        {
            var existingItem = vehicleTypeDAO.GetById(id);
            if (existingItem == null)
            {
                throw new KeyNotFoundException($"Record with ID {id} not found.");
            }
        }

        // Population

        public VehicleType PopulateVisitorFee(VehicleType item)
        {
            try
            {
                List<FilterCondition> filters = new List<FilterCondition>
                {
                    new FilterCondition("vehicle_type_id", CompOp.Equals, item.Id)
                };
                List<VisitorFee> visitorFee = visitorFeeDAO.GetAll(filters);
                item.Visitor_fee = visitorFee[0];
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public VehicleType PopulateCards(VehicleType item)
        {
            try
            {
                List<FilterCondition> filters = new List<FilterCondition>
                {
                    new FilterCondition("vehicle_type_id", CompOp.Equals, item.Id)
                };
                List<Card> cards = cardDAO.GetAll(filters);
                item.Cards = cards;
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public VehicleType PopulateResidentFees(VehicleType item)
        {
            try
            {
                List<FilterCondition> filters = new List<FilterCondition>
                {
                    new FilterCondition("vehicle_type_id", CompOp.Equals, item.Id)
                };
                List<ResidentFee> residentFees = residentFeeDAO.GetAll(filters);
                item.Resident_fees = residentFees;
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public VehicleType PopulateIssues(VehicleType item)
        {
            try
            {
                List<FilterCondition> filters = new List<FilterCondition>
                {
                    new FilterCondition("vehicle_type_id", CompOp.Equals, item.Id)
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
