using EntityIntro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EntityIntro.Controllers
{
    public class HomeController : Controller
    {
        public MovieTheaterContext db = new MovieTheaterContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Technically the db.table syntax return an ienumerable which can just call toList on
            List<Movie> movies = db.Movies.ToList();
            return View(movies);
        }

        //This action is a get that exists to display our view 
        public IActionResult CreateMovie()
        {
            return View();
        }

        //This second actions exists to add the movie to our table and redirect us to the main listing
        [HttpPost]
        public IActionResult CreateMovie(Movie movie)
        {
            db.Movies.Add(movie);
            //This needs to be called after any create, delete or edit actions 
            db.SaveChanges();

            return RedirectToAction("Index");
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