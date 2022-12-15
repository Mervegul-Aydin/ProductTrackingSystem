using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ProductTrackingSystem.Core.Models;

namespace MyJeweleryShop.Repository.AppDbContexts.AppDbContext
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) //constructor yaptık. 
        {   
        }
        public DbSet<Category> Categories { get; set; }

        public DbSet<ProductBrands> ProductBrands { get; set; }

        public DbSet<ProductColors> ProductColors { get; set; }

        public DbSet<ProductFeatures> ProductFeatures { get; set; }

        public DbSet<ProductMeasurementUnits> ProductMeasurementUnits { get; set; }

        public DbSet<Products> Products { get; set; }
              
        public DbSet<ProductVatUnits> ProductVatUnits { get; set; }

       

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

    }
}
