using ShoppingCart.Web.DAL;
using ShoppingCart.Web.Models;

namespace ShoppingCart.Web.BAL
{
    public class UserBAL
    {
        private readonly CartDBContext _dbContext;
        public UserBAL(CartDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool InsertUser(UserVM userVM)
        {
            UsersRepo userRepo = new UsersRepo(_dbContext);
            User user = new User();
            user.Firstname = userVM.Firstname;
            user.Lastname = userVM.Lastname;
            user.Emailid = userVM.Emailid;
            user.Password = userVM.Password;
            user.Address = userVM.Address;


            return userRepo.AddUser(user);
        }

        public User GetUser(string  username,string password)
        {
            UsersRepo userRepo = new UsersRepo(_dbContext);

            return userRepo.GetUser(username, password);
        }
    }
}
