using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Custumers.Application.Dtos;

namespace Custumers.Application.Intefaces
{
    public interface ICostumerService
    {
        Task<ResponseCostumerDto> Add(CreateCostumerDto createDto);
        Task<List<ResponseCostumerDto>> GetAll();
        Task<List<ResponseCostumerDto>> GetAllByRegisterDate(DateTimeOffset registerDate);
        Task<ResponseCostumerDto> GetById(string id);
        Task<ResponseCostumerDto> Update(UpdateCostumerDto updateDto);
        Task<ResponseCostumerDto> Delete(string id);
    }
}
