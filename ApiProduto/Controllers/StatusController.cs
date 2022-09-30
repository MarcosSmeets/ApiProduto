using ApiProduto.Data.Dto.Status;
using ApiProduto.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace ApiProduto.Controllers
{
    [ApiController]
    [Route("V1/[controller]")]
    public class StatusController : ControllerBase
    {
        private StatusService _statusService;

        public StatusController(StatusService statusService)
        {
            _statusService = statusService;
        }

        [HttpPost]
        public IActionResult PostStatus([FromBody] CreateStatusDto dto)
        {
            ReadStatusDto readDto = _statusService.PostProduto(dto);

            return CreatedAtAction(nameof(GetStatusById), new { Id = readDto.Id }, readDto);
        }

        [HttpGet("{id}")]
        public IActionResult GetStatusById(int id)
        {
            ReadStatusDto readDto = _statusService.GetProdutoById(id);
            if (readDto != null)
                return Ok(readDto);
            return BadRequest();
        }

        [HttpGet]
        public IActionResult GetStatus()
        {
            List<ReadStatusDto> readDto = _statusService.GetProduto();
            if (readDto != null)
                return Ok(readDto);
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStatus(int id)
        {

            Result result = _statusService.DeleteProduto(id);
            if (result.IsFailed)
                return NotFound();
            return NoContent();
        }
    }
}
