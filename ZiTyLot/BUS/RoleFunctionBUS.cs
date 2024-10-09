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
    internal class RoleFunctionBUS : IDAO<RoleFunction>
    {
        private readonly RoleFunctionDAO roleFunctionDAO;
        private readonly RoleDAO roleDAO;
        private readonly FunctionDAO functionDAO;

        public RoleFunctionBUS()
        {
            this.roleFunctionDAO = new RoleFunctionDAO();
            this.roleDAO = new RoleDAO();
            this.functionDAO = new FunctionDAO();
        }

        public void Add(RoleFunction item)
        {
            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                roleFunctionDAO.Add(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //
        public void Delete(object id)
        {
            EnsureRecordExists(id); // Kiểm tra sự tồn tại của bản ghi

            try
            {
                roleFunctionDAO.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<RoleFunction> GetAll(List<FilterCondition> filters = null)
        {
            try
            {
                return roleFunctionDAO.GetAll(filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Page<RoleFunction> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            try
            {
                return roleFunctionDAO.GetAllPagination(pageable, filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //
        public RoleFunction GetById(object id)
        {
            try
            {
                return roleFunctionDAO.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the data.", ex);
            }
        }

        //
        public void Update(RoleFunction item)
        {
            EnsureRecordExists(item); // Kiểm tra sự tồn tại của bản ghi
            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                roleFunctionDAO.Update(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //
        private void Validate(RoleFunction item)
        {
            // username not null or empty
            //if (string.IsNullOrWhiteSpace(item.Username))
            //{
            //    throw new ArgumentException("Username cannot be null or empty.", nameof(item.Username));
            //}
        }

        //
        // Kiểm tra sự tồn tại của bản ghi
        private void EnsureRecordExists(object item)
        {
            //var existingItem = roleFunctionDAO.GetById(id);
            //if (existingItem == null)
            //{
            //    throw new KeyNotFoundException($"Record with ID {id} not found.");
            //}
        }

        // Population

        public RoleFunction PopulateRole(RoleFunction item)
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

        public RoleFunction PopulateFunction(RoleFunction item)
        {
            try
            {
                if (item.Function_id.HasValue)
                {
                    Function function = functionDAO.GetById(item.Function_id.Value);
                    item.Function = function;
                    return item;
                }
                else
                {
                    throw new KeyNotFoundException($"FunctionID is null, no record to search.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
