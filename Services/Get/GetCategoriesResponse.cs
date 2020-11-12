using System.Collections.Generic;
using System.Linq;

namespace SportsStore.services
{
    public class GetCategoriesResponse
    {
        public IQueryable<string> CategoriesName { get; internal set; }
    }
}