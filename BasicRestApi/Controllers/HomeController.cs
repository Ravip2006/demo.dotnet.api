using Microsoft.AspNetCore.Mvc;

namespace BasicRestApi.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Welcome to your first REST API!");
        }
    }
}