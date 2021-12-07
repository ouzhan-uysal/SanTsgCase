using Microsoft.AspNetCore.Mvc;

namespace SanTsgCase.ViewComponents
{
    public class LocationList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
