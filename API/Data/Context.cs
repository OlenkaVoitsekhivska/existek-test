using System.Text.Json;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            var productsJson = System.IO.File.ReadAllText("../API/Data/products.json");
            var products = JsonSerializer.Deserialize<List<Product>>(productsJson, options);


            builder.Entity<Product>().HasData(products!);
        }
    }
}