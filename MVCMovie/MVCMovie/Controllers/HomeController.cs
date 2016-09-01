
using MVCMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMovie.Controllers
{
    public class HomeController : Controller
    {

        private MoviesDBAurelijaEntities db = new MoviesDBAurelijaEntities();


        // GET: Home
        public ActionResult Index()
        {
            var movies = from m in db.Movies
                         select m;

            return View();
        }
    }
}