using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Address:BaseEntity
    {
        [Required]
        [MaxLength(200, ErrorMessage = "maximum length should be under 200 characters")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        [Required]
        public string PostCode { get; set; }
        [RegularExpression("^(010|011|012|015)[0-9]{8}$\r\n", ErrorMessage = "please enter only valid number")]
        public string MobileNumber { get; set; }

        public string userId { get; set; }
        public virtual User User { get; set; }
    }
}
