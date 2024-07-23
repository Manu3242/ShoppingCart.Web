using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Web.Models
{
    public class UserVM
    {
        public int Id { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        [EmailAddress]
        public string Emailid { get; set; }

        [Required]
        [StringLength(8)]
        [MinLength(2)]
        public string Password { get; set; }

        [Required]
        [MaxLength(250)]
        public string Address { get; set; }
        
    }
}
