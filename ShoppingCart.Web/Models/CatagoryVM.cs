using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Web.Models
{
    public class CatagoryVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter Name")]
        [MaxLength(50,ErrorMessage ="Catagory name should be less than 50 chars")]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
