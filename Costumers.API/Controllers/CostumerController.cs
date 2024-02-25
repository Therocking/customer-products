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
    }
}
