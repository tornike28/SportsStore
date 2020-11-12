using System;
using System.Collections.Generic;

namespace SportsStore.services
{
    public class GetCartInfoResponse
    {
        public int Id { get; set; }
        public DateTime OrderRegistrationDate { get; set; }
        public string ProductName { get; set; }
        public decimal price { get; set; }
        public int ProductId { get; internal set; }
        public IEnumerable<GetCartInfoResponse> CartInfo { get; internal set; }
        public decimal TotalPrice { get; internal set; }
    }
}