using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace SanTsgCase.Controllers
{
    public class ServiceController : Controller
    {
        LocationManager lm = new LocationManager(new EFLocationRepository());   // for list locations
        ServiceManager sm = new ServiceManager(new EFServiceRepository());

        [HttpGet]
        public IActionResult Index()
        {
            var values = lm.GetList();
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Hotel hp, Flight fp)
        {
            HotelValidator hv = new HotelValidator();
            ValidationResult hotelResult = hv.Validate(hp);

            FlightValidator fv = new FlightValidator();
            ValidationResult flightResult = fv.Validate(fp);
            if (hotelResult.IsValid)
            {
                sm.addHotelService(hp);
                return RedirectToAction("Index", "Service");

            } else if (flightResult.IsValid)
            {
                sm.addFlightService(fp);
                return RedirectToAction("Index", "Service");

            } else
            {
                return View();
            }
        }
    }
}
