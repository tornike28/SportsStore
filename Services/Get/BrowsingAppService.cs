using Microsoft.AspNetCore.Mvc.RazorPages;
using SportsStore.Domain;
using System;
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
        public GetPicturesResponse GetPictures(GetPicturesRequest request)
        {
            var resultPictures = _DbContext.ProductImages
                          .Where(s => s.ProductID == request.ProductId)
                          .Select(s => new GetPicturesResponse
                          {
                              ProductId = s.ProductID,
                              ImageUrls = s.ImageUrl
                          });
            return new GetPicturesResponse
            {
                Pictures = resultPictures.ToList()
            };
        }
        public GetProductsDetailsResponse GetPicturesDetails(GetProductsDetailsRequest request)
        {
            var resultProductsDetails = _DbContext.Product
                .Where(s => s.ProductId == request.ProductId)
                .Select(s => new GetProductsDetailsResponse.ProductDetails
                {
                    Description = s.Description,
                    ProductId = s.ProductId,
                    Name = s.ProductName,
                    Price = s.Price,
                });
            return new GetProductsDetailsResponse
            {
                ProductsDetails = resultProductsDetails.ToList()
            };
        }

        public GetProductsResponse GetProducts(GetProductsRequest request)
        {
            if (request.CategoryName != "AllProducts")
            {
                var filteredProductDb = _DbContext.Product
                .Where(s => s.CategoryName == request.CategoryName || request.CategoryName == null);
                int totalPages = filteredProductDb.Count() % request.PageSize > 0 ? filteredProductDb.Count() / request.PageSize + 1 : filteredProductDb.Count() / request.PageSize;
                var result = filteredProductDb
                    .Skip((request.PageSize * (request.Page - 1)))
                    .Take(request.PageSize)
                    .Select(s => new GetProductsResponse.product
                    {
                        Name = s.ProductName,
                        Price = s.Price,
                        ProductId = s.ProductId,
                        ThumbnailUrl = s.ImageS.SingleOrDefault(p => p.IsThumbnail).ImageUrl,
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
                        ThumbnailUrl = s.ImageS.SingleOrDefault(p => p.IsThumbnail).ImageUrl,
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

