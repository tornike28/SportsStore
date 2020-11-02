using SportsStore.Domain;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace SportsStore.services
{
    public class BrowsingAppService : IbrowsingAppservice
    {
        SportsStoreDbContext _DbContext;
        public BrowsingAppService(SportsStoreDbContext dbContext)
        {
            _DbContext = dbContext;
        }
        public GetCategoriesResponse GetCategories(GetCategoriesRequest request)
        {
            throw new System.NotImplementedException();
        }

        public GetProductsResponse GetProducts(GetProductsRequest request)
        {
            var result = _DbContext.Product
                .Where(s => s.CategoryName == request.CategoryName || request.CategoryName == null)
                .Select(s=>new GetProductsResponse
                {
                    Name =s.ProductName,
                    Price=s.Price,
                    ProductId=s.ProductId,
                    ThumbnailUrl=s.ImageS.SingleOrDefault(p=>p.IsThumbnail).ImageUrl
                });
            return new GetProductsResponse
            {
                products = result.ToList()
            };
        }
    }
}
