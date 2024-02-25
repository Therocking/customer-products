using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Custumers.Domain.Entities;

namespace Custumers.Infra.Persistence.Repositories.Interfaces
{
    public interface ICostumerRepository
    {
        Task Add(CostumerEntity entity);
        Task<List<CostumerEntity>> GetAll();
        Task<List<CostumerEntity>> GetAllByRegisterDate(DateTimeOffset registerDate);
        Task<CostumerEntity> GetById(string id);
        Task Update(CostumerEntity entity);
    }
}
