using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Repository.Abstraction.Base;

namespace Task.Repository.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly DbContext _db;
        public BaseRepository(DbContext db)
        {
            _db = db;
        }
        public bool Add(T item)
        {
            _db.Set<T>().Add(item);
            return _db.SaveChanges()>0;
            
        }

        public ICollection<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }
        public T GetById(int id)
        {
            return _db.Set<T>().Find(id);
        }
        public bool Remove(int id)
        {
            _db.Set<T>().Remove(_db.Set<T>().Find(id));
            return _db.SaveChanges() > 0;
        }

        public bool Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
