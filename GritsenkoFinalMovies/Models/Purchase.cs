using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GritsenkoFinalMovies.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        [DataType(DataType.Text)]
        [Required]
        public string Person { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Address { get; set; }
        [DataType(DataType.Text)]
        public DateTime Date { get; set; }
        public int MovieId { get; set; }

        public virtual Movie Movie { get; set; }
    }
}