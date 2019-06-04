using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GritsenkoFinalMovies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [DataType(DataType.Text)]
        [Required]
        public string Name { get; set; }
        [DataType(DataType.Text)]
        [Required]
        public string Director { get; set; }
        [DataType(DataType.Text)]
        [Required]
        public DateTime Date { get; set; }
        [DataType(DataType.Text)]
        [Required]
        public int Price { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}