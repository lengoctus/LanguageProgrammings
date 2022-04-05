using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Review_Buoi1.Repositories;

namespace Review_Buoi1.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/product")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _Iprod;

        public ProductController(IProductRepository iprod)
        {
            _Iprod = iprod;
        }

        [HttpGet("index")]
        public IActionResult Index()
        {
            var prod = _Iprod.Search("P").ToList();
           
            return View();
        }
    }
}