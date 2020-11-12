using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SportsStore.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Authorize()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LogIn()
        {
            return View();
        }
    }
}
