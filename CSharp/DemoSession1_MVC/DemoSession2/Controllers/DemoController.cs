using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoSession2.Models;

namespace DemoSession2.Controllers
{
    public class DemoController : Controller
    {
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.age = 19;
            ViewBag.username = "Ngoc Tu";
            return View();
        }
        
        public IActionResult Index2()
        {
            var prod = new Products
            {
                Id = "sp01",
                Name = "banh chung",
                Price = 2000,
                Quantity = 3,
                Image = "73013116_409207736409579_438760905337995264_n.jpg",
                Status = true
            };
            ViewBag.prod = prod;
            return View("Index2");
        }

        public IActionResult Index4()
        {

            var invoice = new Invoices
            {
                Id = "in01",
                Name = "Invoice 01",
                Created = DateTime.Now,
                Payment = "Cash",
                Customer = new Customers
                {
                    Id = "cus 01",
                    Name = "Ngoc tu",
                    Address = "Nghe An",
                    Email = "ahi"
                },
                Products = new List<Products>
                {
                    new Products {
                        Id = "sp01",
                        Name = "Banh chung",
                        Price = 2000,
                        Quantity = 2,
                        Image = "73341324_147410913306862_6242422445735673856_n.jpg",
                        Status = true
                    },
                }
            };
            ViewBag.inv = invoice;
            return View("Index4");
        }
    }
}