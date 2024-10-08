using Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Discount : BaseEntity
    {
        [Required]
        [StringLength(100, ErrorMessage = "discount name must be less than 100 characters")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Range(0, 100, ErrorMessage = "should be between 0 and 100")]
        public decimal DiscountPercentage { get; set; }

        public Status Status { get; set; }
        public string ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
