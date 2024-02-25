using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products.Infra.Persistence.Repositories.Interfaces;
using Proyects.App.Dtos;
using Proyects.App.Exceptions;
using Proyects.App.Interfaces;
using Proyects.App.Services.Projections;

namespace Proyects.App.Services
{
    public class ProductsServices : IProductsService
    {
        private readonly IProductsRepository _repository;

        public ProductsServices(IProductsRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResposeProductDto> Add(CreateProductDto createDto)
        {
            var newProduct = CreateProduct.DtoToEntity(createDto);
            newProduct.CreatedDate = DateTimeOffset.Now;
            await _repository.Add(newProduct);

            return ResponseProduct.EntityToProduct(newProduct);
        }

        public async Task<ResposeProductDto> Delete(string id)
        {
            var product = await _repository.GetById(id);
            if (product is null) throw new ProductNotFound();

            product.DeleteDate = DateTimeOffset.Now;
            product.IsDeleted = true;
            await _repository.Update(product);

            return ResponseProduct.EntityToProduct(product);
        }

        public async Task<List<ResposeProductDto>> GetAll()
        {
            var products = await _repository.GetAll();

            return products.Select(e => ResponseProduct.EntityToProduct(e)).ToList();
        }

        public async Task<List<ResposeProductDto>> GetAllByCategory(string category)
        {
            var products = await _repository.GetAllByCategory(category);

            return products.Select(e => ResponseProduct.EntityToProduct(e)).ToList();
        }

        public async Task<ResposeProductDto> GetById(string id)
        {
            var product = await _repository.GetById(id);
            if (product is null) throw new ProductNotFound();

            return ResponseProduct.EntityToProduct(product);
        }

        public async Task<ResposeProductDto> GetByName(string name)
        {
            var product = await _repository.GetByName(name);
            if (product is null) throw new ProductNotFound();

            return ResponseProduct.EntityToProduct(product);
        }

        public async Task<ResposeProductDto> Update(UpdateProductDto updateDto)
        {
            var product = await _repository.GetById(updateDto.Id);
            if (product is null) throw new ProductNotFound();
            product.UpdatedDate = DateTimeOffset.Now;
            await _repository.Update(product);

            return ResponseProduct.EntityToProduct(product);
        }
    }
}
