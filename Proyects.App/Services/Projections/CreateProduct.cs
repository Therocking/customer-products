using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyects.App.Dtos;
using Proyects.Domain.Entities;

namespace Proyects.App.Services.Projections
{
    public static class CreateProduct
    {
        public static ProductsEntity DtoToEntity(CreateProductDto createDto)
        {
            var entity = new ProductsEntity
            {
                Id = Guid.NewGuid().ToString(),
                Name = createDto.Name,
                Description = createDto.Description,
                Price = createDto.Price,
                CreatedBy = createDto.CreatedBy,
                Category = createDto.Category,
            };
            return entity;
        }
    }
}
