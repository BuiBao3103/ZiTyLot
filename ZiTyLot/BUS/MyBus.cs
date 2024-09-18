using System;
using System.Collections.Generic;
using ZiTyLot.DAO;
using ZiTyLot.Helper;

namespace ZiTyLot.BUS
{
    public class MyBUS
    {
        private readonly MyDAO myDao;

        // Dependency Injection for MyDAO
        public MyBUS()
        {
            this.myDao = new MyDAO();
        }

        // Hàm lấy tất cả các bản ghi với filters (không phân trang và sắp xếp)
        public List<MyDTO> GetAll(List<FilterCondition> filters = null)
        {
            try
            {
                return myDao.GetAll(filters);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the data.", ex);
            }
        }

        // Hàm trả về đối tượng Page<MyDTO> với kết quả phân trang
        public Page<MyDTO> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            try
            {
                return myDao.GetAllPagination(pageable, filters);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the paginated data.", ex);
            }
        }

        // Hàm lấy bản ghi theo ID
        public MyDTO GetById(int id)
        {
            EnsureRecordExists(id); // Kiểm tra sự tồn tại của bản ghi

            try
            {
                return myDao.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the record by ID.", ex);
            }
        }

        // Hàm thêm bản ghi mới
        public void Add(MyDTO item)
        {
            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                myDao.Add(item);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding the record.", ex);
            }
        }

        // Hàm cập nhật bản ghi
        public void Update(MyDTO item)
        {
            EnsureRecordExists(item.Id); // Kiểm tra sự tồn tại của bản ghi

            Validate(item); // Kiểm tra tính hợp lệ của dữ liệu

            try
            {
                myDao.Update(item);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the record.", ex);
            }
        }

        // Hàm xóa bản ghi theo ID
        public void Delete(int id)
        {
            EnsureRecordExists(id); // Kiểm tra sự tồn tại của bản ghi

            try
            {
                myDao.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the record.", ex);
            }
        }

        // Hàm kiểm tra tính hợp lệ của bản ghi
        private void Validate(MyDTO item)
        {
            if (string.IsNullOrWhiteSpace(item.Name))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(item.Name));
            }

            // Add other validation rules as needed
        }

        // Kiểm tra sự tồn tại của bản ghi
        private void EnsureRecordExists(int id)
        {
            var existingItem = myDao.GetById(id);
            if (existingItem == null)
            {
                throw new KeyNotFoundException($"Record with ID {id} not found.");
            }
        }
    }
}
