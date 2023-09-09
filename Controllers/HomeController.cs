using Microsoft.AspNetCore.Mvc;

namespace MeetApp.AddControllersWithViews
{
    public class HomeController : Controller 
    {
        //localhost/home
        public IActionResult Index()
        {
            return View();
        }
    }
}