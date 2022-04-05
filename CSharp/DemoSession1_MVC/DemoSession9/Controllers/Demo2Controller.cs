using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession9.Controllers
{
    public class Demo2Controller : Controller
    {
        public IActionResult Index()
        {
            int? a = HttpContext.Session.GetInt32("nb1").Value;
            return View(a);
        }
    }
}