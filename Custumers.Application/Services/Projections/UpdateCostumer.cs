using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Custumers.Application.Dtos;
using Custumers.Domain.Entities;

namespace Custumers.Application.Services.Projections
{
    public static class UpdateCostumer
    {
        public static CostumerEntity DtoToEntity(UpdateCostumerDto updateDto, CostumerEntity costumerEntity)
        {
            costumerEntity.FirstName = updateDto.FirstName;
            costumerEntity.PhoneNumber = updateDto.PhoneNumber;
            costumerEntity.LastName = updateDto.LastName;
            costumerEntity.Address = updateDto.Address;

            return costumerEntity;
        }
    }
}
