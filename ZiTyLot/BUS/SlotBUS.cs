using System;
using System.Collections.Generic;
using ZiTyLot.DAO;
using ZiTyLot.DTOS;
using ZiTyLot.Helper;

namespace ZiTyLot.BUS
{
    public class SlotBUS : IBUS<Slot>
    {
        private readonly SlotDAO slotDao;
        private readonly ParkingLotDAO parkingLotDAO;
        private readonly IssueDAO issueDAO;

        public SlotBUS()
        {
            this.slotDao = new SlotDAO();
            this.parkingLotDAO = new ParkingLotDAO();
            this.issueDAO = new IssueDAO();
        }

        public void Add(Slot item)
        {
            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                item.Created_at = DateTime.Now;
                slotDao.Add(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(object id)
        {
            // EnsureRecordExists(id); // Kiểm tra sự tồn tại của bản ghi

            try
            {
                slotDao.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Slot> GetAll(List<FilterCondition> filters = null)
        {
            try
            {
                return slotDao.GetAll(filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Page<Slot> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            try
            {
                return slotDao.GetAllPagination(pageable, filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Slot GetById(object id)
        {
            try
            {
                return slotDao.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the data.", ex);
            }
        }

        public void Update(Slot item)
        {
            EnsureRecordExists(item.Id); // Kiểm tra sự tồn tại của bản ghi

            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                slotDao.Update(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Validate(Slot item)
        {
            if (string.IsNullOrWhiteSpace(item.Id))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(item.Id));
            }

            // Add other validation rules as needed
        }

        // Kiểm tra sự tồn tại của bản ghi
        private void EnsureRecordExists(string id)
        {
            var existingItem = slotDao.GetById(id);
            if (existingItem == null)
            {
                throw new KeyNotFoundException($"Record with ID {id} not found.");
            }
        }

        // Population

        public Slot PopulationParkingLot(Slot item)
        {
            try
            {
                ParkingLot parkingLot = parkingLotDAO.GetById(item.Parking_lot_id);
                item.Parking_lot = parkingLot;
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Slot PopulateIssues(Slot item)
        {
            try
            {
                List<FilterCondition> filters = new List<FilterCondition>
                {
                    new FilterCondition("slot_id", CompOp.Equals, item.Id)
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
