using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //The new user object gets filled out with values from our form automatically. It pulls the value from the URL of our app
        public IActionResult Result(NewUser user)
        {
            return View(user);
        }

        //This approach is useful if you have a few properties or don't have/want a model for something
        public IActionResult LongResult(string FirstName, string LastName, string Email, string Password)
        {
            NewUser user = new NewUser();
            user.FirstName = FirstName;
            user.LastName = LastName;
            user.Email = Email;
            user.Password = Password;

            //This is how you redirect to other actions, there are many overloads, but all need a string of the name of the action 
            //You want to redirect to. Also, if an action needs a model or models, you will need to feed those in as well. 
            return RedirectToAction("Result", user);
        }

        public IActionResult NewUserForm()
        {
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