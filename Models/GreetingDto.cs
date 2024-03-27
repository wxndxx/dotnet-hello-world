using Microsoft.AspNetCore.Mvc;

namespace TimewebApps.HelloWorld.Models
{
    public class GreetingDto
    {
        [FromQuery]
        public string Target { get; set; }
    }
}
