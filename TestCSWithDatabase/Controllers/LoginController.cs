using Microsoft.AspNetCore.Mvc;

namespace TestCSWithDatabase.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
