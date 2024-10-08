using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class OrderProduct:BaseEntity
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        [Required]
        public string ProductId { get; set; }
        public virtual Order Order { get; set; }
        [Required]
        public string OrderId { get; set; }
        public virtual Product Product { get; set; }
    }
}
