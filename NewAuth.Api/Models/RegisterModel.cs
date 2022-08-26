using System.ComponentModel.DataAnnotations;

namespace NewAuth.Api.Models
{
    public class RegisterModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(1)]
        public string Password { get; set; }
    }
}
