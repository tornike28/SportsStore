using SportsStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Services.Delete
{
    public class DeleteAppService : IDeleteAppService
    {
        SportsStoreDbContext _DbContext;
        public DeleteAppService(SportsStoreDbContext dbContext)
        {
            _DbContext = dbContext;
        }
        public DeleteTableDataResponse DeleteTableData()
        {
            foreach (var item in _DbContext.ShoppingCarts.ToList())
            {
                _DbContext.ShoppingCarts.Remove(item);
            }
            _DbContext.SaveChanges();
            return new DeleteTableDataResponse { };
        }
    }
}
