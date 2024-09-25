using System.Collections.Generic;
using ZiTyLot.Helper;
using ZiTyLot.ENTITY;
namespace ZiTyLot.DAO
{
    public class ADAO : IDAO<A>
    {
        private readonly FactoryDAO<A> daoFactory;

        public ADAO()
        {
            daoFactory = new FactoryDAO<A>("a_entitys");
        }

        public List<A> GetAll(List<FilterCondition> filters = null)
        {
            return daoFactory.GetAll(filters);
        }

        public Page<A> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            return daoFactory.GetAllPagination(pageable, filters);
        }

        public A GetById(int id)
        {
            return daoFactory.GetById(id);
        }

        public void Add(A item)
        {
            daoFactory.Add(item);
        }

        public void Update(A item)
        {
            daoFactory.Update(item);
        }

        public void Delete(int id)
        {
            daoFactory.Delete(id);
        }
    }
}
