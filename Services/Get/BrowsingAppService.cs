using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.IdentityModel.Protocols;
using SportsStore.Domain;
using System;
using System.Configuration;
using System.Data;
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

        public GetCartInfoResponse GetCartInfo()
        {
            var result = from a in _DbContext.ShoppingCarts
                         join b in _DbContext.Product
                         on a.ProductId equals b.ProductId
                         select new GetCartInfoResponse
                         {
                             Id = a.Id,
                             OrderRegistrationDate = a.OrderRegistrationDate,
                             ProductName = b.ProductName,
                             price = b.Price,
                             ProductId = b.ProductId,
                         };
            var result2 = result.GroupBy(s => new { s.ProductId, s.ProductName, s.price }).Select(s => new DataTableClass
            {
                ProductId = s.Key.ProductId,
                Count = s.Count(),
                ProductName = s.Key.ProductName,
                Price = s.Key.price,
                TotalPrice = s.Key.price * s.Count()

            });
            return new GetCartInfoResponse
            {
                CartInfo = result2,
                TotalPriceOfCart = result.Select(s => s.price).Sum(),
            };

        }

        public GetCartOrdersResponse GetCartOrders()
        {
            var shoppingCarts = _DbContext.ShoppingCarts.Select(s => s.ProductId);
            return new GetCartOrdersResponse
            {
                ProductId = shoppingCarts
            };
        }

        public GetCategoriesResponse GetCategories()
        {
            var categories = _DbContext.Category.Select(S => S.CategoryName);
            return new GetCategoriesResponse
            {
                CategoriesName = categories
            };
        }

        public GetPicturesResponse GetPictures(GetPicturesRequest request)
        {
            var pictures = _DbContext.ProductImages
                          .Where(s => s.ProductID == request.ProductId)
                          .Select(s => new GetPicturesResponse
                          {
                              ProductId = s.ProductID,
                              ImageUrls = s.ImageUrl
                          });
            return new GetPicturesResponse
            {
                Pictures = pictures.ToList()
            };
        }

        public GetProductsDetailsResponse GetPicturesDetails(GetProductsDetailsRequest request)
        {
            var productsDetails = _DbContext.Product
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
                ProductsDetails = productsDetails.ToList()
            };
        }

        public GetProductsResponse GetProducts(GetProductsRequest request)
        {
            if (request.CategoryName != "AllProducts" && request.Searched == "")
            {
                var filteredProductDb = _DbContext.Product
                .Where(s => (s.CategoryName == request.CategoryName || request.CategoryName == null));
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
            else if (request.CategoryName == "AllProducts" && request.Searched == "")
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
            else if (request.CategoryName == "AllProducts" && request.Searched != "")
            {
                var filteredProductDb = _DbContext.Product.Where(s => s.ProductName.Contains(request.Searched));
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
            else
            {
                var filteredProductDb = _DbContext.Product
               .Where(s => (s.CategoryName == request.CategoryName || request.CategoryName == null) && s.ProductName.Contains(request.Searched));
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
        }
    }
}

