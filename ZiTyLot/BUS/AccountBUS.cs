using System;
using System.Collections.Generic;
using ZiTyLot.DAO;
using ZiTyLot.ENTITY;
using ZiTyLot.Helper;

namespace ZiTyLot.BUS
{
    public class AccountBUS : IBUS<Account>
    {
        private readonly AccountDAO accountDao;

        public AccountBUS()
        {
            this.accountDao = new AccountDAO();
        }

        public void Add(Account item)
        {
            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                accountDao.Add(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int id)
        {
            EnsureRecordExists(id); // Kiểm tra sự tồn tại của bản ghi

            try
            {
                accountDao.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Account> GetAll(List<FilterCondition> filters = null)
        {
            try
            {
                return accountDao.GetAll(filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Page<Account> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            try
            {
                return accountDao.GetAllPagination(pageable, filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Account GetById(int id)
        {
            try
            {
                return accountDao.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the data.", ex);
            }
        }

        public void Update(Account item)
        {
            EnsureRecordExists(item.Id); // Kiểm tra sự tồn tại của bản ghi

            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                accountDao.Update(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Validate(Account item)
        {
            // username not null or empty
            if (string.IsNullOrWhiteSpace(item.Username))
            {
                throw new ArgumentException("Username cannot be null or empty.", nameof(item.Username));
            }
        }

        // Kiểm tra sự tồn tại của bản ghi
        private void EnsureRecordExists(int id)
        {
            var existingItem = accountDao.GetById(id);
            if (existingItem == null)
            {
                throw new KeyNotFoundException($"Record with ID {id} not found.");
            }
        }

    }
}
