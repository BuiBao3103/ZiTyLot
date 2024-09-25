using System;
using System.Collections.Generic;
using ZiTyLot.ENTITY;
using ZiTyLot.Helper;

namespace ZiTyLot.DAO
{
    public class BDAO : IDAO<B>
    {
        private readonly FactoryDAO<B> daoFactory;
        public BDAO()
        {
            daoFactory = new FactoryDAO<B>("b");
        }
        public void Add(B item)
        {
            daoFactory.Add(item);
        }

        public void Delete(int id)
        {
            daoFactory.Delete(id);
        }

        public List<B> GetAll(List<FilterCondition> filters = null)
        {
            return daoFactory.GetAll(filters);
        }

        public Page<B> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            return daoFactory.GetAllPagination(pageable, filters);
        }

        public B GetById(int id)
        {
            return daoFactory.GetById(id);
        }

        public void Update(B item)
        {
            daoFactory.Update(item);
        }

        public B PopulationA (B b)
        {
            return new B();
        }

    }
}
