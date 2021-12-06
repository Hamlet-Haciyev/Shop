using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shop.Data;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            HomeRelated homeRelated = new HomeRelated();

            Banner banner = _appDbContext.Banners.FirstOrDefault();
            Setting setting = _appDbContext.Settings.FirstOrDefault();

            homeRelated.banner = banner;
            homeRelated.setting = setting;


            return View(homeRelated);
        }

        
    }
}
