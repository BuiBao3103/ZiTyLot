using System;
using System.Collections.Generic;
using ZiTyLot.Constants;
using ZiTyLot.ENTITY;
using ZiTyLot.Helper;

namespace ZiTyLot.DAO
{
    public class ResidentDAO : IDAO<Resident>
    {
        private readonly FactoryDAO<Resident> daoFactory;

        public ResidentDAO()
        {
            daoFactory = new FactoryDAO<Resident>(DatabaseName.Resident);
        }

        public List<Resident> GetAll(List<FilterCondition> filters = null)
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

        public Page<Resident> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
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

        public Resident GetById(int id)
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

        public void Add(Resident item)
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

        public void Update(Resident item)
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
