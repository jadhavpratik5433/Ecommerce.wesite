using Ecommerce.Model;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.ProductService.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options): base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 1, Name = "Pratik", Quantity = 20, Price = 12 });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 2, Name = "sanket", Quantity = 50, Price = 12 });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 3, Name = "raj", Quantity = 30, Price = 12 });
            base.OnModelCreating(modelBuilder);


        }
}
