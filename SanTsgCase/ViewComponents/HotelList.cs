using Microsoft.AspNetCore.Mvc;

namespace SanTsgCase.ViewComponents
{
    public class HotelList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
