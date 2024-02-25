using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyects.Domain.Entities;

namespace Products.Infra.Persistence.Context
{
    public class ProductsContext: DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options): base(options) { }

        public DbSet<ProductsEntity> Product {  get; set; }
    }
}
