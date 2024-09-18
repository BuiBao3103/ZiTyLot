using System.Collections.Generic;
using ZiTyLot.Helper;
namespace ZiTyLot.DAO
{
    public class MyDAO
    {
        private readonly FactoryDAO<MyDTO> daoFactory;

        public MyDAO()
        {
            daoFactory = new FactoryDAO<MyDTO>("mys");
        }

        // Hàm lấy tất cả các bản ghi với điều kiện filters, không có phân trang hoặc sắp xếp
        public List<MyDTO> GetAll(List<FilterCondition> filters = null)
        {
            return daoFactory.GetAll(filters); // Sử dụng hàm GetAll từ FactoryDAO không phân trang
        }

        // Hàm trả về đối tượng Page<MyDTO> cho kết quả phân trang và sắp xếp
        public Page<MyDTO> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null)
        {
            // Sử dụng phương thức GetAllPagination từ FactoryDAO để lấy kết quả phân trang
            return daoFactory.GetAllPagination(pageable, filters);
        }

        // Hàm lấy bản ghi theo ID
        public MyDTO GetById(int id)
        {
            return daoFactory.GetById(id);
        }

        // Hàm thêm bản ghi mới
        public void Add(MyDTO item)
        {
            daoFactory.Add(item);
        }

        // Hàm cập nhật bản ghi
        public void Update(MyDTO item)
        {
            daoFactory.Update(item);
        }

        // Hàm xóa bản ghi theo ID
        public void Delete(int id)
        {
            daoFactory.Delete(id);
        }
    }
}
