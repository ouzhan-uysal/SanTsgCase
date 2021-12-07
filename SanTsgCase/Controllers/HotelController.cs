using Microsoft.AspNetCore.Mvc;

namespace SanTsgCase.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
