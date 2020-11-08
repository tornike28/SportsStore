using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportsStore.Domain;
using SportsStore.Models;
using SportsStore.services;
using SportsStore.ViewModels;

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
            var getProductsRespone = _BrowsingAppService.GetProducts(new services.GetProductsRequest
            {
                CategoryName = categoryName,
                Page = page,
                PageSize = 12
            });
            var ViewModel = new IndexViewModel
            {
                ProductsResponse = getProductsRespone,
                CategoryName = categoryName,
                PreviousPage = page - 1,
                NextPage = page + 1
            };

            return View(ViewModel);
        }
        public IActionResult Detail(int productId)
        {
            var getPictures = _BrowsingAppService.GetPictures(new services.GetPicturesRequest
            {
                ProductId = productId
            });
            var ViewModel = new DetailViewModel
            {
                PicturesResponse = getPictures,
                ProductsDetailResponse = _BrowsingAppService.GetPicturesDetails(new services.GetProductsDetailsRequest
                {
                    ProductId = productId

                })
            };
            return View(ViewModel);
        }
        public IActionResult AddTocart(int productId)
        {
            var viewModel= _BrowsingAppService.GetOrders(new services.GetOrderRequest
            {
                ProductId = productId
            });
            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
