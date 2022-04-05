using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession12.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Detail/{id}")]
        public IActionResult Detail(int id) {

            ViewBag.id = id;
            return View();
        }
    }
}