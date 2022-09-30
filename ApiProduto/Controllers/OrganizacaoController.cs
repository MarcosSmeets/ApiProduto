using ApiProduto.Data.Dto.Organizacao;
using ApiProduto.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace ApiProduto.Controllers
{
    [ApiController]
    [Route("V1/[Controller]")]
    public class OrganizacaoController : ControllerBase
    {
        private OrganizacaoService _organizacaoService;

        public OrganizacaoController(OrganizacaoService organizacaoService)
        {
            _organizacaoService = organizacaoService;
        }

        [HttpPost]
        public IActionResult PostOrganizacao([FromBody] CreateOrganizacaoDto dto)
        {
            ReadOrganizacaoDto readDto = _organizacaoService.PostOrganizacao(dto);

            return CreatedAtAction(nameof(GetProdutoById), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult GetOrganizcao()
        {
            List<ReadOrganizacaoDto> readDto = _organizacaoService.GetProduto();
            if (readDto != null)
                return Ok(readDto);
            return BadRequest();
        }

        [HttpGet("{id}")]
        public IActionResult GetProdutoById(int id)
        {
            ReadOrganizacaoDto readDto = _organizacaoService.GetOrganizcaoById(id);
            if (readDto != null)
                return Ok(readDto);
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrganizacao(int id)
        {
            Result result = _organizacaoService.DeleteOrganizacao(id);
            if (result.IsFailed)
                return NotFound();
            return NoContent();
        }
    }
}
