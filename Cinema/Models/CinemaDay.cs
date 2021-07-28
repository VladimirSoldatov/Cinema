using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class CinemaDay
    {
        public int Id { set; get; }
        public List<Film_in_Day> film_In_Days { set; get; }
    }
}
