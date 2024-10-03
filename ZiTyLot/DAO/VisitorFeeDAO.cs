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
    internal class VisitorFeeDAO : IDAO<VisitorFee>
    {
        private readonly FactoryDAO<VisitorFee> factoryDAO;

        public VisitorFeeDAO()
        {
            factoryDAO = new FactoryDAO<VisitorFee>(DatabaseName.VisitorFee);
        }

        public void Add(VisitorFee item)
        {
            factoryDAO.Add(item);
        }

        public void Delete(object id)
        {
            factoryDAO.Delete(id);
        }

        public List<VisitorFee> GetAll(List<FilterCondition> filters = null)
        {
            return factoryDAO.GetAll(filters);
        }

        public Page<VisitorFee> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            return factoryDAO.GetAllPagination(pageable, filters);
        }

        public VisitorFee GetById(object id)
        {
            return factoryDAO.GetById(id);
        }

        public void Update(VisitorFee item)
        {
            factoryDAO.Update(item);
        }
    }
}
