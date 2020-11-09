using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsStore.Domain;
using SportsStore.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace SportsStore.ViewComponents
{
    public class CategoriesAndShoppingCartViewComponent : ViewComponent
    {
        private SportsStoreDbContext _dbcontex;
        public CategoriesAndShoppingCartViewComponent(SportsStoreDbContext dbContext)
        {
            _dbcontex = dbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
           
            var listofCategories = await _dbcontex.Category.ToListAsync();
            var listofShoppingCarts = await _dbcontex.ShoppingCarts.ToListAsync();
            var numberofrecords = listofShoppingCarts.Count();
            var ViewModel = new CategoriesAndShoppingCart
            {
                Category = listofCategories,
                NumberOfRecords = numberofrecords
            };
            return View(ViewModel);
        }
    }
    public class CategoriesAndShoppingCart
    {
        public List<Category> Category { get; set; }
        public int NumberOfRecords { get; set; }
    }
}
