using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class CinemaContext : DbContext
    {
        DbSet<CinemaDay> days { set; get; }
        DbSet<DirectorModel> directors { set; get; }
        DbSet<Film_in_Day> films_In_Day { set; get; }
        DbSet<NameModel> films { set; get; }
        DbSet<SessionModel> sessions { set; get; }
        DbSet<StyleModel> styles { set; get; }
        public CinemaContext(DbContextOptions<CinemaContext> options): base(options)
            {
            Database.EnsureCreated();
            }

    }
}
