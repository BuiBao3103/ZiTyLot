using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiTyLot.Helper;

namespace ZiTyLot.DAO
{
    public interface IDAO<T>
    {
        List<T> GetAll(List<FilterCondition> filters = null);
        Page<T> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null);
        T GetById(int id);
        void Add(T item);
        void Update(T item);
        void Delete(int id);
    }

}
