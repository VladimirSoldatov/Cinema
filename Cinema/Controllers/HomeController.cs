using Cinema.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;
       // public List<NameModel> Message { set; get; }
        public CinemaContext db { set; get; }
        //public List<NameModel> users { set; get; }
        public List<NameModel> Films { set; get; }
        public List<StyleModel> Styles { set; get; }
        public List<DirectorModel> Directors { set; get; }
        public List<Film_in_Day> film_In_Days { set; get; }
        public List<SessionModel> Sessions { set; get; }
        public HomeController(CinemaContext cinemaContext)
        {
            db = cinemaContext;
        }

        public IActionResult Index()
        {
           
           Films = db.films.ToList();
           Styles = db.styles.ToList();
           Directors = db.directors.ToList();
            ViewBag.Films = Films;
            ViewBag.Styles = Styles;
            ViewBag.Directors = Directors;
           
            return View();
        }


        public IActionResult Privacy()
        {

            return View();
        }
        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Sessions = db.sessions.ToList(); ;
            film_In_Days = db.films_In_Day.ToList();
            var employeeOptions = Sessions.SelectMany(e => film_In_Days.Where(eo => eo.Id == e.Id).Select(eo => eo));
            
 
            film_In_Days = db.films_In_Day.ToList();
            ViewBag.Films_in_day = film_In_Days;
            ViewBag.Sessions = employeeOptions.ToList(); ;
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
