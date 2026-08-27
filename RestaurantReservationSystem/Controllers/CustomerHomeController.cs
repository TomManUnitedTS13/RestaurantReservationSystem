using Microsoft.AspNetCore.Mvc;

namespace RestaurantReservationSystem.Controllers
{
    public class CustomerHomeController : Controller
    {
        public IActionResult Index()
        {
            return new ViewResult { ViewName = "~/Views/Customer/Home.cshtml" };
        }
    }
}
