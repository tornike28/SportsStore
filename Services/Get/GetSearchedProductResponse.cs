using System.Collections.Generic;

namespace SportsStore.services
{
    public class GetSearchedProductResponse
    {
        public int TotalPages { get; internal set; }
        internal List<Product> Products { get; set; }

        internal class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int ProductId { get; set; }
            public string ThumbnailUrl { get; set; }
        }
    }
}