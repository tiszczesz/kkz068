using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw9_sqlite.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [DisplayName("Tytuł filmu")]
        public string Title { get; set; }

        [DisplayName("Reżyser")]
        public string Director { get; set; }

        [DisplayName("Rok produkcji")]
        public int Year { get; set; }

        [DisplayName("Cena")]
        public decimal Price { get; set; }
    }
}
