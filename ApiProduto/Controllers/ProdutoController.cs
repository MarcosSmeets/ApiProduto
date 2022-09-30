using ApiProduto.Data;
using ApiProduto.Data.Dto;
using ApiProduto.Models;
using ApiProduto.Services;
using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace ApiProduto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private ProdutoService _produtoService;

        public ProdutoController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpPost]
        public IActionResult PostProduto([FromBody] CreateProdutoDto dto)
        {
            ReadProdutoDto readDto = _produtoService.PostProduto(dto);

            return CreatedAtAction(nameof(GetProdutoById), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult GetProduto()
        {
            List<ReadProdutoDto> readDto = _produtoService.GetProduto();
            if (readDto != null)
                return Ok(readDto);
            return BadRequest();
        }

        [HttpGet("{id}")]
        public IActionResult GetProdutoById(int id)
        {
            ReadProdutoDto readDto = _produtoService.GetProdutoById(id);
            if (readDto != null)
                return Ok(readDto);
            return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult PutProduto(int id, [FromBody] UpdateProdutoDto dto)
        {
            Result result = _produtoService.PutProduto(id, dto);
            if (result.IsFailed)
                return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduto(int id)
        {
            Result result = _produtoService.DeleteProduto(id);
            if (result.IsFailed)
                return NotFound();
            return NoContent();
        }
    }
}
