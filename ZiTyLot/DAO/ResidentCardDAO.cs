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
    internal class ResidentCardDAO : IDAO<ResidentCard>
    {
        private readonly FactoryDAO<ResidentCard> factoryDAO;

        public ResidentCardDAO()
        {
            factoryDAO = new FactoryDAO<ResidentCard>(DatabaseName.ResidentCard);
        }

        public void Add(ResidentCard item)
        {
            factoryDAO.Add(item);
        }

        public void Delete(int id)
        {
            factoryDAO.Delete(id);
        }

        public List<ResidentCard> GetAll(List<FilterCondition> filters = null)
        {
            return factoryDAO.GetAll(filters);
        }

        public Page<ResidentCard> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            return factoryDAO.GetAllPagination(pageable, filters);
        }

        public ResidentCard GetById(int id)
        {
            return factoryDAO.GetById(id);
        }

        public void Update(ResidentCard item)
        {
            factoryDAO.Update(item);
        }
    }
}
