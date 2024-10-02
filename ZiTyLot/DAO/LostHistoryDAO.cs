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
    internal class LostHistoryDAO : IDAO<LostHistory>
    {
        private readonly FactoryDAO<LostHistory> factoryDAO;

        public LostHistoryDAO()
        {
            factoryDAO = new FactoryDAO<LostHistory>(DatabaseName.LostHistory);
        }

        public void Add(LostHistory item)
        {
            factoryDAO.Add(item);
        }

        public void Delete(int id)
        {
            factoryDAO.Delete(id);
        }

        public List<LostHistory> GetAll(List<FilterCondition> filters = null)
        {
            return factoryDAO.GetAll(filters);
        }

        public Page<LostHistory> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            return factoryDAO.GetAllPagination(pageable, filters);
        }

        public LostHistory GetById(int id)
        {
            return factoryDAO.GetById(id);
        }

        public void Update(LostHistory item)
        {
            factoryDAO.Update(item);
        }
    }
}
