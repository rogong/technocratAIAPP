
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Search> Searches { get; set; }
        public DbSet<Brand> Brands { get; set; }
        
    }
}