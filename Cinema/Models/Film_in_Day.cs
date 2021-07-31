using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class Film_in_Day
    {
        public int Id { get; set; }
        public string Date { set; get; }
        public int NameModelId { set; get; }
        public List<SessionModel> sessions { set; get; }
        

    }
}
