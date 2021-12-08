using Microsoft.AspNetCore.Mvc;

namespace SanTsgCase.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
