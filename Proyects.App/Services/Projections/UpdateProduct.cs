using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyects.App.Dtos;
using Proyects.Domain.Entities;

namespace Proyects.App.Services.Projections
{
    public static class UpdateProduct
    {
        public static ProductsEntity DtoToEntity(UpdateProductDto updateDto)
        {
            var entity = new ProductsEntity
            {
                Name = updateDto.Name,
                Description = updateDto.Description,
                Price = updateDto.Price,
                Stock = updateDto.Stock,
                UpdatedBy = updateDto.UpdatedBy,
                Category = updateDto.Category,
            };

            return entity;
        }
    }
}
