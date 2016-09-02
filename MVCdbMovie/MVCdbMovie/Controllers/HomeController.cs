using MVCdbMovie.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCdbMovie.Controllers
{
    public class HomeController : Controller
    {
        private MoviesDBAurelijaEntities db = new MoviesDBAurelijaEntities();

        // GET: Home
        public ActionResult Index(string movieGenre)
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
            db.Entry(movie).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Delete (int? ID)
        {
            Movie movie = db.Movies.Find(ID);
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
            db.Movies.Add(movie);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}