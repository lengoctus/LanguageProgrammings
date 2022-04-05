using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DemoSession24_Security.Controllers
{
    public class DemoController : Controller
    {
        private readonly ILogger<DemoController> _logger;

        public DemoController(ILogger<DemoController> logger)
        {
            _logger = logger;
        }


        [AllowAnonymous]   // Free Url
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "SuperAdmin")]
        public IActionResult Demo1()
        {
            var user = User.FindFirst(ClaimTypes.Name);

            return View();
        }

        [Authorize(Roles = "SuperAdmin, Admin")]
        public IActionResult Demo2()
        {
            return View();
        }

        [Authorize(Roles = "SuperAdmin, Admin, Employee")]
        public IActionResult Demo3()
        {
            return View();
        }

    }
}
