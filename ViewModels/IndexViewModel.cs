using SportsStore.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.ViewModels
{
    public class IndexViewModel
    {
        public GetProductsResponse ProductsResponse { get; set; }
        public string CategoryName { get; set; }
        public int PreviousPage { get; set; }
        public int NextPage { get; set; }
    }
}
