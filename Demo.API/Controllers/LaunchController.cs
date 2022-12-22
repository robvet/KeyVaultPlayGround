using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("api/[controller]")]
    public class LaunchController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Redirect("~/swagger");
        }
    }
}
