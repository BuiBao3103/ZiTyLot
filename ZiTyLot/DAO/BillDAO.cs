﻿using System;
using System.Collections.Generic;
using ZiTyLot.Constants;
using ZiTyLot.DTOS;
using ZiTyLot.Helper;

namespace ZiTyLot.DAO
{
    public class BillDAO : IDAO<Bill>
    {
        private readonly FactoryDAO<Bill> daoFactory;

        public BillDAO()
        {
            daoFactory = new FactoryDAO<Bill>(DatabaseName.Bill);
        }

        public List<Bill> GetAll(List<FilterCondition> filters = null)
        {
            try
            {
                if (filters == null) filters = new List<FilterCondition>();
                filters.Add(new FilterCondition("deleted_at", CompOp.Equals, null));
                return daoFactory.GetAll(filters);
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
                if (filters == null) filters = new List<FilterCondition>();
                filters.Add(new FilterCondition("deleted_at", CompOp.Equals, null));
                return daoFactory.GetAllPagination(pageable, filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Bill GetById(object id)
        {
            try
            {
                return daoFactory.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Add(Bill item)
        {
            try
            {
                daoFactory.Add(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Bill AddAndGet(Bill item)
        {
            try
            {
                return daoFactory.AddAndGet(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(Bill item)
        {
            try
            {
                daoFactory.Update(item);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(object id)
        {
            try
            {
                daoFactory.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
