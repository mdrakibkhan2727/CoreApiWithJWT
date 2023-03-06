using System.ComponentModel.DataAnnotations;

namespace CoreApiWithJWT.Models
{
    public class Register
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="UserName is required")]
        public string Username { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Password is required")]
        public string Password { get; set; }
    }
}
