using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;

namespace DemoSession21_Locale.Controllers
{
    public class DemoController : Controller
    {
        private readonly ILogger<DemoController> _logger;
        private readonly IStringLocalizer<ShareResources> _stringLocalizer;

        public DemoController(ILogger<DemoController> logger, IStringLocalizer<ShareResources> stringLocalizer)
        {
            _logger = logger;
            var type = typeof(ShareResources);
        }

        public IActionResult Index()
        {
            var n = 1234567;
            //  n: Number
            Console.WriteLine("Number: " + n.ToString("n"));

            //  c: 
            Console.WriteLine("Currency: " + n.ToString("c"));

            //  p: Percent
            Console.WriteLine("Percent: " + n.ToString("p"));

            //  Time
            var today = DateTime.Now;
            Console.WriteLine("Time: " + today.ToString("F"));

            var mes = _stringLocalizer["ngoctu"];
            return View();
        }
    }
}