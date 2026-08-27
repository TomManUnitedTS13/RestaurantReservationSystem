using Microsoft.AspNetCore.Mvc;

namespace RestaurantReservationSystem.Controllers
{
    public class LoginController
    {
        public IActionResult Index()
        {
            return new ViewResult { ViewName = "~/Views/Login/Login.cshtml" };
        }

    }
}
