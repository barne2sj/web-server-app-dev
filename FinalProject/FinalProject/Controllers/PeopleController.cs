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
    }
    }
