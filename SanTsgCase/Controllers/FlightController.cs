using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace SanTsgCase.Controllers
{
    public class FlightController : Controller
    {
        ServiceManager fr = new ServiceManager(new EFFlightRepository());

        [HttpGet]
        public IActionResult Index()
        {
            var values = fr.GetFlightList();
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Flight p)
        {
            FlightValidator fv = new FlightValidator();
            ValidationResult results = fv.Validate(p);
            if (results.IsValid)
            {
                fr.AddFlight(p);
                return RedirectToAction("Index");
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
