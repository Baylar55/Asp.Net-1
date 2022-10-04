using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Baylar";
            ViewBag.Surname = "Sadygov";
            ViewBag.Age = 20;
            ViewBag.Country = "Azerbaijan";
            ViewBag.PhoneNumber = "+"+994551234567;
            return View();
        }
    }
}
