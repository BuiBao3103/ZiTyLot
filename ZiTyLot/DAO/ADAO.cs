using System.Collections.Generic;
using ZiTyLot.Helper;
using ZiTyLot.ENTITY;
using System;
using ZiTyLot.Constants;
namespace ZiTyLot.DAO
{
    public class ADAO : IDAO<A>
    {
        private readonly FactoryDAO<A> daoFactory;

        public ADAO()
        {
            daoFactory = new FactoryDAO<A>(DatabaseName.A);
        }

        public List<A> GetAll(List<FilterCondition> filters = null)
        {
            try
            {
                return daoFactory.GetAll(filters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Page<A> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            try
            {
                return daoFactory.GetAllPagination(pageable, filters);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public A GetById(int id)
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

        public void Add(A item)
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

        public void Update(A item)
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

        public void Delete(int id)
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
