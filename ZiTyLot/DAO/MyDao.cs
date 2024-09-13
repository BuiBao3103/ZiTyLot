

namespace ZiTyLot.DAO
{
    using System.Collections.Generic;
    public class MyDao
    {
        private readonly DaoFactory<MyDto> _daoFactory;

        public MyDao()
        {
            _daoFactory = new DaoFactory<MyDto>("MyTable");
        }

        public int GetTotalRecordCount(Dictionary<string, object> filters = null)
        {
            return _daoFactory.GetTotalRecordCount(filters);
        }

        public List<MyDto> GetAll(int pageNumber, int pageSize, string sortBy = null, string sortOrder = null, Dictionary<string, object> filters = null)
        {
            return _daoFactory.GetPaginatedData(pageNumber, pageSize, sortBy, sortOrder, filters);
        }

        public MyDto GetById(int id)
        {
            return _daoFactory.GetById(id);
        }

        public void Add(MyDto item)
        {
            _daoFactory.Add(item);
        }

        public void Update(MyDto item)
        {
            _daoFactory.Update(item);
        }

        public void Delete(int id)
        {
            _daoFactory.Delete(id);
        }

        public int CalculateTotalPages(int totalRecords, int pageSize)
        {
            return _daoFactory.CalculateTotalPages(totalRecords, pageSize);
        }
    }
}
