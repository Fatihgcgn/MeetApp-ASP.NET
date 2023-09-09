using Microsoft.AspNetCore.Mvc;

namespace MeetApp.AddControllersWithViews
{
    public class HomeController : Controller 
    {
        //localhost/home
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            var Greeting = saat > 12 ? "İyi Günler" : "Günaydın";
            return View(model: Greeting);
        }
    }
}