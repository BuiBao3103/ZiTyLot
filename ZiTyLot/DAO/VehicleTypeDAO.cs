using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiTyLot.Constants;
using ZiTyLot.ENTITY;
using ZiTyLot.Helper;

namespace ZiTyLot.DAO
{
    internal class VehicleTypeDAO : IDAO<VehicleType>
    {
        private readonly FactoryDAO<VehicleType> factoryDAO;

        public VehicleTypeDAO()
        {
            factoryDAO = new FactoryDAO<VehicleType>(DatabaseName.VehicleType);
        }

        public void Add(VehicleType item)
        {
            factoryDAO.Add(item);
        }

        public void Delete(object id)
        {
            factoryDAO.Delete(id);
        }

        public List<VehicleType> GetAll(List<FilterCondition> filters = null)
        {
            if (filters == null) filters = new List<FilterCondition>();
            filters.Add(new FilterCondition("deleted_at", CompOp.Equals, null));
            return factoryDAO.GetAll(filters);
        }

        public Page<VehicleType> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            if (filters == null) filters = new List<FilterCondition>();
            filters.Add(new FilterCondition("deleted_at", CompOp.Equals, null));
            return factoryDAO.GetAllPagination(pageable, filters);
        }

        public VehicleType GetById(object id)
        {
            return factoryDAO.GetById(id);
        }

        public void Update(VehicleType item)
        {
            factoryDAO.Update(item);
        }
    }
}
