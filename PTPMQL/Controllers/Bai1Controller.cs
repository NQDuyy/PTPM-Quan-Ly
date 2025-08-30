namespace PIPMQL.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PTPMQL.Models;

    public class Bai1Controller : Controller
    {
         [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Bai1 p)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Name = p.FullName;
                ViewBag.Age = p.GetAge();
            }
            return View();
        }
    }
}
