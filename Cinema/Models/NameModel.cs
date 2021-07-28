using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class NameModel
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int StyleId { set; get; }
        public int DirectorId { set; get; }
        public string Description { set; get; }
    public NameModel(string name, int styleId, int directorId, string description)
        {
            Name = name;
            StyleId = styleId;
            DirectorId = directorId;
            Description = description;
        }

    }
}
