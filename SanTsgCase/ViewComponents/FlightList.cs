using Microsoft.AspNetCore.Mvc;

namespace SanTsgCase.ViewComponents
{
    public class FlightList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
