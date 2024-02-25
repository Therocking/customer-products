using Custumers.Application.Dtos;
using Custumers.Application.Intefaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Costumers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CostumerController : ControllerBase
    {
        private readonly ICostumerService _service;

        public CostumerController(ICostumerService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCostumerDto createDto)
        {
            try
            {
                var user = await _service.Add(createDto);

                return StatusCode(202, user);
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
                var costumers = await _service.GetAll();
                return Ok(costumers);
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
                var costumer = await _service.GetById(id);
                return Ok(costumer);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("registerDate")]
        public async Task<IActionResult> GetByRegisterDate(DateTimeOffset registerDate)
        {
            try
            {
                var costumer = await _service.GetAllByRegisterDate(registerDate);
                return Ok(costumer);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("id")]
        public async Task<IActionResult> Update([FromBody] UpdateCostumerDto updateDto)
        {
            try
            {
                var costumer = await _service.Update(updateDto);
                return Ok(costumer);
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
                var costumer = await _service.Delete(id);
                return Ok(costumer);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
