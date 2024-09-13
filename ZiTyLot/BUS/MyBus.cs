namespace ZiTyLot.BUS
{
    using System;
    using System.Collections.Generic;
    using ZiTyLot.DAO;
    public class MyBus
    {
        private readonly MyDao _myDao;

        public MyBus()
        {
            _myDao = new MyDao();
        }

        public int GetTotalRecordCount(Dictionary<string, object> filters = null)
        {
            try
            {
                return _myDao.GetTotalRecordCount(filters);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the total record count.", ex);
            }
        }

        public List<MyDto> GetAll(int pageNumber, int pageSize, string sortBy = null, string sortOrder = null, Dictionary<string, object> filters = null)
        {
            try
            {
                return _myDao.GetAll(pageNumber, pageSize, sortBy, sortOrder, filters);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the data.", ex);
            }
        }

        public MyDto GetById(int id)
        {
            try
            {
                return _myDao.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the record by ID.", ex);
            }
        }

        public void Add(MyDto item)
        {
            try
            {
                Validate(item);
                _myDao.Add(item);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding the record.", ex);
            }
        }

        public void Update(MyDto item)
        {
            try
            {
                Validate(item);
                _myDao.Update(item);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the record.", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _myDao.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the record.", ex);
            }
        }

        private void Validate(MyDto item)
        {
            if (string.IsNullOrWhiteSpace(item.Name))
            {
                throw new ArgumentException("Name cannot be null or empty.");
            }

            // Add other validation rules as needed
        }
    }

}
