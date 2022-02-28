using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Controllers
{
    public class OrdersController1 : Controller
    {
        public IActionResult Index()
        {
            var orders = new List<string>();
            return View();
        }
    }
}
