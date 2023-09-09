using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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
        public IActionResult Apply(string Name,string Phone,string Email,bool WillAttend)
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