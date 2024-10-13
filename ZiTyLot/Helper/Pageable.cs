using System;

namespace ZiTyLot.Helper
{
    public class Pageable
    {
        private int pageNumber = 1; // Đặt giá trị mặc định
        private int pageSize = 25;   // Đặt giá trị mặc định
        private string sortBy = string.Empty; // Giá trị mặc định là chuỗi rỗng
        private string sortOrder = "ASC";      // Giá trị mặc định là "ASC"

        public int PageNumber
        {
            get => pageNumber;
            set => pageNumber = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(PageNumber), "Page number must be greater than 0.");
        }

        public int PageSize
        {
            get => pageSize;
            set => pageSize = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(PageSize), "Page size must be greater than 0.");
        }

        public string SortBy
        {
            get => sortBy;
            set => sortBy = value ?? string.Empty; // Cung cấp giá trị mặc định nếu giá trị null
        }

        public string SortOrder
        {
            get => sortOrder;
            set => sortOrder = value ?? "ASC"; // Cung cấp giá trị mặc định nếu giá trị null
        }

        public int Offset()
        {
            return (PageNumber - 1) * PageSize;
        }
    }
}
