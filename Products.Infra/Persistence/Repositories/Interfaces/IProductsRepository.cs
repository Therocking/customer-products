using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyects.Domain.Entities;

namespace Products.Infra.Persistence.Repositories.Interfaces
{
    public interface IProductsRepository
    {
        Task Add(ProductsEntity entity);
        Task<List<ProductsEntity>> GetAll();
        Task<ProductsEntity> GetById(string id);
        Task<ProductsEntity> GetByName(string name);
        Task<List<ProductsEntity>> GetAllByCategory(string category);
        Task Update(ProductsEntity entity);
    }
}
