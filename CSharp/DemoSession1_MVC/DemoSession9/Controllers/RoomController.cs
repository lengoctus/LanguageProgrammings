using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoSession9.Models.ModelView;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession9.Controllers
{
    public class RoomController : Controller
    {
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.list = Room_View.GetData();
            return View();
        }

    }
}