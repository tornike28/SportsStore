using System.Collections.Generic;
using System.Linq;

namespace SportsStore.services
{
    public class GetProductsDetailsResponse
    {
        public List<ProductDetails> ProductsDetails { get; internal set; }

        public class ProductDetails
        {
            public int ProductId { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string Description { get; set; }
        }
    }
}