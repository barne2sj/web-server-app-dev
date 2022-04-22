using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private HobbyContext context { get; set; }

        public HomeController(HobbyContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var hobbies = context.Hobbys.OrderBy(h => h.HobbyName).ToList();
            return View(hobbies);
        }

        public IActionResult Sara()
        {
            return View("Sara");
        }
        public IActionResult Bangyan()
        {
            return View("Bangyan");
        }
        public IActionResult Jeffrey()
        {
            return View("Jeffrey");
        }
        public IActionResult Anish()
        {
            return View("Anish");
        }
        public IActionResult Pranav()
        {
            return View("Pranav");
        }
    }
}