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
    internal class ImageDAO : IDAO<Image>
    {
        private readonly FactoryDAO<Image> factoryDAO;

        public ImageDAO()
        {
            factoryDAO = new FactoryDAO<Image>(DatabaseName.Image);
        }

        public void Add(Image item)
        {
            factoryDAO.Add(item);
        }

        public void Delete(object id)
        {
            factoryDAO.Delete(id);
        }

        public List<Image> GetAll(List<FilterCondition> filters = null)
        {
            if (filters == null) filters = new List<FilterCondition>();
            filters.Add(new FilterCondition("deleted_at", CompOp.Equals, null));
            return factoryDAO.GetAll(filters);
        }

        public Page<Image> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            if (filters == null) filters = new List<FilterCondition>();
            filters.Add(new FilterCondition("deleted_at", CompOp.Equals, null));
            return factoryDAO.GetAllPagination(pageable, filters);
        }

        public Image GetById(object id)
        {
            return factoryDAO.GetById(id);
        }

        public void Update(Image item)
        {
            factoryDAO.Update(item);
        }
    }
}
