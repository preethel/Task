using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Models;
using Task.Repository.Abstraction.Base;

namespace Task.Repository.Abstraction
{
    public interface IProductRepository : IBaseRepository<Product>
    {
    }
}
