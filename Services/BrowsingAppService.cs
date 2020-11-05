using Microsoft.AspNetCore.Mvc.RazorPages;
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
            if (request.CategoryName != "AllProducts")
            {
                var filteredProductDb = _DbContext.Product
                .Where(s => s.CategoryName == request.CategoryName || request.CategoryName == null);
                var totalPages = filteredProductDb.Count() / request.PageSize;
                var result = filteredProductDb
                    .Skip((request.PageSize * (request.Page - 1)))
                    .Take(request.PageSize)
                    .Select(s => new GetProductsResponse.product
                    {
                        Name = s.ProductName,
                        Price = s.Price,
                        ProductId = s.ProductId,
                        ThumbnailUrl = s.ImageS.SingleOrDefault(p => p.IsThumbnail).ImageUrl
                    });
                return new GetProductsResponse
                {
                    TotalPages = totalPages,
                    Products = result.ToList()
                };
            }
            else
            {
                var filteredProductDb = _DbContext.Product;
                var totalPages = filteredProductDb.Count() / request.PageSize;
                var result = filteredProductDb
                    .Skip((request.PageSize * (request.Page - 1)))
                    .Take(request.PageSize)
                    .Select(s => new GetProductsResponse.product
                    {
                        Name = s.ProductName,
                        Price = s.Price,
                        ProductId = s.ProductId,
                        ThumbnailUrl = s.ImageS.SingleOrDefault(p => p.IsThumbnail).ImageUrl
                    });
                return new GetProductsResponse
                {
                    TotalPages = totalPages,
                    Products = result.ToList()
                };
            }
        }
    }
}

