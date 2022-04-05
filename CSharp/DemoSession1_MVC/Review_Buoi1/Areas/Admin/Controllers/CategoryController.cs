using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Review_Buoi1.Models.Entities;

namespace Review_Buoi1.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/category")]
    public class CategoryController : Controller
    {
        private readonly ConnectDbContext _db;

        public CategoryController(ConnectDbContext db)
        {
            _db = db;
        }

        [HttpGet("index")]
        public IActionResult Index()
        {
            ViewBag.listCate = _db.Category.Where(p => p.ParentId == null).ToList();
            return View();
        }
    }
}