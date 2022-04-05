using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession4.Controllers
{
    [Route("product")]
    public class ProductsController : Controller
    {
        [Route("details1")]
        public IActionResult Details1()
        {
            return View("Details1");
        }

        [Route("details2")]
        public IActionResult Details2()
        {
            return View("Details2");
        }
    }
}