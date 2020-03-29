using Microsoft.AspNetCore.Mvc;

namespace DateTimeMicroservice.Server.Controllers {
    public class HomeController : Controller {
        [Route("/")]
        [HttpGet]
        public IActionResult Index() {
            return Ok("It works!");
        }
    }
}
