using System.Collections.Generic;
using ZiTyLot.Helper;
namespace ZiTyLot.BUS
{
    public interface IBUS<T>
    {
        List<T> GetAll(List<FilterCondition> filters = null);
        Page<T> GetAllPagination(Pageable pageable, List<FilterCondition> filters = null);
        T GetById(object id);
        void Add(T item);
        void Update(T item);
        void Delete(object id);
    }
}
