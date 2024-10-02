using System;
using System.Collections.Generic;
using ZiTyLot.DAO;
using ZiTyLot.ENTITY;
using ZiTyLot.Helper;

namespace ZiTyLot.BUS
{
    public class BillBUS : IBUS<Bill>
    {
        private readonly BillDAO billDao;
        private readonly ResidentDAO residentDAO;

        public BillBUS()
        {
            this.billDao = new BillDAO();
            this.residentDAO = new ResidentDAO();
        }

        public void Add(Bill item)
        {
            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                billDao.Add(item);
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
                billDao.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Bill> GetAll(List<FilterCondition> filters = null)
        {
            try
            {
                return billDao.GetAll(filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Page<Bill> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            try
            {
                return billDao.GetAllPagination(pageable, filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Bill GetById(int id)
        {
            try
            {
                return billDao.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the data.", ex);
            }
        }

        public void Update(Bill item)
        {
            EnsureRecordExists(item.Id); // Kiểm tra sự tồn tại của bản ghi

            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                billDao.Update(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Validate(Bill item)
        {
            //if (string.IsNullOrWhiteSpace(item.Id))
            //{
            //    throw new ArgumentException("Name cannot be null or empty.", nameof(item.Id));
            //}

            // Add other validation rules as needed
        }

        // Kiểm tra sự tồn tại của bản ghi
        private void EnsureRecordExists(int id)
        {
            var existingItem = billDao.GetById(id);
            if (existingItem == null)
            {
                throw new KeyNotFoundException($"Record with ID {id} not found.");
            }
        }

        public Bill PopulationResident(Bill bill)
        {
            //Resident resident = residentDAO.GetById(bill.Resident_id);
            //bill.Resident = resident;
            return bill;
        }
    }
}
