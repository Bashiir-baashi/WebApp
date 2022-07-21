using Microsoft.AspNetCore.Mvc;

namespace UniversityAdmisionApplicion.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
