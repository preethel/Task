using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Repository.Abstraction.Base;
using Task.Services.Abstraction.Base;

namespace Task.Services.Base
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly IBaseRepository<T> _repository;

        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        public bool Add(T item)
        {
            if(_repository.Add(item)) return true;
            return false;
        }

        public ICollection<T> GetAll()
        {
            return _repository.GetAll();
        }

        public bool Remove(int id)
        {
            if (_repository.Remove(id)) return true;
            return false;
        }
        
        public T GetById(int id)
        {
            return _repository.GetById(id);
        }
        public bool Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
