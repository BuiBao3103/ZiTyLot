using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiTyLot.Helper
{
    public class Page<T>
    {
        public List<T> Content { get; set; }
        public int TotalElements { get; set; }
        public int TotalPages { get; set; }
        public Pageable Pageable { get; set; }

        public Page(List<T> content, int totalElements, Pageable pageable)
        {
            Content = content;
            TotalElements = totalElements;
            Pageable = pageable;
            TotalPages = CalculateTotalPages();
        }

        private int CalculateTotalPages()
        {
            return (int)Math.Ceiling((double)TotalElements / Pageable.PageSize);
        }
    }


}
