using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyects.App.Dtos
{
    public class UpdateProductDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string? UpdatedBy { get; set; }
        public int Stock { get; set; }
    }
}
