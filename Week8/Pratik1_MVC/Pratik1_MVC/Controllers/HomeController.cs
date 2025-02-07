using Microsoft.AspNetCore.Mvc;

namespace Pratik1_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}