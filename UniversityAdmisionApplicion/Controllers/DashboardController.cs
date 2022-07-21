using Microsoft.AspNetCore.Mvc;

namespace UniversityAdmisionApplicion.Controllers
{
    public class DashboardController : Controller
    {
        
        public IActionResult profile()
        {
            return View();
        }
     public IActionResult Applications()
        {
            return View();
        }
    public IActionResult Process()
        {
            return View();
        }
    }
}
