using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class HobbyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
