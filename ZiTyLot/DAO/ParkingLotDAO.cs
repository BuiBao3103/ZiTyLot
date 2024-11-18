using System;
using System.Collections.Generic;
using ZiTyLot.Constants;
using ZiTyLot.ENTITY;
using ZiTyLot.Helper;

namespace ZiTyLot.DAO
{
    public class ParkingLotDAO : IDAO<ParkingLot>
    {
        private readonly FactoryDAO<ParkingLot> daoFactory;

        public ParkingLotDAO()
        {
            daoFactory = new FactoryDAO<ParkingLot>(DatabaseName.ParkingLot);
        }

        public List<ParkingLot> GetAll(List<FilterCondition> filters = null)
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

        public Page<ParkingLot> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
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

        public ParkingLot GetById(object id)
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

        public void Add(ParkingLot item)
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

        public void Update(ParkingLot item)
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

        public int Count(List<FilterCondition> filters)
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
