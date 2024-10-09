namespace Core.Entities
{
    public class Image : BaseEntity
    {
        public string Url { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}
