using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Custumers.Application.Dtos;
using Custumers.Domain.Entities;

namespace Custumers.Application.Services.Projections
{
    public static class ResponseCostumer
    {
        public static ResponseCostumerDto EntityToDto(CostumerEntity entity)
        {
            var dtos = new ResponseCostumerDto
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Email = entity.Email,
                PhoneNumber = entity.PhoneNumber,
                Address = entity.Address,
                LastPurchaseDate = entity.LastPurchaseDate,
            };

            return dtos;
        }
    }
}
