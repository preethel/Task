using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Models;
using Task.Repository.Abstraction.Base;

namespace Task.Services.Abstraction
{
    public interface IProductService : IBaseRepository<Product>
    {
    }
}
