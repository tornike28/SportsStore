using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportsStore.Domain;
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
        public IActionResult Index(string categoryName, int page = 1)
        {
            var products = _BrowsingAppService.GetProducts(new services.GetProductsRequest
            {
                CategoryName = categoryName,
                Page = page,
                PageSize = 12
            });
              ViewBag.message = categoryName;
            ViewBag.nextPage = page+1;
            ViewBag.previousPage = page - 1;
            return View(products);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
