using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //context: db tabloları ile proje classlarını bağlamak
    public class CarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Car;Trusted_Connection=true");
        }
        public DbSet<Car> Car { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Rental> Rentals { get; set; }
        public DbSet<CarImage> CarImage { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<Core.Entities.Concrete.User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }

    }
}
