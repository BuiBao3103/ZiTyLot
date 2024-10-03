using System;
using System.Collections.Generic;
using ZiTyLot.DAO;
using ZiTyLot.ENTITY;
using ZiTyLot.Helper;

namespace ZiTyLot.BUS
{
    public class SlotBUS : IBUS<Slot>
    {
        private readonly SlotDAO slotDao;
        private readonly ParkingLotDAO parkingLotDAO;

        public SlotBUS()
        {
            this.slotDao = new SlotDAO();
            this.parkingLotDAO = new ParkingLotDAO();
        }

        public void Add(Slot item)
        {
            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                slotDao.Add(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int id)
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

        public Slot GetById(int id)
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
            //var existingItem = slotDao.GetById(id);
            //if (existingItem == null)
            //{
            //    throw new KeyNotFoundException($"Record with ID {id} not found.");
            //}
        }

        public Slot PopulationParkingLot(Slot slot)
        {
            //A a = aDAO.GetById(b.A_id);
            //b.A = a;
            return slot;
        }
    }
}
