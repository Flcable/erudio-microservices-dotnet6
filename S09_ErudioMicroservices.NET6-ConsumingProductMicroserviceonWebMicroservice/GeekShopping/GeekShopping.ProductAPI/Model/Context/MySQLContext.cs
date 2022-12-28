using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() {}

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}
        public DbSet<Product> Products { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Name",
                price = new decimal(69.9),
                Description = "Description",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/1_super_mario.jpg?raw=true",
                CategoryName = "Category",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Name",
                price = new decimal(69.9),
                Description = "Description",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/1_super_mario.jpg?raw=true",
                CategoryName = "Category",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Name",
                price = new decimal(69.9),
                Description = "Description",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/1_super_mario.jpg?raw=true",
                CategoryName = "Category",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Name",
                price = new decimal(769.9),
                Description = "Description",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/1_super_mario.jpg?raw=true",
                CategoryName = "Category",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Name",
                price = new decimal(369.9),
                Description = "Description",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/1_super_mario.jpg?raw=true",
                CategoryName = "Category",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Name",
                price = new decimal(699.9),
                Description = "Description",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/1_super_mario.jpg?raw=true",
                CategoryName = "Category",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Name",
                price = new decimal(689.9),
                Description = "Description",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/1_super_mario.jpg?raw=true",
                CategoryName = "Category",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Name",
                price = new decimal(869.9),
                Description = "Description",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/1_super_mario.jpg?raw=true",
                CategoryName = "Category",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Name",
                price = new decimal(9.9),
                Description = "Description",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/1_super_mario.jpg?raw=true",
                CategoryName = "Category",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Name",
                price = new decimal(169.9),
                Description = "Description",
                ImageURL = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/1_super_mario.jpg?raw=true",
                CategoryName = "Category",
            });

        }

    }
}
