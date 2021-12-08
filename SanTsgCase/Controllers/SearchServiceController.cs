using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace SanTsgCase.Controllers
{
    public class SearchServiceController : Controller
    {
        ServiceManager lr = new ServiceManager(new EFLocationRepository()); // for list location

        [HttpGet]
        public IActionResult Index()
        {
            var values = lr.GetLocationList();
            return View(values);
        }
    }
}
