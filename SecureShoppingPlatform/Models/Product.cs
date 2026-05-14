using System.ComponentModel.DataAnnotations;

namespace SecureShoppingPlatform.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(1,100000)]
        public decimal Price { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;
    }
}