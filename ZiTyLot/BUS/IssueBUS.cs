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
    internal class IssueBUS : IBUS<Issue>
    {
        private readonly IssueDAO issueDAO;
        private readonly BillDAO billDAO;
        private readonly ParkingLotDAO parkingLotDAO;
        private readonly SlotDAO slotDAO;
        private readonly VehicleTypeDAO vehicleTypeDAO;
        private readonly CardDAO cardDAO;

        public IssueBUS()
        {
            this.issueDAO = new IssueDAO();
            this.billDAO = new BillDAO();
            this.parkingLotDAO = new ParkingLotDAO();
            this.slotDAO = new SlotDAO();
            this.vehicleTypeDAO = new VehicleTypeDAO();
            this.cardDAO = new CardDAO();
        }

        public void Add(Issue item)
        {
            Validate(item);
            try
            {
                item.Created_at = DateTime.Now;
                issueDAO.Add(item);
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

        public Issue GetById(object id)
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

        private void EnsureRecordExists(object id)
        {
            var existingItem = issueDAO.GetById(id);
            if (existingItem == null)
            {
                throw new KeyNotFoundException($"Record with ID {id} not found.");
            }
        }

        // Population

        public Issue PopulateBill(Issue item)
        {
            try
            {
                if (item.Bill_id.HasValue)
                {
                    Bill bill = billDAO.GetById(item.Bill_id.Value);
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

        public Issue PopulateParkingLot(Issue item)
        {
            try
            {
                if (!string.IsNullOrEmpty(item.Parking_lot_id))
                {
                    ParkingLot parkingLot = parkingLotDAO.GetById(item.Parking_lot_id);
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

        public Issue PopulateSlot(Issue item)
        {
            try
            {
                if (!string.IsNullOrEmpty(item.Slot_id))
                {
                    Slot slot = slotDAO.GetById(item.Slot_id);
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

        public Issue PopulateVehicleType(Issue item)
        {
            try
            {
                if (item.Vehicle_type_id.HasValue)
                {
                    VehicleType vehicleType = vehicleTypeDAO.GetById(item.Vehicle_type_id.Value);
                    item.Vehicle_type = vehicleType;
                    return item;
                }
                else
                {
                    throw new KeyNotFoundException($"VehicleTypeID is null, no record to search.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
