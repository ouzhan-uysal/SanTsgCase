using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SanTsgCase.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager hr = new ServiceManager(new EFHotelRepository());
        ServiceManager fr = new ServiceManager(new EFFlightRepository());
        Context c = new Context();
        public IActionResult Index()
        {
            List<SelectListItem> locationList = (from x in c.Locations.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Name,
                                                     Value = x.Code.ToString(),
                                                 }).ToList();
            ViewBag.ll = locationList;  // ViewBag --> Contoller'dan View tarafına veri aktarmak için kullanılır.
            return View();
        }
        [HttpPost]
        public IActionResult IndexHotel(Hotel p)
        {
            //HotelValidator hv = new HotelValidator();
            //ValidationResult results = hv.Validate(p);
            //if (results.IsValid)
            //{
                hr.AddHotel(p);
                return RedirectToAction("Index", "Hotel");
            //} else
            //{
            //    foreach (var item in results.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //}
            //return View();
        }
        [HttpPost]
        public IActionResult IndexFlight(Flight p)
        {
            FlightValidator fv = new FlightValidator();
            ValidationResult results = fv.Validate(p);
            if (results.IsValid)
            {
                fr.AddFlight(p);
                return RedirectToAction("Index", "Flight");
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
