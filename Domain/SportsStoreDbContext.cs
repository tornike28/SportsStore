using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportsStore.Domain;

namespace SportsStore.Domain
{
    public class SportsStoreDbContext : IdentityDbContext
    {

        public SportsStoreDbContext(DbContextOptions<SportsStoreDbContext> options)
             : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customers");
            List<Product> products = new List<Product>();
            List<Category> categories = new List<Category>();
            List<ProductImage> images = new List<ProductImage>();
            List<String> categoryNames = new List<string>() { "Basketball", "Football", "LifeStyle", "baseball", "Running" };
            List<ShoppingCart> shoppingCarts = new List<ShoppingCart>();
            List<string> ImageUrls = new List<string>()
            {"https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/eabcbd62-9fd9-4988-83c4-9f33feea1cf1/air-force-1-07-lv8-mens-shoe-qgfv2t.jpg ",
            "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b103bbdd-32f0-4efa-a628-15af7e5bba65/air-max-2090-mens-shoe-3pVM46.jpg ",
            "https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-mens-shoe-3pVM46.jpg ",
            " https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/i1-59339575-65c0-4712-b93f-7dfd84265678/air-max-2090-mens-shoe-3pVM46.jpg",
            "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/i1-b35e6bde-7040-49e6-96bb-6710505b33f2/air-max-2090-mens-shoe-3pVM46.jpg "
            };
            Random rnd = new Random();

            categories.Add(new Category(1, ("Basketball")));
            categories.Add(new Category(2, ("Football")));
            categories.Add(new Category(3, ("LifeStyle")));
            categories.Add(new Category(4, ("baseball")));
            categories.Add(new Category(5, ("Running")));
            for (int i = 1; i < 101; i++)
            {
                var index = rnd.Next(categoryNames.Count);
                products.Add(new Product(i, ("product " + i), (i + 100 + 30 * i), ("Reinvigorate your stride with the Nike Air Zoom Pegasus 37. Delivering the same fit and feel that runners love, the shoe has an all-new forefoot cushioning unit and foam for maximum responsiveness. The result is a durable, lightweight trainer designed for everyday running. " + i), categoryNames[index], index + 1));
            }
            for (int i = 1; i < 402; i++)
            {
                images.Add(new ProductImage(i, rnd.Next(1, 100), ImageUrls[rnd.Next(1, 5)], true));
            }
            modelBuilder.Entity<Product>().HasData(products);
            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<ProductImage>().HasData(images);
            modelBuilder.Entity<ShoppingCart>().HasData(shoppingCarts);
            base.OnModelCreating(modelBuilder);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-EKVE342;Database=SportsStore;user=sa;Password=Pa55w.rd;multipleactiveresultsets=true");
        }
        public DbSet<SportsStore.Domain.Customer> Customer { get; set; }
    }
}
