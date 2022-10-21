using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Caneca R2D2",
                Description = "Caneca R2D2",
                CategoryName = "CANECA",
                Price = new decimal(39.90),
                ImageURL = "D:\\Ricardo\\Cursos\\Udemy\\GeekShopping\\GeekShopping\\GeekShopping.ProductAPI\\Image\\41MIxdiEcDL._AC_.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Caneca R2D2",
                Description = "Caneca R2D2",
                CategoryName = "CANECA",
                Price = new decimal(39.90),
                ImageURL = "D:\\Ricardo\\Cursos\\Udemy\\GeekShopping\\GeekShopping\\GeekShopping.ProductAPI\\Image\\41MIxdiEcDL._AC_.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Caneca R2D2",
                Description = "Caneca R2D2",
                CategoryName = "CANECA",
                Price = new decimal(39.90),
                ImageURL = "D:\\Ricardo\\Cursos\\Udemy\\GeekShopping\\GeekShopping\\GeekShopping.ProductAPI\\Image\\41MIxdiEcDL._AC_.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Caneca R2D2",
                Description = "Caneca R2D2",
                CategoryName = "CANECA",
                Price = new decimal(39.90),
                ImageURL = "D:\\Ricardo\\Cursos\\Udemy\\GeekShopping\\GeekShopping\\GeekShopping.ProductAPI\\Image\\41MIxdiEcDL._AC_.jpg"
            });
        }
    }
}
