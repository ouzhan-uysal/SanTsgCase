using Microsoft.AspNetCore.Mvc;

namespace SanTsgCase.Controllers
{
    public class FlightController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
