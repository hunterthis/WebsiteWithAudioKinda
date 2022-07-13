using Microsoft.AspNetCore.Mvc;

namespace AlmostEmptyStarter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // sets title 
            ViewData["Title"] = "Home Page";
            return View();
        }

        public IActionResult About()
        {
            ViewData["About"] = "About";
            return View();
        }
        public IActionResult Audio()
        {
            ViewData["Audio"] = "Audio";
            return View();
        }


    }
}
