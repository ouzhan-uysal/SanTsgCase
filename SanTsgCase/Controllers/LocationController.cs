using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace SanTsgCase.Controllers
{
    public class LocationController : Controller
    {
        LocationManager lm = new LocationManager(new EFLocationRepository());   // buraki lm ile bütün metodlara erişim sağlayacaz.

        [HttpGet]
        public IActionResult Index()
        {
            var values = lm.GetList();
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Location l)
        {
            LocationValidator lv = new LocationValidator();
            ValidationResult results = lv.Validate(l);
            if (results.IsValid)
            {
                lm.AddLocation(l);
                return RedirectToAction("Index", "Location");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
