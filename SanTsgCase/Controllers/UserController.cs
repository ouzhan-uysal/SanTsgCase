using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace SanTsgCase.Controllers
{
    public class UserController : Controller
    {
        UserManager um = new UserManager(new EFUserRepository());

        [HttpGet]   // sayfa yüklenince çalışır
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]  // buton tetiklendiğinde çalışır.
        public IActionResult Index(User p)
        {
            UserValidator vr = new UserValidator();
            ValidationResult results = vr.Validate(p);
            if (results.IsValid)
            {
                um.AddUser(p);
                return RedirectToAction("Index", "User");
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
