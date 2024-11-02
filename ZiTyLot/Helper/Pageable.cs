using System;
using System.Collections.Generic;

namespace ZiTyLot.Helper
{
    public class Pageable
    {
        private int pageNumber = 1;
        private int pageSize = 10;
        private string sortBy = string.Empty;
        private string sortOrder = "ASC";// ASC or DESC
        public readonly List<string> PageNumbersInit  = new List<string>() { "3", "25", "50", "100" };

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
            set => sortBy = value ?? string.Empty; 
        }

        public string SortOrder
        {
            get => sortOrder;
            set => sortOrder = value ?? "ASC";
        }

        public int Offset()
        {
            return (PageNumber - 1) * PageSize;
        }



    }

}
