using Task.Database;
using Task.Models;
using Task.Repository.Abstraction;
using Task.Repository.Base;

namespace Task.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db) 
        { 
        
            _db = db;
        }
        
    }
}
