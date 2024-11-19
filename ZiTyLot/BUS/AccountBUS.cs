using System;
using System.Collections.Generic;
using ZiTyLot.DAO;
using ZiTyLot.DTOS;
using ZiTyLot.GUI.component_extensions;
using ZiTyLot.GUI.Utils;
using ZiTyLot.Helper;

namespace ZiTyLot.BUS
{
    public class AccountBUS : IBUS<Account>
    {
        private readonly AccountDAO accountDao;
        private readonly RoleDAO roleDAO;
        private readonly BillDAO billDAO;

        public AccountBUS()
        {
            this.accountDao = new AccountDAO();
            this.roleDAO = new RoleDAO();
            this.billDAO = new BillDAO();
        }

        public void ChangePassword(Account item, string currentPassword, string newPassword, string confirmPassword)
        {
            // Validate
            if (string.IsNullOrWhiteSpace(currentPassword))
                throw new Exception("Please enter current password");

            if (string.IsNullOrWhiteSpace(newPassword))
                throw new Exception("Please enter new password");

            if (string.IsNullOrWhiteSpace(confirmPassword))
                throw new Exception("Please enter confirm password");

            if (!InputValidator.ValidatePassword(newPassword))
                throw new Exception("Password must be between 8 and 20 characters");

            // Kiểm tra tính hợp lệ của dữ liệu
            if (!item.Password.Equals(currentPassword))
                throw new Exception("Current password is incorrect");

            if (!newPassword.Equals(confirmPassword))
                throw new Exception("Confirm password does not match the new password");

            item.Password = newPassword;
            Update(item);
        }

        public void Add(Account item)
        {
            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                item.Created_at = DateTime.Now;
                accountDao.Add(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(object id)
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

        public Account GetById(object id)
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

            // Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

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
            // username already exists
            List<Account> accounts = accountDao.GetAll(new List<FilterCondition>
            {
                new FilterCondition("username", CompOp.Equals, item.Username)
            });
            if (accounts.Count > 0)
            {
                throw new ValidationInputException("Username already exists.");
            }
        }

        // Kiểm tra sự tồn tại của bản ghi
        private void EnsureRecordExists(object id)
        {
            var existingItem = accountDao.GetById(id);
            if (existingItem == null)
            {
                throw new KeyNotFoundException($"Record with ID {id} not found.");
            }
        }

        // Population

        public Account PopulateRole(Account item)
        {
            try
            {
                if (item.Role_id.HasValue)
                {
                    Role role = roleDAO.GetById(item.Role_id.Value);
                    item.Role = role;
                    return item;
                }
                else
                {
                    throw new KeyNotFoundException($"RoleID is null, no record to search.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Account PopulateBills(Account item)
        {
            try
            {
                List<FilterCondition> filters = new List<FilterCondition>
                {
                    new FilterCondition("account_id", CompOp.Equals, item.Id)
                };
                List<Bill> bills = billDAO.GetAll(filters);
                item.Bills = bills;
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
