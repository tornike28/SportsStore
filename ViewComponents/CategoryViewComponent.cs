//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using SportsStore.Domain;
//using SportsStore.services;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace SportsStore.ViewComponents
//{
//    public class CategoryViewComponent : ViewComponent
//    {
//        private SportsStoreDbContext _dbcontex;
//        public CategoryViewComponent(SportsStoreDbContext dbContext)
//        {
//            _dbcontex = dbContext;
//        }
//        public IViewComponentResult Invoke()
//        {
//            var listofCategory = _dbcontex.Category.ToList();
//            return View("Default", listofCategory);
//        }
//    }
//}
