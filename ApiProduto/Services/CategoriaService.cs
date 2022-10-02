using ApiProduto.Data;
using ApiProduto.Data.Dto.Organizacao;
using ApiProduto.Models;
using AutoMapper;
using FluentResults;

namespace ApiProduto.Services
{
    public class CategoriaService
    {
        private AppDbContext _context;
        private IMapper _mapper;
        public CategoriaService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadCategoriaDto PostCategoria(CreateCategoriaDto dto)
        {
            CategoriaProduto categoria = _mapper.Map<CategoriaProduto>(dto);
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
            return _mapper.Map<ReadCategoriaDto>(categoria);
        }

        public ReadCategoriaDto GetCategoriaById(int id)
        {
            CategoriaProduto categoria = _context.Categorias.FirstOrDefault(categoria => categoria.Id == id);
            if (categoria != null)
            {
                ReadCategoriaDto produtoDto = _mapper.Map<ReadCategoriaDto>(categoria);
                return produtoDto;
            }
            return null;
        }

        public List<ReadCategoriaDto> GetCategoria()
        {
            List<CategoriaProduto> categoria;
            categoria = _context.Categorias.ToList();
            if (categoria != null)
            {
                List<ReadCategoriaDto> readDto = _mapper.Map<List<ReadCategoriaDto>>(categoria);
                return readDto;
            }
            return null;
        }

        public Result PutCategoria(int id, UpdateCategoriaDto dto)
        {
            CategoriaProduto categoria = _context.Categorias.FirstOrDefault(categoria => categoria.Id == id);
            if (categoria == null)
                return Result.Fail("Not Found");

            _mapper.Map(dto, categoria);
            _context.SaveChanges();
            return Result.Ok();
        }

        public Result DeleteCategoria(int id)
        {
            CategoriaProduto categoria = _context.Categorias.FirstOrDefault(categoria => categoria.Id == id);
            if (categoria == null)
                return Result.Fail("Not Found");

            _context.Categorias.Remove(categoria);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
