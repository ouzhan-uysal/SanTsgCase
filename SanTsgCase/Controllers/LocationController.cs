using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace SanTsgCase.Controllers
{
    public class LocationController : Controller
    {
        LocationManager lm = new LocationManager(new EFLocationRepository());
        // buraki lm ile bütün metodlara erişim sağlayacaz.
        [HttpGet]
        public IActionResult Index()
        {
            var values = lm.GetList();
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Location p)
        {
            lm.AddLocation(p);
            return RedirectToAction("Index", "Location");
        }
    }
}
