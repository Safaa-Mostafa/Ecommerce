﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class User:BaseEntity
    {
        public string? ProfilePicture { get; set; }
        public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
    }
}
