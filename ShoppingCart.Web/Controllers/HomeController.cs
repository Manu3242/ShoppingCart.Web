using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShoppingCart.Web.DAL;
using ShoppingCart.Web.Models;
using System.Diagnostics;
using System.IO;

namespace ShoppingCart.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CartDBContext _cartDBContext;

        public HomeController(ILogger<HomeController> logger, CartDBContext cartDBContext)
        {
            _logger = logger;
            _cartDBContext = cartDBContext;
        }

        public IActionResult Index()
        {
            //List<Role> roles = new List<Role>();
            ////RolesRepo rolesRepo = new RolesRepo(_cartDBContext);
            ////var roles = rolesRepo.GetRoles();
            
            //using (var client = new HttpClient())
            //{
            //    var response = client.GetAsync("http://localhost:5016/api/Roles/GetRoles").GetAwaiter().GetResult();
            //    if (response.IsSuccessStatusCode)
            //    {
            //        var responseContent = response.Content.ReadAsStringAsync().Result;
            //        roles = JsonConvert.DeserializeObject<List<Role>>(responseContent);

            //    }
            //}
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}