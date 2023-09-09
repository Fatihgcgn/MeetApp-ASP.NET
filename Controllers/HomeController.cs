using Microsoft.AspNetCore.Mvc;

namespace MeetApp.AddControllersWithViews
{
    public class HomeController : Controller
    {
        //localhost/home
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            // ViewBag.Greeting = saat > 12 ? "İyi Günler" : "Günaydın";
            // ViewBag.UserName = "Fatih";

            ViewData["Greeting"] = saat > 12 ? "İyi Günler" : "Günaydın";
            ViewData["UserName"] = "Fatih";

            return View();
        }
    }
}
