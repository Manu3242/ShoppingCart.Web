using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Web.Models
{
    public class LoginVM
    {
        [Required]
        [EmailAddress]
        public string UserName { get; set; }

        [Required]
        
        public string  Password { get; set; }
    }
}
