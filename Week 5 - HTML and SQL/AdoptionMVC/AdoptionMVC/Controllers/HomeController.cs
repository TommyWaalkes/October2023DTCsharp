using AdoptionMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AdoptionMVC.Controllers
{
    public class HomeController : Controller
    {
        AdoptionMvcContext db = new AdoptionMvcContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Pet> pets = db.Pets.ToList();
            //List<string> breeds = pets.Distinct(p =>p.breed).ToList();
            List<string> breeds = new List<string>();
            for(int i = 0; i < pets.Count; i++)
            {
                string breed = pets[i].Breed;
                if (breeds.Contains(breed) == false)
                {
                    breeds.Add(breed);
                }
            }

            return View(breeds);
        }

        public IActionResult Result(string breed)
        {
            List<Pet> pets = db.Pets.Where( p => p.Breed == breed ).ToList();
            return View(pets);
        }

        public IActionResult Adopt(int id)
        {
            Pet p = db.Pets.Find(id);
            db.Pets.Remove(p);
            db.SaveChanges();
            return View("Index");
        }

        //This is for display the add view
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Pet p)
        {
            db.Pets.Add(p);
            db.SaveChanges();
            //This just goes to the view
            //return View("Index");
            //This calls the action and the action decides where to go 
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