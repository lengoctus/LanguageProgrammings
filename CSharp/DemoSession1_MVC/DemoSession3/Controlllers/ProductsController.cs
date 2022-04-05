using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoSession3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Extensions;

namespace DemoSession3.Controlllers
{
    [Route("prod")]
    public class ProductsController : Controller
    {
        //[Route("~/")]  // if domain don't have name of Controller
        //[Route("")]     // if domain don't have name of Controller 
        [Route("idex")]  // Change name of Action 
        public IActionResult Index()
        {
            ProductsModel listProd = new ProductsModel();
            ViewBag.listProd = listProd.findAll();
            var url = HttpContext.Request.GetDisplayUrl();
            TempData["url"] = url;
            return View();
        }

        
        [Route("detailss/{id}")]
        public IActionResult Details(int id)
        {
            var prod = new ProductsModel().findAll().FirstOrDefault(d => d.Id == id);
            ViewBag.prod = prod;
            return View("Details");
        }
    }
}