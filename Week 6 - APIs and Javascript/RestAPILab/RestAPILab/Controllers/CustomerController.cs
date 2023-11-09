using Microsoft.AspNetCore.Mvc;
using RestAPILab.Models;

namespace RestAPILab.Controllers
{
    [ApiController]
    [Route("Customers")]
    public class CustomerController : ControllerBase
    {
        NorthwndContext db = new NorthwndContext();

        [HttpGet]
        public List<Customer> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        [HttpGet("{index}")]
        public Customer GetCustomer(int index)
        {
            List<Customer> customers = db.Customers.ToList();
            //Is the index in range
            if(index >= 0 && index < customers.Count)
            {
                return customers[index];
            }
            else
            {
                try
                {
                    throw new Exception("Index was not in the correct range: 0 to " + (customers.Count - 1));
                }
                catch(Exception e)
                {
                    Customer error = new Customer();
                    error.CustomerId = e.Message;
                    return error;
                }
            }
        }

        [HttpPost]
        public void AddCustomer(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
        }

        [HttpPut("{id}")]
        public void UpdateCustomer(string id, Customer newValues)
        {
           // Customer oldValues = db.Customers.Find(id);
            newValues.CustomerId = id;
            db.Customers.Update(newValues); 
            db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void DeleteCustomer(string id)
        {
            //We need to delete Orders and CustomerTypes before delete the customer themselves 
            Customer c = db.Customers.Find(id);
            List<Order> orders = db.Orders.Where(o => o.CustomerId == c.CustomerId).ToList();

            for(int i = 0; i < orders.Count; i++)
            {
                Order o = orders[i];
                List<OrderDetail>ods =  db.OrderDetails.Where( d => d.OrderId == o.OrderId).ToList();
                db.OrderDetails.RemoveRange(ods);
            }
          
            db.Orders.RemoveRange(orders);

            db.Customers.Remove(c);
            db.SaveChanges();
        }
        
    }
}
