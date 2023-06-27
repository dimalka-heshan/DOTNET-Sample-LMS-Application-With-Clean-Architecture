using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controllers
{
    public class AuthenticationController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
