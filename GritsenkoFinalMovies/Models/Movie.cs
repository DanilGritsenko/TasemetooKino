using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GritsenkoFinalMovies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
    }
}