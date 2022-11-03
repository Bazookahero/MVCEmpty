using Microsoft.AspNetCore.Mvc;

namespace MVCEmpty.Properties.Controllers
{
    public class DoctorController : Controller
    {
        [HttpPost]
        public IActionResult DoctorPage(double temp)
        {
            if (temp != 0)
            {
                ViewBag.Msg = Models.TempCheck.TempTest(temp);
                return View();
            }
            else
            {
                ViewBag.Msg = "please enter a valid temperature";
                return View();
            }
        }
        [HttpGet]
        public IActionResult DoctorPage()
        {
            return View();
        }
    }
}
