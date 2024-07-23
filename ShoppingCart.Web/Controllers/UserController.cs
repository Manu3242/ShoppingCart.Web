using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Web.BAL;
using ShoppingCart.Web.DAL;
using ShoppingCart.Web.Models;

namespace ShoppingCart.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly CartDBContext _cartDBContext;
        public UserController(CartDBContext cartDBContext)
        {

            _cartDBContext = cartDBContext;
        }
        public IActionResult Registration()
        {
            UserVM userVM = new UserVM();

            return View("SignUP", userVM);
        }

        [HttpPost]
        public IActionResult UserSignUP(UserVM userVM)
        {
            if (ModelState.IsValid)
            {
                // Insert to DB.
                UserBAL userBAL = new UserBAL(_cartDBContext);
                if (userBAL.InsertUser(userVM))
                {
                    TempData["user"] = userVM.Firstname + " " + userVM.Lastname;
                    return RedirectToAction("Index", "Cart");
                }
            }

            return View("SignUP", userVM);
        }

        public IActionResult Login()
        {
            LoginVM loginVM = new LoginVM();
            return View(loginVM);
        }

        [HttpPost]
        public IActionResult Login(LoginVM userVM)
        {
            if (ModelState.IsValid)
            {
                UserBAL userBAL = new UserBAL(_cartDBContext);
                var user = userBAL.GetUser(userVM.UserName, userVM.Password);
                if (user != null && user.Roleid == 1)
                {
                    return RedirectToAction("Index", "Role");
                }
                else if (user != null && user.Roleid > 1)
                {
                    return RedirectToAction("Index", "Cart");
                }
                else
                {
                    ViewBag.Message = "Invalid credentials";
                }
                return View();
            }
            return View();
        }
    }
}
