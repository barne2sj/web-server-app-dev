using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class PeopleController : Controller
    {
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
