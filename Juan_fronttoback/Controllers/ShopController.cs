using Juan_fronttoback.DAL;
using Juan_fronttoback.Models;
using Juan_fronttoback.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan_fronttoback.Controllers
{
    public class ShopController : Controller
    {
        private AppDbContext _db { get; }
        public ShopController(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index(int? page)
        {
            //ShopVM shop = new ShopVM
            //{
            //    ShopProducts = _db.ShopProducts.Include(p => p.Image).Take(12).ToList()

            //};
            //var query = _db.ShopProducts.AsNoTracking().OrderBy(s => s.Price);
            var pageNumber = page ?? 1;
            int pageSize = 10;
            var onePageOfProducts =DAL.AppDbContext.ShopProducts.ToPagedList(pageNumber, pageSize);
            return View(model);
        }
        public IActionResult LoadProducts()
        {
            List<ShopProducts> shopProducts = _db.ShopProducts.Include(p => p.Image).Take(12).ToList();
            return Json(shopProducts);

        }
    }
}
