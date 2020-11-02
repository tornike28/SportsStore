using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Domain
{
    public class Category
    {
        public int CategoryId { get; set; }
        public String CategoryName { get; set; }
        public Category(
            int categoryId,
            string categoryName)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
        }
    }
}
