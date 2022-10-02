using ApiProduto.Data.Dto.Organizacao;
using ApiProduto.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace ApiProduto.Controllers
{
    [ApiController]
    [Route("v1/[Controller]")]
    public class CategoriaController : ControllerBase
    {
        private CategoriaService _organizacaoService;

        public CategoriaController(CategoriaService organizacaoService)
        {
            _organizacaoService = organizacaoService;
        }

        [HttpPost]
        public IActionResult PostOrganizacao([FromBody] CreateCategoriaDto dto)
        {
            ReadCategoriaDto readDto = _organizacaoService.PostCategoria(dto);

            return CreatedAtAction(nameof(GetCategoriaById), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult GetOrganizcao()
        {
            List<ReadCategoriaDto> readDto = _organizacaoService.GetCategoria();
            if (readDto != null)
                return Ok(readDto);
            return BadRequest();
        }

        [HttpGet("{id}")]
        public IActionResult GetCategoriaById(int id)
        {
            ReadCategoriaDto readDto = _organizacaoService.GetCategoriaById(id);
            if (readDto != null)
                return Ok(readDto);
            return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult PutOrganizacao(int id, [FromBody] UpdateCategoriaDto dto)
        {
            Result result = _organizacaoService.PutCategoria(id, dto);
            if (result.IsFailed)
                return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrganizacao(int id)
        {
            Result result = _organizacaoService.DeleteCategoria(id);
            if (result.IsFailed)
                return NotFound();
            return NoContent();
        }
    }
}
