using Microsoft.AspNetCore.Mvc;
using MockAssessment6.Models;
using System.Diagnostics;

namespace MockAssessment6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public EmployeeDb2Context db = new EmployeeDb2Context();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Employees()
        {
            List<Employee> employees = db.Employees.ToList();
            return View(employees);
        }

        public IActionResult RetirementInfo(int id)
        {
            Employee e = db.Employees.Find(id);
            RetirementInfo ri = new RetirementInfo();

            if(e.Age >= 60)
            {
                ri.CanRetire = true;
            }
            else
            {
                ri.CanRetire = false;
            }
            Decimal benefitsPercent = 0.6m;
           // float retirement =
            ri.Benefits = (float) (e.Salary * benefitsPercent);
            return View(ri);
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