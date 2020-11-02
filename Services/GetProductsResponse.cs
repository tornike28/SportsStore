using System.Collections;
using System.Collections.Generic;

namespace SportsStore.services
{
    public class GetProductsResponse
    {
            public int ProductId { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string ThumbnailUrl { get; set; }
        public List<GetProductsResponse> products { get; internal set; }
    }
}