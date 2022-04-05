using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TestCSharp.Models;
using TestCSharp.Models.Entities;

namespace TestCSharp.Controllers
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
            var listCustomer = _db.Customer.AsNoTracking().ToListAsync();
            return View(listCustomer);
        }


    }
}
