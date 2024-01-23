﻿using MCComputers.Entities;
using Microsoft.EntityFrameworkCore;

namespace MCComputers.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {

        }
        public DbSet<Customer> Customers {  get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Invoices> Invoices { get; set; }

    }
}
