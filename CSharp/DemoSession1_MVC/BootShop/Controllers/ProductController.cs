using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BootShop.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BootShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ConnectDbContext _db;

        public ProductController(ConnectDbContext db)
        {
            _db = db;
        }

        public IActionResult Details(int idProd)
        {
            var prod = _db.Product.SingleOrDefault(p => p.Id == idProd);
            return View("Details", prod);
        }
    }
}