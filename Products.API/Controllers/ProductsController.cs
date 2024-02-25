using System.Globalization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyects.App.Dtos;
using Proyects.App.Interfaces;

namespace Products.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService _service;

        public ProductsController(IProductsService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateProductDto createDto)
        {
            try
            {
                var product = await _service.Add(createDto);

                return StatusCode(202, product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var products = await _service.GetAll();

                return Ok(products);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetById(string id)
        {
            try
            {
                var product = await _service.GetById(id);

                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("name")]
        public async Task<IActionResult> GetByName(string name)
        {
            try
            {
                var product = await _service.GetByName(name);

                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("category")]
        public async Task<IActionResult> GetByCategory(string category)
        {
            try
            {
                var product = await _service.GetAllByCategory(category);

                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("id")]
        public async Task<IActionResult> Update([FromBody] UpdateProductDto updateDto)
        {
            try
            {
                var product = await _service.Update(updateDto);

                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("id")]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                var product = await _service.Delete(id);

                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
