using Invitation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Invitation.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]

        public ViewResult RsvpForm(Class1 guestResponse)
        {
            if(ModelState.IsValid)
            {
                return View("Thanks", guestResponse); //make sure you build the solution before doing anything else
            }
            else
            {
                return View();
            }
            
        }
    }
}