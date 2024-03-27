using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimewebApps.HelloWorld.Models;

namespace TimewebApps.HelloWorld.Controllers
{
    [Route("/")]
    public class PrimaryController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index([FromQuery] string who = "TimeWeb")
        {
            var greeting = new GreetingDto()
            {
                Target = who
            };

            return RedirectToAction("Greeting", "HelloWorld", greeting);
        }
    }
}
