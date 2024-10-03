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
    internal class IssueBUS : IBUS<Issue>
    {
        private readonly IssueDAO issueDAO;
        private readonly ResidentCardDAO residentCardDAO;

        public IssueBUS()
        {
            this.issueDAO = new IssueDAO();
            this.residentCardDAO = new ResidentCardDAO();
        }

        public void Add(Issue item)
        {
            Validate(item);
            try
            {
                issueDAO.Add(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int id)
        {
            EnsureRecordExists(id);
            try
            {
                issueDAO.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Issue> GetAll(List<FilterCondition> filters = null)
        {
            try
            {
                return issueDAO.GetAll(filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Page<Issue> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            try
            {
                return issueDAO.GetAllPagination(pageable, filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Issue GetById(int id)
        {
            EnsureRecordExists(id);
            try
            {
                return issueDAO.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Issue item)
        {
            EnsureRecordExists(item.Id);
            Validate(item);
            try
            {
                issueDAO.Update(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //
        private void Validate(Issue item)
        {
            if (string.IsNullOrWhiteSpace(item.License_plate))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(item.License_plate));
            }

            // Add other validation rules as needed
        }

        private void EnsureRecordExists(int id)
        {
            var existingItem = issueDAO.GetById(id);
            if (existingItem == null)
            {
                throw new KeyNotFoundException($"Record with ID {id} not found.");
            }
        }

        public Issue PopulateResidentCard(Issue item)
        {
            try
            {
                if (item.Resident_card_id.HasValue)
                {
                    ResidentCard residentCard = residentCardDAO.GetById(item.Resident_card_id.Value);
                    item.Resident_card = residentCard;
                    return item;
                }
                else
                {
                    throw new KeyNotFoundException($"ResidentCardID is null, no record to search.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //
        public Issue PopulateBill(Issue item)
        {
            try
            {
                if (item.Bill_id.HasValue)
                {
                    Bill bill = null;
                    item.Bill = bill;
                    return item;
                }
                else
                {
                    throw new KeyNotFoundException($"BillID is null, no record to search.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //
        public Issue PopulateParkingLot(Issue item)
        {
            try
            {
                if (item.Parking_lot_id.HasValue)
                {
                    ParkingLot parkingLot = null;
                    item.Parking_lot = parkingLot;
                    return item;
                }
                else
                {
                    throw new KeyNotFoundException($"ParkingLotID is null, no record to search.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //
        public Issue PopulateSlot(Issue item)
        {
            try
            {
                if (item.Slot_id.HasValue)
                {
                    Slot slot = null;
                    item.Slot = slot;
                    return item;
                }
                else
                {
                    throw new KeyNotFoundException($"SlotID is null, no record to search.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
