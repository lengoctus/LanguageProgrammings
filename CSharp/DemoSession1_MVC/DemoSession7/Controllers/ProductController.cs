using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DemoSession7.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }


        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(string keyword)
        {

            return View("Index");
        }


        [HttpPost]
        public IActionResult UpdateCart(int[] Quantity)
        {
            ViewBag.total = Quantity;
            return View("Index");
        }
    }
}
