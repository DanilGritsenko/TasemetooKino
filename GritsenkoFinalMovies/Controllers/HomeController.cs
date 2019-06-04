using GritsenkoFinalMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace GritsenkoFinalMovies.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        MovieContext db = new MovieContext();
        UserContext db2 = new UserContext();
        public ActionResult Index()
        {
            var movies = db.Movies;
            ViewBag.Movies = movies;
            return View();
        }

        [Authorize(Roles="admin")]
        public ActionResult About()
        {
            ViewBag.Movies = db.Movies;
            ViewBag.Purchases = db.Purchases;
            ViewBag.Users = db2.Users;
            ViewBag.Roles = db2.Roles;

            return View();
        }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.MovieId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return "Спасибо," + purchase.Person + " за покупку!";
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}