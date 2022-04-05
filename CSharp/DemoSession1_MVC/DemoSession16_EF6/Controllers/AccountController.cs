using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoSession16_EF6.Models;
using DemoSession16_EF6.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DemoSession16_EF6.Controllers
{
    public class AccountController : Controller
    {
        private readonly DemoSession16DbContext db;

        public AccountController(DemoSession16DbContext _db)
        {
            this.db = _db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult<Accounts> Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult<Accounts> Login(Accounts acc)
        {
            if (CheckAccount(acc) != null)
            {
                string username = JsonConvert.SerializeObject(acc.UserName.ToLower());
                HttpContext.Session.SetString("user", username);
                return View("Welcome");
            }
            ViewBag.error = "Invalid";
            return View();
        }

        public Account CheckAccount(Accounts acc)
        {
            var account = db.Account.SingleOrDefault(l => l.UserName.ToLower() == acc.UserName && l.Password == acc.Password);
            return account;
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("user");
            return RedirectToAction("Login");
        }

        public IActionResult Profile()
        {
            string username = JsonConvert.DeserializeObject<string>(HttpContext.Session.GetString("user"));
            var account = db.Account.SingleOrDefault(l => l.UserName.ToLower() == username);

            return View("Profile", account);
        }
    }
}