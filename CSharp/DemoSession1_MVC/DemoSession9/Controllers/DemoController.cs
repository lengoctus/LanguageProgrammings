using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DemoSession9.Models;
using Newtonsoft.Json;

namespace DemoSession9.Controllers
{
    public class DemoController : Controller
    {
        private readonly ILogger<DemoController> _logger;

        public DemoController(ILogger<DemoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var dd = new Booking
            {
                ID = 1,
                DayStart = DateTime.Now,
                DayEnd = DateTime.Now.AddDays(1)
            };

            var s = JsonConvert.SerializeObject(dd);
            HttpContext.Session.SetString("nb1", s);

            var d = JsonConvert.DeserializeObject<Booking>(HttpContext.Session.GetString("nb1"));

            ViewBag.d = d;

            // Remove Session
            //HttpContext.Session.Remove("nb1");
            return View();
        }

        public IActionResult Index2()
        {
            var prod = new Products
            {
                ID = "sp01",
                Name = "Bannh Chung",
                Price = 2000
            };

            string dtajson = JsonConvert.SerializeObject(prod);
            Products products = JsonConvert.DeserializeObject<Products>(dtajson);

            List<Products> listProd = new List<Products> {
                new Products{  ID = "sp01",
                    Name = "Bannh Chung",
                    Price = 2000
                },
                new Products{  ID = "sp02",
                    Name = "Bannh Tet",
                    Price = 2000
                },
                new Products{  ID = "sp03",
                    Name = "Bannh Mut",
                    Price = 2000
                },
                new Products{  ID = "sp04",
                    Name = "Bannh Day",
                    Price = 2000
                },
            };

            string listprodJson = JsonConvert.SerializeObject(listProd);
            List<Products> ahi = JsonConvert.DeserializeObject<List<Products>>(listprodJson);

            return View("Index");
        }

    }
}
