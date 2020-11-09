using SportsStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Services
{
    public class CheckOutAppService : ICheckOutAppService
    {
        SportsStoreDbContext _DbContext;
        public CheckOutAppService(SportsStoreDbContext dbContext)
        {
            _DbContext = dbContext;
        }
        public AddToCartResponse AddToCart(AddToCartRequest request)
        {
            _DbContext.ShoppingCarts.Add(new ShoppingCart
            {
                ProductId = request.ProductId,
                OrderRegistrationDate = DateTime.Now
            });
            _DbContext.SaveChanges();
            return new AddToCartResponse
            {
                NumberOfRecords = _DbContext.ShoppingCarts.Count()
            };
        }
    }
}
