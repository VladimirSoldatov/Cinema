﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Models;

namespace Cinema.Models
{
    public class CreateCinema
    {
        public static void Initialize(CinemaContext context)
        {
            
            if (!context.films.Any())
            {
                  context.films.AddRange
                      (
                      new NameModel("Winter",4,4,"Фильм о зиме"),
                                            
                      new NameModel("Autem", 1, 1, "Фильм об осени"),
                      new NameModel("Summer", 2,2,"Фильм о лете"),
                      new NameModel("Spring", 3,3, "Фильм о весне")

                      );
            }
            
            if (!context.styles.Any())
            {
                context.styles.AddRange
                    (
                    new StyleModel { Name = "Комедия", Description = "Фильмы содержащие юмор" },
                    new StyleModel { Name = "Боевик", Description = "Фильмы с перестрелками" },
                  new StyleModel { Name = "Драма", Description = "Фильмы со страданиями героя" },
                  new StyleModel { Name = "Фантастика", Description = "Фильмы с не правоподобным сюжетом" }
                    );
            }
            if (!context.directors.Any())
            {
                context.directors.AddRange
                    (
                    new DirectorModel { Name ="Cameron", Description="SciSy"},
                    new DirectorModel { Name = "Merfy", Description = "Cam" },
                    new DirectorModel { Name = "Kafka", Description = "Fashio" },
                    new DirectorModel { Name = "Lenin", Description = "Communism" }

                    );
            }
            context.SaveChanges();
        }
    }
}
