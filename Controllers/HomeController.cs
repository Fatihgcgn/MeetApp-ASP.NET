using MeetApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetApp.AddControllersWithViews
{
    public class HomeController : Controller
    {
        //localhost/home
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            ViewData["Greeting"] = saat > 12 ? "İyi Günler" : "Günaydın";
            int UserCount = Repository.Users.Where(info=>info.WillAttend == true).Count();

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul, Abc Kongre Merkezi",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = UserCount
            };

            return View(meetingInfo);
        }
    }
}
