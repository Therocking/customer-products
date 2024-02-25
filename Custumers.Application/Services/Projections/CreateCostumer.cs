using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Custumers.Application.Dtos;
using Custumers.Domain.Entities;

namespace Custumers.Application.Services.Projections
{
    public static class CreateCostumer
    {
        public static CostumerEntity DtoToEntity(CreateCostumerDto createDto)
        {
            var entity = new CostumerEntity
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = createDto.FirstName,
                LastName = createDto.LastName,
                Email = createDto.Email,
                Address = createDto.Address,
                PhoneNumber = createDto.PhoneNumber,
            };

            return entity;
        }
    }
}
