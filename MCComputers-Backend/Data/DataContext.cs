using MCComputers.Entities;
using Microsoft.EntityFrameworkCore;

namespace MCComputers.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {

        }
        public DbSet<InvoiceModel> Invoices { get; set; }

        public DbSet<CustomerModel> Customers { get; set; }

        public DbSet<ProductModel> Products { get; set; }

    }
}
