using ShoppingCart.Web.Models;

namespace ShoppingCart.Web.DAL
{
    public class UsersRepo
    {
        private readonly CartDBContext _cartDBContext;

        public UsersRepo(CartDBContext cartDBContext)
        {
            _cartDBContext = cartDBContext;
        }

        public bool AddUser(User user)
        {
            try
            {
                //user.Roleid = 2;
                _cartDBContext.Users.Add(user);
                _cartDBContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public User GetUser(string email, string password)
        {
            User user = null;
            try
            {
                //user.Roleid = 2;
                user  = _cartDBContext.Users.FirstOrDefault(a => a.Emailid == email && a.Password == password);
                return user;
            }
            catch (Exception ex)
            {

                return user;
            }
        }
    }
}
