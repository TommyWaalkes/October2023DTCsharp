using IntroNet.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IntroNet.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            //Return view grabs and displays the matching cshtml file
            return View();
        }

        public IActionResult AnimalForm()
        {
            Animal a = new Animal();
            return View(a);
        }

        //This is some .Net magic, .Net is able to see the form input we just did 
        //And automatically map it to the property in my action. 
        public IActionResult Animal(Animal a)
        {
            //Animal a = new Animal() {
            //    Id = 1,
            //    Name = "Herbert",
            //    CaloriesNeeded = 4000,
            //    Species = "Elephant",
            //    HasClaws = false
            //};

            //This makes the model availiable in the view. 
            return View(a);
        }
    }
}