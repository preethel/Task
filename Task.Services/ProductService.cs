using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Models;
using Task.Repository.Abstraction;
using Task.Services.Abstraction;
using Task.Services.Base;

namespace Task.Services
{
    public class ProductService : BaseService<Product>, IProductService
    {
        public ProductService(IProductRepository productRepository) : base(productRepository) { }
        
    }
}
