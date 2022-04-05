using System;
using System.Collections.Generic;
using System.Linq;
using DemoSession24_Security.Security;
using System.Threading.Tasks;
using DemoSession24_Security.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession24_Security.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Account account)
        {
            var acc = new AccountModels().Login(account.UserName, account.Password);
            if (acc != null)
            {
                SecurityManage securityManager = new SecurityManage();
                securityManager.SignIn(this.HttpContext, acc);
                return View("Success");
            }
            ViewBag.error = "Login Failed!!";
            return View("Index");
        }

        public IActionResult Success()
        {
            return View();
        }

        public IActionResult LogOut()
        {
            SecurityManage sc = new SecurityManage();
            sc.SignOut(HttpContext);
            return RedirectToAction("Index");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}