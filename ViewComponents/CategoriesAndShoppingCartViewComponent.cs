using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsStore.Domain;
using SportsStore.services;
using SportsStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace SportsStore.ViewComponents
{
    public class CategoriesAndShoppingCartViewComponent : ViewComponent
    {
        private IbrowsingAppservice _AppService;
        public CategoriesAndShoppingCartViewComponent(IbrowsingAppservice appservice)
        {
            _AppService = appservice;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofCategories = await _AppService.GetCategories().CategoriesName.ToListAsync();
            var listofShoppingCarts = await _AppService.GetCartOrders().ProductId.ToListAsync();
            var numberofrecords = listofShoppingCarts.Count();
            var viewModel = new CategoriesAndShoppingCart
            {
                Category = listofCategories,
                NumberOfRecords = numberofrecords
            };
            return View(viewModel);
        }
    }

}