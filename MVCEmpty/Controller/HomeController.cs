using Microsoft.AspNetCore.Mvc;

namespace MVCEmpty.Properties.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult HomeIndex()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Projects()
        {
            return View();
        }
    }
}
