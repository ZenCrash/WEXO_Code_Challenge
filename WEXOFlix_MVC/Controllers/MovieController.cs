using Microsoft.AspNetCore.Mvc;

namespace WEXOFlix_MVC.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
