using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Order:BaseEntity
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Amount in order must be at least 1")]
        public decimal Amount { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;

        [Required]
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();


    }
}
