using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoSession26_MultiLoginPage.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession26_MultiLoginPage.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly Db25Context _db;

        public AccountController(Db25Context db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("Account/Login")]
        public IActionResult Login(Account acc)
        {

            var account = processLogin(acc.Username, acc.Password);
            if (account != null)
            {
                Security.SecurityManager sc = new Security.SecurityManager();
                sc.SignIn(HttpContext, account, "Schema_Admin");

                return View("Welcome");
            }
            return View("AccessDenied");


        }

        public IActionResult LogOut()
        {
            Security.SecurityManager sc = new Security.SecurityManager();
            sc.SignOut(HttpContext, "Schema_Admin");
            return View("Index");
        }

        public IActionResult AccessDenided()
        {
            return View("AccessDenied");
        }

        private Account processLogin(string username, string password)
        {
            var account = _db.Account.SingleOrDefault(a => a.Username.Equals(username) && a.Enabled == true);
            if (account != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, account.Password))
                {
                    return account;
                }
            }
            return null;
        }

    }
}