using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Web.DAL;
using ShoppingCart.Web.Models;

namespace ShoppingCart.Web.Controllers
{
    public class RoleController : Controller
    {
        private readonly CartDBContext _cartDBContext;

        public RoleController(CartDBContext cartDBContext)
        {
            _cartDBContext= cartDBContext;
        }
        public IActionResult Index()
        {
            RolesRepo rolesRepo=new RolesRepo(_cartDBContext);
            var data=rolesRepo.GetRoles();
            return View(data);
        }

        public IActionResult Create()
        {
            Role role = new Role();
            return View(role);
        }

        public IActionResult Edit(int Id)
        {
            RolesRepo rolesRepo = new RolesRepo(_cartDBContext);
            var data=rolesRepo.GetRolesById(Id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(int id, Role role)
        {
            RolesRepo rolesRepo = new RolesRepo(_cartDBContext);
            if (rolesRepo.UpdateRole(id, role))
            {
                return RedirectToAction("Index");
            }
            return View(role);
        }

        [HttpPost]
        public IActionResult Create(Role role)
        {
            RolesRepo rolesRepo = new RolesRepo(_cartDBContext);
            rolesRepo.AddRole(role);
            return RedirectToAction("Index");
           
        }

        public IActionResult Delete(int Id)
        {
            RolesRepo rolesRepo = new RolesRepo(_cartDBContext);
            var data = rolesRepo.GetRolesById(Id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(int id, Role role)
        {
            RolesRepo rolesRepo = new RolesRepo(_cartDBContext);
            if (rolesRepo.DeleteRole(id))
            {
                return RedirectToAction("Index");
            }
            return View(role);
        }
    }
}
