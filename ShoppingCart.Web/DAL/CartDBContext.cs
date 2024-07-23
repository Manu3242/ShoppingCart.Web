using Microsoft.EntityFrameworkCore;
using ShoppingCart.Web.Models;

namespace ShoppingCart.Web.DAL
{
    public class CartDBContext : DbContext
    {
        public CartDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Catagory> Categories { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
       

    }
}
