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
    internal class IssueDAO : IDAO<Issue>
    {
        private readonly FactoryDAO<Issue> factoryDAO;

        public IssueDAO()
        {
            factoryDAO = new FactoryDAO<Issue>(DatabaseName.Issue);
        }

        public void Add(Issue item)
        {
            factoryDAO.Add(item);
        }

        public void Delete(int id)
        {
            factoryDAO.Delete(id);
        }

        public List<Issue> GetAll(List<FilterCondition> filters = null)
        {
            return factoryDAO.GetAll(filters);
        }

        public Page<Issue> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            return factoryDAO.GetAllPagination(pageable, filters);
        }

        public Issue GetById(int id)
        {
            return factoryDAO.GetById(id);
        }

        public void Update(Issue item)
        {
            factoryDAO.Update(item);
        }
    }
}
