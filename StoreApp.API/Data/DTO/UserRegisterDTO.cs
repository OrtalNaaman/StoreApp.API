using System.ComponentModel.DataAnnotations;

namespace StoreApp.API.Data.DTO
{
    public class UserRegisterDTO
    {
        [Required]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string UserName { get; set; }
    }
}
