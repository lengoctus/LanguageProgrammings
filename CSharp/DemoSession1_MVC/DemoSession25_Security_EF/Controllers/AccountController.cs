using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoSession25_Security_EF.Models;
using DemoSession25_Security_EF.Models.Dao;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession25_Security_EF.Controllers
{
    public class AccountController : Controller
    {
        private readonly Account_Dao _dao;

        public AccountController()
        {
            _dao = new Account_Dao();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Account account)
        {
            if (ModelState.IsValid)
            {
                _dao.Register(account);
            }
            return View("Index");
        }
    }
}