using Microsoft.AspNetCore.Mvc;
using Mission6_Reese.Models;
using System.Diagnostics;

namespace Mission6_Reese.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        public IActionResult MovieForm()
        {
            return View();
        }
    }
}
