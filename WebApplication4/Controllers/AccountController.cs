using FormValid.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormValid.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SignupViewModel model)
        {
            if (ModelState.IsValid)
            {
                RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
