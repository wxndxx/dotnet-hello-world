using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimewebApps.HelloWorld.Models;

namespace TimewebApps.HelloWorld.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        private readonly ILogger _logger;

        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Greeting(GreetingDto greeting)
        {
            _logger.LogInformation("Sendind greeting response for {fragment}", greeting.Target);
            return Ok($"Greetings, {greeting.Target}!");
        }
    }
}
