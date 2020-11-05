using System.Collections.Generic;

namespace SportsStore.services
{
    public class GetProductsResponse
    {
        public class product
        {
            public int ProductId { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string ThumbnailUrl { get; set; }
            public int TotalPages { get; set; }

        }
        public List<product> Products { get; set; }
        public int TotalPages { get; set; }
        public string Mm { get; internal set; }
    }
}