using AutofacUse.contract;
using Microsoft.AspNetCore.Mvc;

namespace AutofacUse.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        IDataProvider provider;
        public HelloController(IDataProvider provider)
        {
            this.provider = provider;
        }

        [HttpGet]
        public string Get()
        {
            return provider.Get();
        }
    }
}