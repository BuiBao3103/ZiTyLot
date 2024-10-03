using System;
using System.Collections.Generic;
using ZiTyLot.Constants;
using ZiTyLot.ENTITY;
using ZiTyLot.Helper;

namespace ZiTyLot.DAO
{
    public class SlotDAO : IDAO<Slot>
    {
        private readonly FactoryDAO<Slot> daoFactory;

        public SlotDAO()
        {
            daoFactory = new FactoryDAO<Slot>(DatabaseName.Slot);
        }

        public List<Slot> GetAll(List<FilterCondition> filters = null)
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

        public Page<Slot> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
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

        public Slot GetById(object id)
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

        public void Add(Slot item)
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

        public void Update(Slot item)
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
