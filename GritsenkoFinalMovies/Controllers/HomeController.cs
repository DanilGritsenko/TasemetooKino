using GritsenkoFinalMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace GritsenkoFinalMovies.Controllers
{
    // Модель для основного (первого) контролера, единственный контролер который видит пользователь
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
        // админ панель (Не стал пачкаться с переименованием страниц и т.д)
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
            ViewBag.MovieId = id; // При клике "Купить" берёт ИД выбранного фильма
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return "Thank you, " + purchase.Person + " for your purchase!";
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}