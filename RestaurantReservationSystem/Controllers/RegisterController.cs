using Microsoft.AspNetCore.Mvc;

namespace RestaurantReservationSystem.Controllers
{
    public class RegisterController
    {
        public IActionResult Index()
        {
            return new ViewResult { ViewName = "~/Views/Login/Register.cshtml" };
        }
    }
}
