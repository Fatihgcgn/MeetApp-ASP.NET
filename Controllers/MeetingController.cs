using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MeetApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MeetApp.Controllers
{
    public class MeetingController : Controller
    {
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            // Console.WriteLine(Name);
            // Console.WriteLine(Phone);
            // Console.WriteLine(Email);
            // Console.WriteLine(WillAttend);

            Repository.CreateUser(model);
            ViewBag.UserCount = Repository.Users.Where(info=>info.WillAttend == true).Count();
            return View("Thanks", model);
        }
        [HttpGet]
        public IActionResult List()
        {
            return View(Repository.Users);
        }

        //meeting/details/1
        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }
    }   
}