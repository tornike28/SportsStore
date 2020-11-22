using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using SportsStore.Domain;
using SportsStore.Models;
using SportsStore.Models.ViewModels;
using SportsStore.services;
using SportsStore.Services;
using SportsStore.Services.Delete;
using SportsStore.ViewModels;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        IbrowsingAppservice _BrowsingAppService;
        ICheckOutAppService _CheckOutAppService;
        IDeleteAppService _DeleteAppService;
        public HomeController(IbrowsingAppservice browsingAppService, ICheckOutAppService checkOutAppService, IDeleteAppService deleteAppService)
        {
            _BrowsingAppService = browsingAppService;
            _CheckOutAppService = checkOutAppService;
            _DeleteAppService = deleteAppService;
        }
        public IActionResult Index(string categoryName, int page = 1, string search = "")
        {
            var getProductsRespone = _BrowsingAppService.GetProducts(new services.GetProductsRequest
            {
                CategoryName = categoryName,
                Page = page,
                PageSize = 12,
                Searched = search
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
        [HttpPost]
        public IActionResult AddTocart(int productId)
        {
            var viewModel = _CheckOutAppService.AddToCart(new Services.AddToCartRequest
            {
                ProductId = productId
            });
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult InsideCart()
        {
            var viewModel = _BrowsingAppService.GetCartInfo();


            return View(viewModel);
        }
        [HttpGet]
        public IActionResult CheckOut()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CheckOut(CheckOutViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("AfterCheckOut");
            }
            return View();
        }
        public IActionResult AfterCheckOut()
        {
            return View();
        }
        public IActionResult DeleteCart()
        {
            _DeleteAppService.DeleteTableData();

            return RedirectToAction("Index");
        }
    }
}


