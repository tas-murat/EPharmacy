using EPharmacy.Core.Entities.Concrete;
using EPharmacy.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPharmacy.DataAccess.Concrete.EntityFramework.Contexts
{
    public class PharmacyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Data Source=.\SQLEXPRESS;Initial Catalog=PharmacyDb;Integrated Security=true;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Favorite>()
         .HasKey(m => new { m.ProductId, m.SellerId });
            modelBuilder.Entity<ProductCategory>()
         .HasKey(m => new { m.ProductId, m.CategoryId });
            modelBuilder.Entity<ProductProperty>()
         .HasKey(m => new { m.ProductId, m.PropertyId });
            modelBuilder.Entity<ProductTag>()
         .HasKey(m => new { m.ProductId, m.TagId });

            modelBuilder.Entity<Category>().HasData(new Category {Id=1,Name="Intial Category",PIndex=1 });
        }
        public DbSet<Logs> Logs { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<ProductTag> ProductTag { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Picture> Picture { get; set; }
        public DbSet<Property> Property { get; set; }
        public DbSet<ProductProperty> ProductProperty { get; set; }
        public DbSet<FAQ> FAQ { get; set; }
        public DbSet<FAQCategory> FAQCategory { get; set; }
        public DbSet<Contacte> Contacte { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Favorite> Favorite { get; set; }
        public DbSet<Advertisement> Advertisement { get; set; }
        public DbSet<Address> Address { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
    }
}
