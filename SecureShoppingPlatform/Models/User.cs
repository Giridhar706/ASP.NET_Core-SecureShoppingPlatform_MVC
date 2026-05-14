using System.ComponentModel.DataAnnotations;

namespace SecureShoppingPlatform.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MinLength(8)]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[^\w\s]).+$",
        ErrorMessage = "Password must contain uppercase, number and special character.")]
        public string Password { get; set; } = string.Empty;

        public string Role { get; set; } = "Customer";
    }
}