using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controllers
{
    [ApiController]
    [Route("test/[action]")]
    public class TestController : ControllerBase
    {
        // test/[action] => action mean method name in the controller
        // test/get || test/get1
        public string Get()
        {
            return "Hello from Get (TestController)";
        }

        public string Get1()
        {
            return "Hello from Get1 (TestController)";
        }
    }
}