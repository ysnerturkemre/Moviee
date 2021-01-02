using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Moviee.Models;

namespace Moviee.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        DbMovieEntities db = new DbMovieEntities();
        public ActionResult Index()
        {

            var movies = db.TblMovie.ToList();
            return View(movies);
        }

        [HttpGet]
        public ActionResult Movieadd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Movieadd(TblMovie t)
        {
            db.TblMovie.Add(t);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MovieDelete(int id)
        {
            var movie = db.TblMovie.Find(id);
            db.TblMovie.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MovieUpdate(int id)
        {
            var mov = db.TblMovie.Find(id);
            return View("MovieUpdate", mov);
        }
        public ActionResult MovieUpdatee(TblMovie t)
        {
            var movie = db.TblMovie.Find(t.MovieId);
            movie.Name = t.Name;
            movie.Director = t.Director;
            movie.MovieYear = t.MovieYear;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}