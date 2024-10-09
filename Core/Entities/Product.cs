using Core.helpers;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Product : BaseEntity
    {
        [StringLength(500, ErrorMessage = "consider a max length is 500 characters")]
        public string? Description { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "consider a max length is 100 characters")]
        public string Name { get; set; }
        [Required]
        [Range(typeof(decimal), "0", "79228162514264337593543950335")]
        public decimal Price { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Quantity in stock must be at least 0")]
        public int StockQuantity { get; set; }
        [ImageValidation(500)]
        public virtual ICollection<Image> ImageUrls { get; set; } = new List<Image>();
        public string CategoryId { get; set; }
        public Category category { get; set; }
        public virtual ICollection<Discount> Discounts { get; set; } = new List<Discount>();
        public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

    }
}
