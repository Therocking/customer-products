using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyects.Domain.Entities
{
    public class ProductsEntity
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Stock {  get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public string? DeletedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set;}
        public DateTimeOffset? UpdatedDate { get; set;}
        public DateTimeOffset? DeleteDate {  get; set; }
    }
}
