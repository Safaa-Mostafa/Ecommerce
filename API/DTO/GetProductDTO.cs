namespace API.DTO
{
    public class GetProductDTO
    {
        public string? Description { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public ICollection<string> ImageUrls { get; set; } 
        public string CategoryName { get; set; } 
        public ICollection<string> DiscountNames { get; set; } 

    }
}
