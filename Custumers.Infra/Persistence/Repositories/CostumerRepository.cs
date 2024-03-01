using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Custumers.Domain.Entities;
using Custumers.Infra.Persistence.Context;
using Custumers.Infra.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Custumers.Infra.Persistence.Repositories
{
    public class CostumerRepository : ICostumerRepository
    {
        private readonly CostumerContext _context;

        public CostumerRepository(CostumerContext context)
        {
            _context = context;
        }

        public async Task Add(CostumerEntity entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<CostumerEntity>> GetAll()
        {
            return await _context.Costumers.Where(x => !x.IsDeleted).ToListAsync();
        }

        public async Task<List<CostumerEntity>> GetAllByRegisterDate(DateTimeOffset registerDate)
        {
            return await _context.Costumers.Where(x => x.RegisterDate == registerDate && !x.IsDeleted).ToListAsync();
        }

        public async Task<CostumerEntity> GetById(string id)
        {
            return await _context.Costumers.Where(x => x.Id == id && !x.IsDeleted).FirstOrDefaultAsync();
        }

        public async Task Update(CostumerEntity entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
