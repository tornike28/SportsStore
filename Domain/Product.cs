using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Domain
{
    public class Product
    {  
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public String CategoryName { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductImage> ImageS { get; set; }
        public Product(
            int productId,
            string productName,
            decimal price,
            string description,
            String categoryName,
            int categoryId)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            Description = description;
            CategoryName = categoryName;
            CategoryId = categoryId;
        }
    }
}

