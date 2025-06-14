using System.ComponentModel.DataAnnotations;

namespace TQMS_Admin_Identity.Models.Authentication.Login
{
    public class Login
    {
        [Required(ErrorMessage ="Username is required")]
        public string? Username { get; set; }

        [Required(ErrorMessage ="Password is required")]
        public string? Password { get; set; }
    }
}
