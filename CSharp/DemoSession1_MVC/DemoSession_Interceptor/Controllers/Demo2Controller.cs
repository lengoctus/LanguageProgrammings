using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DemoSession19_Interceptor.Controllers
{
    public class Demo2Controller : Controller
    {
        private readonly ILogger<Demo2Controller> logger;
        private readonly IMapper mapper;

        public Demo2Controller(ILogger<Demo2Controller> logger, IMapper mapper)
        {
            this.logger = logger;
            this.mapper = mapper;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}