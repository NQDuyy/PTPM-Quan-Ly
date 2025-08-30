namespace PTPMQL.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PTPMQL.Models;
    public class Bai3Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Bai3 model)
        {
            if (ModelState.IsValid)
            {
                double result = model.CalculateBMI();
                string category = model.GetCategory();

                ViewBag.BMI = result.ToString("0.00");
                ViewBag.Category = category;
            }
            return View(model);
        }
    }
}
