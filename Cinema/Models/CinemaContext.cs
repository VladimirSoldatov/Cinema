using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class CinemaContext : DbContext
    {
        public DbSet<CinemaDay> days { set; get; }
        public DbSet<DirectorModel> directors { set; get; }
        public DbSet<Film_in_Day> films_In_Day { set; get; }
        public DbSet<NameModel> films { set; get; }
        public DbSet<SessionModel> sessions { set; get; }
        public DbSet<StyleModel> styles { set; get; }
        public CinemaContext(DbContextOptions<CinemaContext> options): base(options)
            {
            Database.EnsureCreated();
            }

    }
}
