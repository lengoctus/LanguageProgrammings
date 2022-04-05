using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DemoSession16_EF6.Models;
using DemoSession16_EF6.Models.Entities;

namespace DemoSession16_EF6.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly DemoSession16DbContext db;

        public ProductController(ILogger<ProductController> logger, DemoSession16DbContext _db)
        {
            _logger = logger;
            db = _db;
        }

        public IActionResult Index()
        {
            ViewBag.listProd = db.Product.ToList();
            ViewBag.listAccount = db.Product.ToList();
            return View();
        }

        public IActionResult Add()
        {

            return View("Add", new Products());
        }

        [HttpPost]
        public IActionResult Add(Products prod)
        {
            if (ModelState.IsValid)
            {
                db.Product.Add(new Product
                {
                    Name = prod.Name,
                    Price = prod.Price,
                    Quantity = prod.Quantity,
                    Status = prod.Status,
                    Description = prod.Description
                });
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Add", new Products());
        }

        [Route("{id}")]
        public IActionResult Delete(int Id)
        {
            db.Product.Remove(db.Product.Find(Id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Edit(int Id)
        {
            var prod = db.Product.Where(l => l.Id == Id).Select(l => new Products
            {
                Id = l.Id,
                Name = l.Name,
                Price = l.Price ?? 0,
                Quantity = l.Quantity ?? 0,
                Status = l.Status ?? false,
                Description = l.Description
            }).SingleOrDefault();
            return View(prod);
        }

        [HttpPost]
        [Route("{id}")]
        public IActionResult Edit(int Id, Product prod)
        {
            db.Entry(prod).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return View(prod);
        }
    }
}
