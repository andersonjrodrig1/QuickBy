using Microsoft.EntityFrameworkCore;
using QuickBy.Dominio.Entities;
using QuickBy.Dominio.ObjectValue;
using QuickBy.Repositorio.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBy.Repositorio.Context
{
    public class QuickByContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ItemOrder> ItemOrders { get; set; }
        public DbSet<FormPayment> FormPayments { get; set; }

        public QuickByContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new ItemOrderConfiguration());
            modelBuilder.ApplyConfiguration(new FormPaymentConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
