using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoSession13_Ajax.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DemoSession13_Ajax.Controllers
{
    public class DemoController : Controller
    {
        private readonly ILogger<DemoController> _logger;

        public DemoController(ILogger<DemoController> logger) 
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Demo1()
        {

            return new JsonResult("Hello");
        }

        [HttpGet]
        public IActionResult Demo2(string fullname)
        {

            return new JsonResult(fullname);
        }



        [HttpPost]
        public IActionResult Demo3(string fullname, string email)
        {

            return new JsonResult(fullname + " -- " + email);
        }


        public IActionResult Demo4(string fullname)
        {
            if (fullname.Trim() == "ngoctu")
            {
                return new JsonResult("Da ton tai !!");
            }
            return new JsonResult("OK");
        }


        public IActionResult Demo5()
        {
            var prod = new Product
            {
                Id = 1,
                Name = "Banh Chung",
                Price = 5000
            };
            return new JsonResult(prod);
        }

        public IActionResult Demo6()
        {
            var prod = new List<Product>
            {
                new Product
                {
                Id = 1,
                Name = "Banh Chung",
                Price = 5000
            },
                new Product
            {
                Id = 1,
                Name = "Banh Chung",
                Price = 5000
            },
            new Product
            {
                Id = 1,
                Name = "Banh Chung",
                Price = 5000
            },
            new Product
            {
                Id = 1,
                Name = "Banh Chung",
                Price = 5000
            },
        };
            return new JsonResult(prod);
        }
    }
}