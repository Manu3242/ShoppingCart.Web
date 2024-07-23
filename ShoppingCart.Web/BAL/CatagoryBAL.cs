using ShoppingCart.Web.DAL;
using ShoppingCart.Web.Models;

namespace ShoppingCart.Web.BAL
{
    public class CatagoryBAL
    {
        private readonly CartDBContext _cartDBContext;
        public CatagoryBAL(CartDBContext cartDBContext)
        {
            _cartDBContext = cartDBContext;
        }

        public bool AddCatagory(CatagoryVM catagoryVM)  //new
        {
            Catagory catagory = new Catagory();      //old
            catagory.Name = catagoryVM.Name;
            catagory.Description = catagoryVM.Description;

            CatagoryRepo catagoryRepo = new CatagoryRepo(_cartDBContext);
            if (catagoryRepo.AddCatagory(catagory))
            {
                return true;
            }
            return false;
        }

        public bool EditCatagory(int Id, CatagoryVM catagoryVM)
        {
            CatagoryRepo catagoryRepo = new CatagoryRepo(_cartDBContext);
            Catagory catagory = new Catagory();

            catagory.Name = catagoryVM.Name;
            catagory.Description = catagoryVM.Description;

            catagoryRepo.UpdateCatagory(Id, catagory);
            return true;
        }
    }
}
