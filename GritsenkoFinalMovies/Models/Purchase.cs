using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GritsenkoFinalMovies.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public string Person { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public int MovieId { get; set; }

        public virtual Movie Movie { get; set; }
    }
}