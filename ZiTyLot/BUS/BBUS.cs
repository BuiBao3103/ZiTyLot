using System;
using System.Collections.Generic;
using System.Linq;
using ZiTyLot.DAO;
using ZiTyLot.ENTITY;
using ZiTyLot.Helper;

namespace ZiTyLot.BUS
{
    public class BBUS : IBUS<B>
    {
        private readonly BDAO bDAO;
        private readonly ADAO aDAO;
        public BBUS()
        {
            bDAO = new BDAO();
            aDAO = new ADAO();
        }

        public void Add(B item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<B> GetAll(List<FilterCondition> filters = null)
        {
            try
            {
                return bDAO.GetAll(filters);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the data.", ex);
            }
        }

        public Page<B> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            throw new NotImplementedException();
        }

        public B GetById(int id)
        {
            try
            {
                return bDAO.GetById(id);
            }catch(Exception ex)
            {
                throw new Exception("An error occurred while fetching the data.", ex);
            }
        }

        public void Update(B item)
        {
            throw new NotImplementedException();
        }

        public B PopulationA(B b)
        {
            A a = aDAO.GetById(b.A_id);
            b.A = a;
            return b;
        }
    }
}
