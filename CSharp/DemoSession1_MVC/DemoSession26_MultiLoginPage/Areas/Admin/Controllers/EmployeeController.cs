using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession26_MultiLoginPage.Areas.Admin.Controllers
{
    //Phan biet admin theo url.
    [Area("Admin")]
    [Authorize(Roles = "Admin", AuthenticationSchemes = "Schema_Admin")]
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            var user = User.Identities;



            return View();
        }
    }
}