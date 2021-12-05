using Microsoft.EntityFrameworkCore;
using OrderProject.Core.Models;
using OrderProject.Data.Configurations;
using OrderProject.Data.Seeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base
            (options)
        {

        }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //ProductConfiguration içinde yaptığım tablo kolon özelliklerini burada da yapabilirdim ama bu alanı temiz tutmak adına ayrı bir class içinde  yazıldı..
            modelBuilder.ApplyConfiguration(new OrderConfiguration());

            modelBuilder.ApplyConfiguration(new OrderSeed(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }));

        }
    }
}
