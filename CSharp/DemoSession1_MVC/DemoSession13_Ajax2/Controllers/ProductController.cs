using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoSession13_Ajax2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DemoSession13_Ajax2.Controllers
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
            ViewBag.listProd = new ProductModel().FindAll();
            return View();
        }


        public IActionResult Search()
        {
            string term = HttpContext.Request.Query["term"].ToString();
            return new JsonResult(new ProductModel().FindProd(term).Select(p => p.Name).ToList());
        }

        [Route("product/result/{keyword}")]
        public IActionResult Result(string keyword)
        {
            var list = new ProductModel().FindProd(keyword).Select(p => p.Name).ToList();

            return View("Result", list);
        }

        [HttpPost]
        public IActionResult SearchByCategory(string category)
        {
            return new JsonResult(new ProductModel().SearchByCategory(category));
        }
    }
}