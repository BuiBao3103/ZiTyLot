using System;
using System.Collections.Generic;
using ZiTyLot.Constants;
using ZiTyLot.ENTITY;
using ZiTyLot.Helper;

namespace ZiTyLot.DAO
{
    public class RoleDAO : IDAO<Role>
    {
        private readonly FactoryDAO<Role> daoFactory;

        public RoleDAO()
        {
            daoFactory = new FactoryDAO<Role>(DatabaseName.Role);
        }

        public List<Role> GetAll(List<FilterCondition> filters = null)
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

        public Page<Role> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
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

        public Role GetById(object id)
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

        public void Add(Role item)
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

        public void Update(Role item)
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
                daoFactory.SoftDelete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Role AddAndGet(Role item)
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

        public int Count(List<FilterCondition> filters = null)
        {
            try
            {
                return daoFactory.Count(filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
