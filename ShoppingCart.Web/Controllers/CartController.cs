using Microsoft.AspNetCore.Mvc;

namespace ShoppingCart.Web.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
