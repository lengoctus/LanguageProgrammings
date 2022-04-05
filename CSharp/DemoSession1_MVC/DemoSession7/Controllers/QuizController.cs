using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoSession7.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession7.Controllers
{
    public class QuizController : Controller
    {
        [Route("~/")]
        public IActionResult Index()
        {
            QuestionModels questionModel = new QuestionModels();
            ViewBag.questionModel = questionModel.FindAll();
            return View();
        }
    }
}