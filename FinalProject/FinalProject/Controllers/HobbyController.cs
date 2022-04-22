using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class HobbyController : Controller
    {
        private HobbyContext context { get; set; }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Hobby());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var hobby = context.Hobbys.Find(id);
            return View(hobby);
        }

        [HttpPost]
        public IActionResult Edit(Hobby hobby)
        {
            if (ModelState.IsValid)
            {
                if (hobby.HobbyId == 0)
                    context.Hobbys.Add(hobby);
                else
                    context.Hobbys.Update(hobby);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (hobby.HobbyId == 0) ? "Add": "Edit";
                return View(hobby);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var hobby = context.Hobbys.Find(id);
            return View(hobby);
        }

        [HttpPost]
        public IActionResult Delete(Hobby hobby)
        {
            context.Hobbys.Remove(hobby);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
