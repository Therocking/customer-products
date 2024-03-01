using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Custumers.Application.Dtos;
using Custumers.Application.Exceptions;
using Custumers.Application.Intefaces;
using Custumers.Application.Services.Projections;
using Custumers.Infra.Persistence.Repositories.Interfaces;

namespace Custumers.Application.Services
{
    public class CostumerService : ICostumerService
    {
        private readonly ICostumerRepository _repository;

        public CostumerService(ICostumerRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResponseCostumerDto> Add(CreateCostumerDto createDto)
        {
            var newCostumer = CreateCostumer.DtoToEntity(createDto);
            await _repository.Add(newCostumer);

            return ResponseCostumer.EntityToDto(newCostumer);
        }

        public async Task<ResponseCostumerDto> Delete(string id)
        {
            var costumer = await _repository.GetById(id);
            if (costumer is null) throw new CostumerNotFound();

            costumer.IsDeleted = true;
            await _repository.Update(costumer);

            return ResponseCostumer.EntityToDto(costumer);
        }

        public async Task<List<ResponseCostumerDto>> GetAll()
        {
            var costmers = await _repository.GetAll();

            return costmers.Select(x => ResponseCostumer.EntityToDto(x)).ToList();
        }

        public async Task<List<ResponseCostumerDto>> GetAllByRegisterDate(DateTimeOffset registerDate)
        {
            var costumers = await _repository.GetAllByRegisterDate(registerDate);

            return costumers.Select(x => ResponseCostumer.EntityToDto(x)).ToList();
        }

        public async Task<ResponseCostumerDto> GetById(string id)
        {
            var costumer = await _repository.GetById(id);
            if (costumer is null) throw new CostumerNotFound();

            return ResponseCostumer.EntityToDto(costumer);
        }

        public async Task<ResponseCostumerDto> Update(UpdateCostumerDto updateDto)
        {
            var costumer = await _repository.GetById(updateDto.Id);
            if (costumer is null) throw new CostumerNotFound();

            var costumerUpdated = UpdateCostumer.DtoToEntity(updateDto, costumer);
            await _repository.Update(costumerUpdated);

            return ResponseCostumer.EntityToDto(costumerUpdated);
        }
    }
}
