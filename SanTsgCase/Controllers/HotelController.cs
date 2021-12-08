using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace SanTsgCase.Controllers
{
    public class HotelController : Controller
    {
        ServiceManager hr = new ServiceManager(new EFHotelRepository());

        [HttpGet]
        public IActionResult Index()
        {
            var values = hr.GetHotelList();
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Hotel p)
        {
            HotelValidator hv = new HotelValidator();
            ValidationResult results = hv.Validate(p);
            if (results.IsValid)
            {
                hr.AddHotel(p);
                return RedirectToAction("Index", "Hotel");
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
