using Microsoft.AspNetCore.Mvc;
using RestaurantReservationSystem.Models;
using System.Diagnostics;

namespace RestaurantReservationSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return new ViewResult { ViewName = "~/Views/Home/Home.cshtml" };
        }
    }
}
