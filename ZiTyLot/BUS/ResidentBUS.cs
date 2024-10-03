using System;
using System.Collections.Generic;
using ZiTyLot.DAO;
using ZiTyLot.ENTITY;
using ZiTyLot.Helper;

namespace ZiTyLot.BUS
{
    public class ResidentBUS : IBUS<Resident>
    {
        private readonly ResidentDAO residentDao;
        private readonly BillDAO billDAO;

        public ResidentBUS()
        {
            this.residentDao = new ResidentDAO();
            this.billDAO = new BillDAO();
        }

        public void Add(Resident item)
        {
            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                residentDao.Add(item);
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
                residentDao.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Resident> GetAll(List<FilterCondition> filters = null)
        {
            try
            {
                return residentDao.GetAll(filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Page<Resident> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            try
            {
                return residentDao.GetAllPagination(pageable, filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Resident GetById(object id)
        {
            try
            {
                return residentDao.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the data.", ex);
            }
        }

        public void Update(Resident item)
        {
            EnsureRecordExists(item.Id); // Kiểm tra sự tồn tại của bản ghi

            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                residentDao.Update(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Validate(Resident item)
        {
            if (string.IsNullOrWhiteSpace(item.Full_name))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(item.Full_name));
            }

            // Add other validation rules as needed
        }

        // Kiểm tra sự tồn tại của bản ghi
        private void EnsureRecordExists(object id)
        {
            var existingItem = residentDao.GetById(id);
            if (existingItem == null)
            {
                throw new KeyNotFoundException($"Record with ID {id} not found.");
            }
        }

        public Resident PopulateSlots(Resident resident)
        {
            try
            {
                List<FilterCondition> filters = new List<FilterCondition>
                {
                    new FilterCondition("resident_id", ComparisonOperator.Equals, resident.Id)
                };
                List<Bill> bills = billDAO.GetAll(filters);
                resident.Bills = bills;
                return resident;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
