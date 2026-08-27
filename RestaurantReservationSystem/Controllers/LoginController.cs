using Microsoft.AspNetCore.Mvc;

namespace RestaurantReservationSystem.Controllers
{
    public class LoginController : Controller   
    {
        public IActionResult Index()            
        {
            return View("~/Views/Login/Login.cshtml");
        }

    }
}
