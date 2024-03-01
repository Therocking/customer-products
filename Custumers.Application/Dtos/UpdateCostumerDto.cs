using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Custumers.Application.Dtos
{
    public class UpdateCostumerDto
    {
        public string? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address {  get; set; }
        public string PhoneNumber { get; set; }
    }
}
