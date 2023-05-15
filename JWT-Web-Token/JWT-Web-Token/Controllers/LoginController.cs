using Microsoft.AspNetCore.Mvc;

namespace JWT_Web_Token.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
