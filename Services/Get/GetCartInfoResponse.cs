using System;
using System.Collections.Generic;
using System.Linq;

namespace SportsStore.services
{
    public class GetCartInfoResponse
    {

        public int Id { get; set; }
        public DateTime OrderRegistrationDate { get; set; }
        public string ProductName { get; set; }
        public decimal price { get; set; }
        public int ProductId { get; internal set; }

        public IQueryable<DataTableClass> CartInfo { get; set; }
        public decimal TotalPriceOfCart { get; internal set; }
    }
}