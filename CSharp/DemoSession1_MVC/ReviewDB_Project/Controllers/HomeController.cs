using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReviewDB_Project.Models;
using ReviewDB_Project.Models.Entities;
using ReviewDB_Project.Models.ModelViews;

namespace ReviewDB_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ReviewDBContext _db;

        public HomeController(ILogger<HomeController> logger, ReviewDBContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            var listCB = _db.ChuyenBay.Select(p => new ChuyenBay_View
            {
                Macb = p.Macb,
                Tencb = p.Tencb,
                Ngaydi = p.Ngaydi ?? DateTime.Now,
                Sogheloai1 = p.Sogheloai1 ?? 0,
                Giagheloai1 = p.Giagheloai1 ?? 0,
                Sogheloai2 = p.Sogheloai2 ?? 0,
                Giagheloai2 = p.Giagheloai2 ?? 0
            }).ToList();
            return View(listCB);
        }

    }
}
