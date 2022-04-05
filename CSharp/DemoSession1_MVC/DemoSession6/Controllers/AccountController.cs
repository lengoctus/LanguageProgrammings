using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DemoSession6.Models;
using DemoSession6.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoSession6.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        
        private IWebHostEnvironment iwebhosting;

        public AccountController(IWebHostEnvironment _iwebhosting)
        {
            this.iwebhosting = _iwebhosting;
        }

        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            var roles = new List<Role> {
                new Role{ ID="r01", Name = "Admin"},
                new Role{ ID="r02", Name = "Staff"},
                new Role{ ID="r03", Name = "CEO"},
                new Role{ ID="r04", Name = "Client"},
            };

            Accounts_ViewModels acc_view = new Accounts_ViewModels
            {
                Account = new Models.Accounts
                {
                    Id = 01,
                    UserName = "ntu",
                    FullName = "Ngoc Tu",
                    Age = 19,
                    Active = true
                },

                Roles = new SelectList(roles, "ID", "Name"),
            };

            return View("Index", acc_view);
        }

        [HttpPost]
        [Route("save")]
        public IActionResult Save(Accounts_ViewModels acc, IFormFile photo)
        {
            string name = acc.Account.FullName;

            var path = Path.Combine(this.iwebhosting.WebRootPath, "images", photo.FileName);
            var fileStream = new FileStream(path, FileMode.Create);
            photo.CopyToAsync(fileStream);

            return View();
        }
    }
}