using Microsoft.AspNetCore.Mvc;
using Pratik2_Basic.Models;

namespace Pratik2_Basic.Controllers
{
    public class CustomerOrderController : Controller
    {
        CustomerOrderViewModel newModel = new CustomerOrderViewModel()
        {
            Customer = new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john@doe.com"
            },
            Orders = new List<Order>{
                new Order{Id=1, Price=1, ProductName="A", Quantity=1},
                new Order{Id=2, Price=2, ProductName="B", Quantity=2},
                new Order{Id=3, Price=3, ProductName="C", Quantity=3}
            }
        };
        public IActionResult Index()
        {
            return View(newModel);
        }
    }
}