using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession3.Controlllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {

            return View("Index2");
        }

        public IActionResult Index3(string id)
        {
            Debug.WriteLine(id);
            return View("Index3");
        }

        public IActionResult Index4(int id, string name)
        {
            Debug.WriteLine(id + "--" + name);
            return View();
        }
    }
}