using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Domain
{
    public class SportsStoreDbContext : DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Product> products = new List<Product>();
            List<Category> categories = new List<Category>();
            List<ProductImage> images = new List<ProductImage>();
            List<String> categoryNames = new List<string>() { "Basketball", "Football", "LifeStyle", "baseball", "Running" };
            List<ShoppingCart> shoppingCarts = new List<ShoppingCart>();

            Random rnd = new Random();
           
            categories.Add(new Category(1, ("Basketball")));
            categories.Add(new Category(2, ("Football")));
            categories.Add(new Category(3, ("LifeStyle")));
            categories.Add(new Category(4, ("baseball")));
            categories.Add(new Category(5, ("Running")));
            for (int i = 1; i < 101; i++)
            {
                var index = rnd.Next(categoryNames.Count);
                products.Add(new Product(i, ("product " + i), (i + 100 + 30 * i), ("Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. " + i), categoryNames[index],index+1));
            }
            for (int i = 1; i < 402; i++)
            {images.Add(new ProductImage(i, rnd.Next(1, 100), "https://via.placeholder.com/300" ,true));
            }
            modelBuilder.Entity<Product>().HasData(products);
            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<ProductImage>().HasData(images);
            modelBuilder.Entity<ShoppingCart>().HasData(shoppingCarts);
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-EKVE342;Database=SportsStore;user=sa;Password=Pa55w.rd");
        }
    }
}
