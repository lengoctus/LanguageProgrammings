using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Review_Buoi1.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Route("admin/login")]
    public class LoginController : Controller
    {
        [HttpGet("")]
        [HttpGet("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}