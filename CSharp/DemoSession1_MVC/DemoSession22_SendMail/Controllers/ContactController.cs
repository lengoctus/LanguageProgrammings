using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoSession22_SendMail.Helper;
using DemoSession22_SendMail.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace DemoSession22_SendMail.Controllers
{
    public class ContactController : Controller
    {
        private IConfiguration Configuration;

        public ContactController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Send(Contact contact)
        {
            try
            {
                var body = "Name: " + contact.Name + "<br/>Address: " + contact.Address + "<br/>Phone: " + contact.Phone + "<br/>Content: " + contact.Content;
                contact.Content = body;

                var mailHelper = new MailHelper(Configuration);
                var rs = mailHelper.SendMail( contact.Email, contact.Subject, contact.Content);

                if (rs == true)
                {
                    return View("Success");
                }
                else
                {
                    ViewBag.err = "Failed";
                    return View("Index");
                }
            }
            catch (Exception)
            {

                ViewBag.err = "Failed";
                return View("Index");
            }
        }

        public IActionResult Success() {

            return View();
        }
    }
}