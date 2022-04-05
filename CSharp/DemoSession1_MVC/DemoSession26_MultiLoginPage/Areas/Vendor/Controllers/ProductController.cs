using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession26_MultiLoginPage.Areas.Vendor.Controllers
{
    [Authorize(Roles ="Vendor", AuthenticationSchemes = "Vendor_Schema")]
    [Area("Vendor")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}