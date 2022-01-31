using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestVS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("index")]
        public IActionResult Index()
        {
            var a = new { id = 1 };

            var v = a.id switch
            {
                1 => test(),
                2 => 2,
                _ => 3
            };

            int test()
            {
                return 4;
            }


            return a.id switch
            {
                1 => Ok(a.id + 2),
                2 => NotFound()
            };
        }
    }
}
