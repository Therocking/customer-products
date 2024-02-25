using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyects.App.Dtos;
using Proyects.Domain.Entities;

namespace Proyects.App.Services.Projections
{
    public static class ResponseProduct
    {
        public static ResposeProductDto EntityToProduct(ProductsEntity entity)
        {
            var dto = new ResposeProductDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                Price = entity.Price,
                Stock = entity.Stock,
                Category = entity.Category,
            };

            return dto;
        }
    }
}
