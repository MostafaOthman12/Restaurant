using Microsoft.AspNetCore.Mvc;

namespace ResturantApp.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
