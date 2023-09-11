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
        public IActionResult Index()
        {
            return View();
        }
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
            return View();
        }
        [HttpGet]
        public IActionResult List()
        {
            return View();
        }

    }   
}