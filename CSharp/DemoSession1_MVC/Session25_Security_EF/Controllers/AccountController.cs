using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Session25_Security_EF.Models;
using Session25_Security_EF.ViewModels;
using Session25_Security_EF.Security;

namespace Session25_Security_EF.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        private DB25Entities db;

        public AccountController(DB25Entities _db)
        {
            db = _db;
        }

        [HttpGet]
        [Route("")]
        [Route("~/")]
        [Route("register")]
        public IActionResult Register()
        {
            var accountViewModel = new AccountViewModel
            {
                account = new Account(),
                Roles = db.Role.ToList()
            };
            return View("Register", accountViewModel);
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register(AccountViewModel accountViewModel, int[] roles)
        {
            // Save account
            accountViewModel.account.Password = BCrypt.Net.BCrypt.HashPassword(accountViewModel.account.Password);
            db.Account.Add(accountViewModel.account);
            db.SaveChanges();

            // Save roles to new account
            foreach (var role in roles)
            {
                var roleAccount = new RoleAccount()
                {
                    AccountId = accountViewModel.account.Id,
                    RoleId = role,
                    Enabled = true
                };
                db.RoleAccount.Add(roleAccount);
                db.SaveChanges();
            }

            return RedirectToAction("Login");
        }

        [HttpGet]
        [Route("login")]
        public IActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(string username, string password)
        {
            var account = processLogin(username, password);
            if (account != null)
            {
                SecurityManager securityManager = new SecurityManager();
                securityManager.SignIn(this.HttpContext, account);
                return RedirectToAction("Welcome");
            }
            else
            {
                ViewBag.error = "Invalid";
                return View("Login");
            }
        }

        private Account processLogin(string username, string password)
        {
            var account = db.Account.SingleOrDefault(a => a.Username.Equals(username) && a.Enabled == true);
            if (account != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, account.Password))
                {
                    return account;
                }
            }
            return null;
        }

        [Route("welcome")]
        public IActionResult Welcome()
        {
            return View("Welcome");
        }

        [Route("logout")]
        public IActionResult Logout()
        {
            SecurityManager securityManager = new SecurityManager();
            securityManager.SignOut(this.HttpContext);
            return RedirectToAction("Login");
        }

        [Route("accessDenied")]
        public IActionResult AccessDenied()
        {
            return View("AccessDenied");
        }

    }
}