using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DemoSession19_Interceptor.Controllers
{
    public class DemoController : Controller
    {
        private readonly ILogger<DemoController> logger;
        private readonly IMapper mapper;

        public DemoController(ILogger<DemoController> logger, IMapper mapper)
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