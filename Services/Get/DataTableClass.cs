using System.Linq;

namespace SportsStore.services
{
    public class DataTableClass
    { 
        public int ProductId { get; set; }
        public int Count { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
    }
}