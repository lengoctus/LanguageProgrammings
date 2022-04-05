using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BootShop.Models;
using BootShop.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BootShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ConnectDbContext _db;

        public HomeController(ILogger<HomeController> logger, ConnectDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            ViewBag.listProd = _db.Product.AsNoTracking().Where(p => p.Status == true).OrderByDescending(p => p.Id).Take(6).ToList();
            ViewBag.ishome = true;
            return View();
        }

    }
}
