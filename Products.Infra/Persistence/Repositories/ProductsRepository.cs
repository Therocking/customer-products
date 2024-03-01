using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Products.Infra.Persistence.Context;
using Products.Infra.Persistence.Repositories.Interfaces;
using Proyects.Domain.Entities;

namespace Products.Infra.Persistence.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private ProductsContext _dbContext;

        public ProductsRepository(ProductsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(ProductsEntity entity)
        {
            _dbContext.Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<ProductsEntity>> GetAll()
        {
            return await _dbContext.Product.Where(x => !x.IsDeleted).ToListAsync();
        }

        public async Task<ProductsEntity> GetById(string id)
        {
            return await _dbContext.Product.Where(x => x.Id == id && !x.IsDeleted).FirstOrDefaultAsync();
        }

        public async Task<ProductsEntity> GetByName(string name)
        {
            return await _dbContext.Product.Where(x => x.Name == name && !x.IsDeleted).FirstOrDefaultAsync();
        }

        public async Task<List<ProductsEntity>> GetAllByCategory(string category)
        {
            return await _dbContext.Product.Where(x => x.Category == category && !x.IsDeleted).ToListAsync();
        }

        public async Task Update(ProductsEntity entity)
        {
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
