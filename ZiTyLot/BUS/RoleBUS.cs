using System;
using System.Collections.Generic;
using ZiTyLot.DAO;
using ZiTyLot.ENTITY;
using ZiTyLot.Helper;

namespace ZiTyLot.BUS
{
    public class RoleBUS : IBUS<Role>
    {
        private readonly RoleDAO roleDao;

        public RoleBUS()
        {
            this.roleDao = new RoleDAO();
        }

        public void Add(Role item)
        {
            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                roleDao.Add(item);
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
                roleDao.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Role> GetAll(List<FilterCondition> filters = null)
        {
            try
            {
                return roleDao.GetAll(filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Page<Role> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            try
            {
                return roleDao.GetAllPagination(pageable, filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Role GetById(object id)
        {
            try
            {
                return roleDao.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the data.", ex);
            }
        }

        public void Update(Role item)
        {
            EnsureRecordExists(item.Id); // Kiểm tra sự tồn tại của bản ghi

            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                roleDao.Update(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Validate(Role item)
        {
            if (string.IsNullOrWhiteSpace(item.Name))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(item.Name));
            }

            // Add other validation rules as needed
        }

        // Kiểm tra sự tồn tại của bản ghi
        private void EnsureRecordExists(object id)
        {
            var existingItem = roleDao.GetById(id);
            if (existingItem == null)
            {
                throw new KeyNotFoundException($"Record with ID {id} not found.");
            }
        }
    }
}
