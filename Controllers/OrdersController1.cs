using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers
{
    public class OrdersController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
