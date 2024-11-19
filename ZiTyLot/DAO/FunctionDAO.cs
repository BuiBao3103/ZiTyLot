using System;
using System.Collections.Generic;
using ZiTyLot.Constants;
using ZiTyLot.DTOS;
using ZiTyLot.Helper;

namespace ZiTyLot.DAO
{
    public class FunctionDAO : IDAO<Function>
    {

        private readonly FactoryDAO<Function> daoFactory;

        public FunctionDAO()
        {
            daoFactory = new FactoryDAO<Function>(DatabaseName.Function);
        }

        public List<Function> GetAll(List<FilterCondition> filters = null)
        {
            try
            {
                if (filters == null) filters = new List<FilterCondition>();
                return daoFactory.GetAll(filters);
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
                if (filters == null) filters = new List<FilterCondition>();
                filters.Add(new FilterCondition("deleted_at", CompOp.Equals, null));
                return daoFactory.GetAllPagination(pageable, filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Function GetById(object id)
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

        public void Add(Function item)
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

        public void Update(Function item)
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
