using Microsoft.AspNetCore.Mvc;

namespace DigitalClockApp.Controllers
{
    public class ClockController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
