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
        public List<NameModel> Message { set; get; }
        public CinemaContext db { set; get; }
        public List<NameModel> users { set; get; }
        public List<NameModel> Films { set; get; }
        public List<StyleModel> Styles { set; get; }
        public List<DirectorModel> Directors { set; get; }

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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
