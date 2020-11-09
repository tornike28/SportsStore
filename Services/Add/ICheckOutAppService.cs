using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Services
{
    public interface ICheckOutAppService
    {
        public AddToCartResponse AddToCart(AddToCartRequest request);
    }
}
