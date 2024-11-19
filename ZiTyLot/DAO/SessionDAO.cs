using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiTyLot.Constants;
using ZiTyLot.DTOS;
using ZiTyLot.Helper;

namespace ZiTyLot.DAO
{
    internal class SessionDAO : IDAO<Session>
    {
        private readonly FactoryDAO<Session> factoryDAO;

        public SessionDAO()
        {
            factoryDAO = new FactoryDAO<Session>(DatabaseName.Session);
        }

        public void Add(Session item)
        {
            factoryDAO.Add(item);
        }
        public Session AddAndGet(Session item)
        {
            return factoryDAO.AddAndGet(item);
        }

        public void Delete(object id)
        {
            factoryDAO.Delete(id);
        }

        public List<Session> GetAll(List<FilterCondition> filters = null)
        {
            if (filters == null) filters = new List<FilterCondition>();
            filters.Add(new FilterCondition("deleted_at", CompOp.Equals, null));
            return factoryDAO.GetAll(filters);
        }

        public Page<Session> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            if (filters == null) filters = new List<FilterCondition>();
            filters.Add(new FilterCondition("deleted_at", CompOp.Equals, null));
            return factoryDAO.GetAllPagination(pageable, filters);
        }

        public Session GetById(object id)
        {
            return factoryDAO.GetById(id);
        }

        public void Update(Session item)
        {
            factoryDAO.Update(item);
        }
    }
}
