using Microsoft.AspNetCore.Mvc;
using SWAPIExample.Models;
using System.Diagnostics;

namespace SWAPIExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //In the view index will have a form that looks up SW characters by id
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Result(int id)
        {
            SWPerson p = SwapiDAL.GetPerson(id);
            return View(p);
        }

        public IActionResult PeopleList()
        {
            List<SWPerson> people = SwapiDAL.GetPeople();
            return View(people);
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