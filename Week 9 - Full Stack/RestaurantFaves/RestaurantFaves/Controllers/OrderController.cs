using Microsoft.AspNetCore.Mvc;
using RestaurantFaves.Models;

namespace RestaurantFaves.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        RestaurantFavesContext db = new RestaurantFavesContext();

        [HttpGet]
        public List<Order> GetOrders()
        {
            return db.Orders.ToList();
        }

        [HttpGet("{id}")]
        public Order GetOrder(int id)
        {
            Order output = db.Orders.Find(id);
            return output;
        }

        [HttpPost]
        public void AddOrder(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
        }

        [HttpPost("{id}")]
        public void UpdateOrder(int id, Order body)
        {
            body.Id = id;
            db.Orders.Update(body);

            db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void DeleteOrder(int id)
        {
            Order deleted = db.Orders.Find(id);
            db.Orders.Remove(deleted);
            db.SaveChanges();
        }
    }
}
