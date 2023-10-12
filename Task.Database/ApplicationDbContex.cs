using Microsoft.EntityFrameworkCore;
using Task.Models;

namespace Task.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }

    }
}