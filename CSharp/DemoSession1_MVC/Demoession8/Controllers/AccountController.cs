using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Demoession8.Models;

namespace Demoession8.Controllers
{
    public class AccountController : Controller
    {
        [Route("~/")]
        public IActionResult Index()
        {
            var acc = new Account();
            return View(acc);
        }

        public IActionResult Register(Account account)
        {
            if (ModelState.IsValid)
            {
                if (account.UserName != "abc")
                {
                    return View("Success");
                }
                ModelState.AddModelError("UserName", "UserName is already exists !!");
                return View("Index");

            }
            return View("Index");
        }
    }
}