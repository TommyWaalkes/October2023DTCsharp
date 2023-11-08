using Microsoft.AspNetCore.Mvc;

namespace APICreation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        public List<Car> Cars { get; set; } = new List<Car>()
        {
            new Car(){Id=1, MakeNModel="Ford Windstar", Mileage = 2000000}, 
            new Car(){Id=2, MakeNModel="Toyota Prius", Mileage = 100000}, 
            new Car(){Id=3, MakeNModel="Dodge Ram", Mileage=50000}
        };

        [HttpGet("GetCar/{Id}")]
        public Car GetCar(int Id)
        {
            Car c = Cars.Where(c => c.Id == Id).FirstOrDefault();
            return c;
        }

        [HttpGet("GetCars")]
        public List<Car> GetCars()
        {
            return Cars;
        }

    }
}
