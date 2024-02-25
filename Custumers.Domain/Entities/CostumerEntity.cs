using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custumers.Domain.Entities
{
    public class CostumerEntity
    {
        public string Id {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTimeOffset RegisterDate { get; set; }
        public DateTimeOffset? LastPurchaseDate { get; set;}
        public bool? IsDeleted { get; set; }
    }
}
