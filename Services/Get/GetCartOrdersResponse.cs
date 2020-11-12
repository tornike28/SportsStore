using System;
using System.Linq;

namespace SportsStore.services
{
    public class GetCartOrdersResponse
    {
        public IQueryable<int> ProductId { get; set; }
    }
}