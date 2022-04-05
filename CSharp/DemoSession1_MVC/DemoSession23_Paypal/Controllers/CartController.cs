using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoSession23_Paypal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace DemoSession23_Paypal.Controllers
{
    public class CartController : Controller
    {
        public IConfiguration Configuration { get; }

        public CartController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IActionResult Index()
        {
            var listProd = new List<Item>
            {
                new Item {
                    Product = new Products
                    {
                        Id = 01,
                        Name = "sp01",
                        Price = 2000
                    },
                    Quantity = 1
                },

                 new Item {
                    Product = new Products
                    {
                        Id = 02,
                        Name = "sp02",
                        Price = 2000
                    },
                    Quantity = 1
                },

                  new Item {
                    Product = new Products
                    {
                        Id = 03,
                        Name = "sp03",
                        Price = 2000
                    },
                    Quantity = 1
                },

                   new Item {
                    Product = new Products
                    {
                        Id = 04,
                        Name = "sp04",
                        Price = 2000
                    },
                    Quantity = 1
                },


                    new Item {
                    Product = new Products
                    {
                        Id = 05,
                        Name = "sp05",
                        Price = 2000
                    },
                    Quantity = 1
                },

                     new Item {
                    Product = new Products
                    {
                        Id = 06,
                        Name = "sp06",
                        Price = 2000
                    },
                    Quantity = 1
                },

                      new Item {
                    Product = new Products
                    {
                        Id = 07,
                        Name = "sp07",
                        Price = 2000
                    },
                    Quantity = 1
                },


            };
            ViewBag.bussiness = Configuration["Paypal:Business"];
            ViewBag.returnUrl = Configuration["Paypal:ReturnUrl"];
            ViewBag.postUrl = Configuration["Paypal:PostUrl"];


            return View(listProd);
        }


        public IActionResult Success()
        {
            return View();
        }
    }
}