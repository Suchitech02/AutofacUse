using Microsoft.AspNetCore.Mvc;

namespace AutofacUse.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {

        public HelloController()
        {
            
        }

        [HttpGet]
        public string Get()
        {
            return "Hello";
        }
    }
}