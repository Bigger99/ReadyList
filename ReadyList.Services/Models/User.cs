using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ReadyList.Database.Models
{
    public class User
    {
        public Guid UserId { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }

        [PasswordPropertyText]
        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }

        [MaxLength(25)]
        public string? FirstName { get; set; }

        [MaxLength(25)]
        public string? MiddleName { get; set; }

        public string? LastName { get; set; }
    }
}
