using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Category : BaseEntity
    {
        [Required]
        [StringLength(100, ErrorMessage = "maximum character should be less than 100 characters")]
        public string Name { get; set; }
        [StringLength(500, ErrorMessage = "maximum character should be less than 500 characters")]
        public string? Description { get; set; }
        [StringLength(500, ErrorMessage = "The maximum length for the image URL is 500 characters")]
        public Image Image { get; set; }
        
        public IEnumerable<Product> Products { get; set; } = new List<Product>();
        public string? ParentCategoryId { get; set; }
        public Category? ParentCategory { get; set; }
        public ICollection<Category> SubCategories { get; set; } = new List<Category>();

    }
}
