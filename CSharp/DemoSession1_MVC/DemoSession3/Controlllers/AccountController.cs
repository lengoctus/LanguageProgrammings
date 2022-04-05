using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession3.Controlllers
{
    [Route("abcef_Controller")]
    public class AccountController : Controller
    {
        [Route("Index1")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("details1/{id}")]
        public IActionResult Details(int id)
        {
            Debug.WriteLine("id: " + id);
            return View("Details");
        }


        [Route("details2/{id}/{name2}")]
        public IActionResult Details2(string id, string name2)
        {
            Debug.WriteLine(id + " -- " + name2);
            return View();
        }
    }
}