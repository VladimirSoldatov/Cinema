using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class SessionModel
    {
        public string Name { set; get; }
        public string Time { set; get; }
        public int Id { set; get; }
        public SessionModel(string name, string time)
        {
            Name = name;
            Time = time;
        }
    }
}
