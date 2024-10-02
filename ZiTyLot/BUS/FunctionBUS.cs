﻿using System;
using System.Collections.Generic;
using ZiTyLot.DAO;
using ZiTyLot.ENTITY;
using ZiTyLot.Helper;

namespace ZiTyLot.BUS
{
    public class FunctionBUS : IBUS<Function>
    {
        private readonly FunctionDAO functionDao;
        private readonly RoleFunctionDAO roleFunctionDao;

        public FunctionBUS()
        {
            this.functionDao = new FunctionDAO();
            this.roleFunctionDao = new RoleFunctionDAO();
        }

        public void Add(Function item)
        {
            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                functionDao.Add(item);
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
                functionDao.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Function> GetAll(List<FilterCondition> filters = null)
        {
            try
            {
                return functionDao.GetAll(filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Page<Function> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            try
            {
                return functionDao.GetAllPagination(pageable, filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Function GetById(int id)
        {
            try
            {
                return functionDao.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the data.", ex);
            }
        }

        public void Update(Function item)
        {
            EnsureRecordExists(item.Id); // Kiểm tra sự tồn tại của bản ghi

            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                functionDao.Update(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Validate(Function item)
        {
            if (string.IsNullOrWhiteSpace(item.Name))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(item.Name));
            }

            // Add other validation rules as needed
        }

        // Kiểm tra sự tồn tại của bản ghi
        private void EnsureRecordExists(int id)
        {
            var existingItem = functionDao.GetById(id);
            if (existingItem == null)
            {
                throw new KeyNotFoundException($"Record with ID {id} not found.");
            }
        }

        //public Function PopulateRoleFunctions(Function func)
        //{
        //    try
        //    {
        //        List<FilterCondition> filters = new List<FilterCondition>
        //        {
        //            new FilterCondition("function_id", ComparisonOperator.Equals, func.Id)
        //        };
        //        List<RoleFunction> role_functions = roleFunctionDao.GetAll(filters);
        //        func.Role_functions = role_functions;
        //        return func;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }

        //}
    }
}