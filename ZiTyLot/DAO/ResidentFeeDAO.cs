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
    internal class ResidentFeeDAO : IDAO<ResidentFee>
    {
        private readonly FactoryDAO<ResidentFee> factoryDAO;

        public ResidentFeeDAO()
        {
            factoryDAO = new FactoryDAO<ResidentFee> (DatabaseName.ResidentFee);
        }

        public void Add(ResidentFee item)
        {
            factoryDAO.Add(item);
        }

        public void Delete(int id)
        {
            factoryDAO .Delete(id);
        }

        public List<ResidentFee> GetAll(List<FilterCondition> filters = null)
        {
            return factoryDAO.GetAll(filters);
        }

        public Page<ResidentFee> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            return factoryDAO .GetAllPagination(pageable, filters);
        }

        public ResidentFee GetById(int id)
        {
            return factoryDAO.GetById(id);
        }

        public void Update(ResidentFee item)
        {
            factoryDAO.Update(item);
        }
    }
}
