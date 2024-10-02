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

        public void Delete(int id)
        {
            factoryDAO.Delete(id);
        }

        public List<Session> GetAll(List<FilterCondition> filters = null)
        {
            return factoryDAO.GetAll(filters);
        }

        public Page<Session> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            return factoryDAO.GetAllPagination(pageable, filters);
        }

        public Session GetById(int id)
        {
            return factoryDAO.GetById(id);
        }

        public void Update(Session item)
        {
            factoryDAO.Update(item);
        }
    }
}
