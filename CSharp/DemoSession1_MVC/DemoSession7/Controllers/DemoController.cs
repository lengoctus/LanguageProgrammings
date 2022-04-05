using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession7.Controllers
{
    public class DemoController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Save()
        {
            string username = Request.Form["username"].ToString();

            return View();
        }

    }
}