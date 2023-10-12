using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Repository.Abstraction.Base
{
    public interface IBaseRepository<T> where T : class
    {
        ICollection<T> GetAll();
        bool Add(T item);
        bool Update(T item);
        bool Remove(int id);
        T GetById(int id);
        //bool AddRange(IEnumerable<T> items);
        //bool UpdateRange(IEnumerable<T> items);
    }
}
