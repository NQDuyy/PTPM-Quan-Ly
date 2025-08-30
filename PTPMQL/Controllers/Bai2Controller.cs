namespace PTPMQL.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PTPMQL.Models;

    public class Bai2Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Bai2 calc)
        {
            if (ModelState.IsValid)
            {
                switch (calc.Operation)
                {
                    case "Sum":
                        calc.Result = calc.Number1 + calc.Number2;
                        break;
                    case "Sub":
                        calc.Result = calc.Number1 - calc.Number2;
                        break;
                    case "Mul":
                        calc.Result = calc.Number1 * calc.Number2;
                        break;
                    case "Div":
                        calc.Result = calc.Number2 != 0 ? calc.Number1 / calc.Number2 : double.NaN;
                        break;
                }
                ViewBag.Result = calc.Result;
            }
            return View(calc);
        }
    }
}