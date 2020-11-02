using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.services
{
    public interface IbrowsingAppservice
    {
        public GetProductsResponse GetProducts(GetProductsRequest request);
        public GetCategoriesResponse GetCategories(GetCategoriesRequest request);

    }
}
