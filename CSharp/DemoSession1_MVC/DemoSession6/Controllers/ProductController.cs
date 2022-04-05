using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoSession6.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession6.Controllers
{
    public class ProductController : Controller
    {
        //[Route("~/")]
        public IActionResult Index()
        {
            Products_ViewModels prod_view = new Products_ViewModels
            {
                product = new Models.Products
                {
                    Id = 1,
                    Name = "banh muot",
                    Price = 2000,
                    Quantity = 3
                }
            };
            return View("Index", prod_view);
        }
    }
}