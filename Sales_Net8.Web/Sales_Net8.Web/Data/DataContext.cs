using Microsoft.EntityFrameworkCore;
using Sales_Net8.Web.Data.Entities;

namespace Sales_Net8.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
            
        }

        public DbSet<Country> Countries { get; set; }
    }
}
