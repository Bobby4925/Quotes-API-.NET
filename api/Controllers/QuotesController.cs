using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller : ControllerBase
    {
        // GET: api/My
        [HttpGet]
        public IActionResult Get()
        {
            // Replace this with your actual logic
            return Ok("Hello from MyController!");
        }
    }
}
