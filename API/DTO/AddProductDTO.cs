using Core.helpers;
using System.ComponentModel.DataAnnotations;

namespace API.DTO
{
    public class AddProductDTO
    {
        [StringLength(500, ErrorMessage = "The maximum length for the description is 500 characters.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(100, ErrorMessage = "The maximum length for the product name is 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Product price is required.")]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Price must be a non-negative decimal value.")]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Quantity in stock must be at least 0.")]
        public int StockQuantity { get; set; }

        [ImageValidation(500, ErrorMessage = "Each image URL cannot exceed 500 characters.")]
        public virtual ICollection<IFormFile> ImageUrls { get; set; }

        [Required(ErrorMessage = "Category ID is required.")]
        public string CategoryId { get; set; }
    }

}
