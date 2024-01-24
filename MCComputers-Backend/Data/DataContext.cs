using MCComputers.Entities;
using Microsoft.EntityFrameworkCore;

namespace MCComputers.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {

        }
        public DbSet<Invoices> Invoices { get; set; }

    }
}
