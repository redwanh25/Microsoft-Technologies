using Microsoft.EntityFrameworkCore;
using Models;
using Models.DatabaseViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseContext
{
    public class CustomerDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        //public DbSet<Order> Orders { get; set; }
        //public DbSet<Shop> Shops { get; set; }
        //public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<VMCustomer> VMCustomers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Server=.; Database=DotNetCore_ProjectDB; Integrated Security=True";
                optionsBuilder.UseSqlServer(connectionString);
                //optionsBuilder.UseLazyLoadingProxies();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VMCustomer>().ToView("CUSTOMER_VIEW");
        }
    }
}
