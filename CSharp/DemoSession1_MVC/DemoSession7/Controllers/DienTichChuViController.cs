using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession7.Controllers
{
    public class DienTichChuViController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }   

        [HttpPost]
        public IActionResult Caculator(int[] nb1)
        {

            ViewBag.chuvi = (nb1[0] + nb1[1]) * 2;
            ViewBag.dientich = nb1[0] * nb1[1];
            return View("Index");
        }

        [HttpPost]
        public IActionResult LoadImg(string Change) {
            var img = Request.Form["img"];


            return View("Index");
        }
    }
}