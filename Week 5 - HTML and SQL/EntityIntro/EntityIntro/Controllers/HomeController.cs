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

        public IActionResult Movie(int id)
        {
            Movie m = db.Movies.Find(id);
            return View(m);
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

        //We will use the id to find the movie we want to update
        public IActionResult UpdateMovie(int id)
        {
            Movie update = db.Movies.Find(id);
            return View(update);
        }

        [HttpPost]
        public IActionResult UpdateMovie(Movie m)
        {
            db.Movies.Update(m);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //This display a view asking if you are sure you want to delete this movie
        public IActionResult DeleteMovie(int id)
        {
            Movie m = db.Movies.Find(id);
            return View(m);
        }
       
        public IActionResult IAmSureDeleteMovie(int id)
        {
            Movie m = db.Movies.Find(id);
            db.Movies.Remove(m);
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