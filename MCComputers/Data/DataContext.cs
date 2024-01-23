using MCComputers.Entities;
using Microsoft.EntityFrameworkCore;

namespace MCComputers.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {

        }
        public DbSet<Customer> Customers {  get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Invoices> Invoices { get; set; }

    }
}
