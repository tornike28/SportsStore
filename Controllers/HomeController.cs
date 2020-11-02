using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportsStore.Models;
using SportsStore.services;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        IbrowsingAppservice _BrowsingAppService;
        public HomeController(IbrowsingAppservice browsingAppService)
        {
            _BrowsingAppService = browsingAppService;
        }
        public IActionResult Index(string categoryName)
        {
            var products = _BrowsingAppService.GetProducts(new services.GetProductsRequest
            {
                CategoryName = categoryName
            }); ;
            return View(products);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
