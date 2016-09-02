using MVCdbMovie.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVCdbMovie.Controllers
{
    public class HomeController : Controller
    {
        private MoviesDBAurelijaEntities db = new MoviesDBAurelijaEntities();

        // GET: Home
        public ActionResult Index(string movieGenre, string searchString)
        {
            //creating the listbox for selecting by genre
            var genreList = new List<string>();
            var genreQuery = from d in db.Movies
                             orderby d.Genre
                             select d.Genre;

            genreList.AddRange(genreQuery.Distinct());
            ViewBag.movieGenre = new SelectList(genreList);

            //LINQ query to get records from the DB
            var movies = from m in db.Movies
                         select m;
            //select by genre
            if (!String.IsNullOrEmpty(movieGenre))
            {
                movies = movies.Where(x => x.Genre == movieGenre);
            }
            //select by title 
            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title.Contains(searchString));
            }

            return View(movies);
        }
        //? is for optional parametet 
         public ActionResult Details (int? ID)
        {
            Movie movie = db.Movies.Find(ID);
            return View(movie);

        }

        public ActionResult Edit (int? ID)
        {
            Movie movie = db.Movies.Find(ID);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(movie);
            }

        }
        public ActionResult Delete (int? ID)
        {
            if (ID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            Movie movie = db.Movies.Find(ID);
            if(movie == null)
            {
                return HttpNotFound(); //if someone tries to delete something absent its not found 
            }
            return View(movie);
        }
        [HttpPost, ActionName("Delete")]
        
        public ActionResult DeleteConfirm(int? ID)
        {
            Movie movie = db.Movies.Find(ID);
            db.Movies.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(Movie movie)

        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(movie);
            }

        }
    }
}