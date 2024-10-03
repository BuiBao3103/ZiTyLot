using System;
using System.Collections.Generic;
using ZiTyLot.DAO;
using ZiTyLot.ENTITY;
using ZiTyLot.Helper;

namespace ZiTyLot.BUS
{
    public class ParkingLotBUS : IBUS<ParkingLot>
    {
        private readonly ParkingLotDAO parkinglotDao;
        private readonly SlotDAO slotDAO;

        public ParkingLotBUS()
        {
            this.parkinglotDao = new ParkingLotDAO();
            this.slotDAO = new SlotDAO();
        }

        public void Add(ParkingLot item)
        {
            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                parkinglotDao.Add(item);
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
                parkinglotDao.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ParkingLot> GetAll(List<FilterCondition> filters = null)
        {
            try
            {
                return parkinglotDao.GetAll(filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Page<ParkingLot> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            try
            {
                return parkinglotDao.GetAllPagination(pageable, filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ParkingLot GetById(object id)
        {
            try
            {
                return parkinglotDao.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the data.", ex);
            }
        }

        public void Update(ParkingLot item)
        {
            EnsureRecordExists(item.Id); // Kiểm tra sự tồn tại của bản ghi

            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                parkinglotDao.Update(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Validate(ParkingLot item)
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
            //var existingItem = parkinglotDao.GetById(id);
            //if (existingItem == null)
            //{
            //    throw new KeyNotFoundException($"Record with ID {id} not found.");
            //}
        }

        public ParkingLot PopulateSlots(ParkingLot parkingLot)
        {
            try
            {
                List<FilterCondition> filters = new List<FilterCondition>
                {
                    new FilterCondition("parkingLot_id", ComparisonOperator.Equals, parkingLot.Id)
                };
                List<Slot> slots = slotDAO.GetAll(filters);
                parkingLot.Slots = slots;
                return parkingLot;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
