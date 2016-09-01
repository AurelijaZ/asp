using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCdemo1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int id = 500)
        {
            ViewBag.NumberOfTimes = id;
            return View();
        }

        public ActionResult About(string myName = "", int myNumber = 1)
        {
            ViewBag.Message = "Hello, " + myName + " you typed in the number " + myNumber;

            return View();
        }

        public ActionResult Contact(int id= 5)
        {
            ViewBag.Message = "You chose the number " + id; 

            return View();
        }
    }
}