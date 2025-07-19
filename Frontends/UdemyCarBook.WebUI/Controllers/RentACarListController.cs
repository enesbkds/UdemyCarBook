using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.Controllers
{
    public class RentACarListController : Controller
    {
        public IActionResult Index()
        {
            var data = TempData["value"];
            ViewBag.v = data;
            return View();
        }
    }
}
