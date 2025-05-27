using Microsoft.AspNetCore.Mvc;

namespace OutstaffSystem.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Content("✅ API is running. Swagger is at /swagger");
        }
    }
}