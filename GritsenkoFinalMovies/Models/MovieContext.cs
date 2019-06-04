using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GritsenkoFinalMovies.Models
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
    public class MovieObInitializer : DropCreateDatabaseAlways<MovieContext>
    {
        protected override void Seed(MovieContext db)
        {
            db.Movies.Add(new Movie { Name = "Transformers", Director = "Michael Bay", Price = 5 });
            db.Movies.Add(new Movie { Name = "The Equalizer", Director = "Antoine Fuqua", Price = 7 });
            db.Movies.Add(new Movie { Name = "The Matrix", Director = "Wachowski Sisters", Price = 4 });

            base.Seed(db);
        }
    }
}