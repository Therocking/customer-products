using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyects.App.Dtos;

namespace Proyects.App.Interfaces
{
    public interface IProductsService
    {
        Task<ResposeProductDto> Add(CreateProductDto createDto);
        Task<List<ResposeProductDto>> GetAll();
        Task<ResposeProductDto> GetById(string id);
        Task<ResposeProductDto> GetByName(string name);
        Task<List<ResposeProductDto>> GetAllByCategory(string category);
        Task<ResposeProductDto> Update(UpdateProductDto updateDto);
        Task<ResposeProductDto> Delete(string id);
    }
}
