using System.ComponentModel.DataAnnotations;

namespace TQMS_Admin_Identity.Models.Authentication.SignUp
{
    public class RegisterUser
    {
        [Required(ErrorMessage ="Username is required")]
        public string? Username { get; set; }
        [Required(ErrorMessage ="EmailID is required")]
        public string? Email { get; set; }

        [Required(ErrorMessage ="Password is required")]
        public string? Password { get; set; }
    }
}
