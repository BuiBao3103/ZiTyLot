using System;
using System.Collections.Generic;
using ZiTyLot.DAO;
using ZiTyLot.ENTITY;
using ZiTyLot.GUI.Utils;
using ZiTyLot.Helper;

namespace ZiTyLot.BUS
{
    public class RoleBUS : IBUS<Role>
    {
        private readonly RoleDAO roleDAO;
        private readonly RoleFunctionDAO roleFunctionDAO;
        private readonly AccountDAO accountDAO;

        public RoleBUS()
        {
            this.roleDAO = new RoleDAO();
            this.roleFunctionDAO = new RoleFunctionDAO();
            this.accountDAO = new AccountDAO();
        }
        public Role Create(Role newRole, List<RoleFunction> roleFunctions)
        {
            Validate(newRole);
            try
            {
                newRole.Created_at = DateTime.Now;
                newRole = roleDAO.AddAndGet(newRole);
                foreach (RoleFunction roleFunction in roleFunctions)
                {
                    roleFunction.Role_id = newRole.Id;
                    roleFunctionDAO.Add(roleFunction);
                }

                return newRole;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Add(Role item)
        {
            Validate(item);

            try
            {
                roleDAO.Add(item);
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
                roleDAO.Delete(id);
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
                return roleDAO.GetAll(filters);
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
                return roleDAO.GetAllPagination(pageable, filters);
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
                return roleDAO.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the data.", ex);
            }
        }

        public void Update(Role item)
        {
            EnsureRecordExists(item.Id); // Kiểm tra sự tồn tại của bản ghi

            // Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                roleDAO.Update(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Validate(Role item)
        {
           
            //check name is existed
            List<FilterCondition> filters = new List<FilterCondition>
            {
                new FilterCondition(nameof(Role.Name), CompOp.Equals, item.Name)
            };
            int count = roleDAO.Count(filters);
            if (count > 0)
            {
                throw new ValidationInputException("Role name is existed.");
            }
        }

        // Kiểm tra sự tồn tại của bản ghi
        private void EnsureRecordExists(object id)
        {
            var existingItem = roleDAO.GetById(id);
            if (existingItem == null)
            {
                throw new KeyNotFoundException($"Record with ID {id} not found.");
            }
        }

        // Population

        public Role PopulateRoleFunctions(Role item)
        {
            try
            {
                List<FilterCondition> filters = new List<FilterCondition>
                {
                    new FilterCondition("role_id", CompOp.Equals, item.Id)
                };
                List<RoleFunction> roleFunctions = roleFunctionDAO.GetAll(filters);
                item.Role_functions = roleFunctions;
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Role PopulateAccounts(Role item)
        {
            try
            {
                List<FilterCondition> filters = new List<FilterCondition>
                {
                    new FilterCondition("role_id", CompOp.Equals, item.Id)
                };
                List<Account> accounts = accountDAO.GetAll(filters);
                item.Accounts = accounts;
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Population many to many
        public Role PopulateFunctions(Role item)
        {
            try
            {
                RoleFunctionBUS roleFunctionBUS = new RoleFunctionBUS();
                List<FilterCondition> filters = new List<FilterCondition>
                {
                    new FilterCondition("role_id", CompOp.Equals, item.Id)
                };
                List<RoleFunction> roleFunctions = roleFunctionDAO.GetAll(filters);
                List<Function> functions = new List<Function>();
                RoleFunction roleFunctionTmp = new RoleFunction();
                foreach (RoleFunction roleFunction in roleFunctions)
                {
                    roleFunctionTmp = roleFunctionBUS.PopulateFunction(roleFunction);
                    functions.Add(roleFunctionTmp.Function);
                }
                item.Functions = functions;
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
