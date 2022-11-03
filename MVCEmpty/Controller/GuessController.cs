using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using Microsoft.AspNetCore.StaticFiles.Infrastructure;
using MVCEmpty.Models;
using System.Security.Cryptography;

namespace MVCEmpty.Properties.Controllers
{
    public class GuessController : Controller
    {
        [HttpGet]
        public IActionResult GuessingGame()
        {
            HttpContext.Session.Remove("intRnd");
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("intRnd")))
            {
                string getRnd = Models.GuessTest.RandomNumber().ToString();
                HttpContext.Session.SetString("intRnd", getRnd);
                ViewBag.Rnd = getRnd;
                ViewBag.Msg = "Enter a number between 1 and 100 and Submit";
                return View();
            }
            else
            {
                ViewBag.Msg = "Enter a number between 1 and 100 and Submit";
                ViewBag.Rnd = HttpContext.Session.GetString("intRnd");
                return View();
            }
            return View();
        }
        [HttpPost]
        public IActionResult GuessingGame(int guess)
        {
            if (!(string.IsNullOrEmpty(HttpContext.Session.GetString("intRnd"))))
            {
                string? storedRnd = HttpContext.Session.GetString("intRnd");
                string respons = Models.GuessTest.GuessCheck(guess, storedRnd);
                if (respons == "Congratulations, you won!")
                {
                    HttpContext.Session.Remove("intRnd");
                }
                ViewBag.Msg = respons;
                return View();
            }
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("intRnd")))
            {
                string getRnd = Models.GuessTest.RandomNumber().ToString();
                HttpContext.Session.SetString("intRnd", getRnd);
                ViewBag.Rnd = getRnd;
                ViewBag.Msg = "Enter a number between 1 and 100 and Submit";
                return View();
            }
            return View();
        }
        

    }

}
