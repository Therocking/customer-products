﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custumers.Domain.Entities
{
    public class CostumerEntity
    {
        [Key]
        public string Id {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTimeOffset RegisterDate { get; set; }
        public DateTimeOffset? LastPurchaseDate { get; set;}
        [DefaultValue(true)]
        public bool IsDeleted { get; set; }
    }
}
