using System.ComponentModel.DataAnnotations;

namespace CoreApiWithJWT.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "UserName is required")]
        public string Username { get; set; }
    
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
