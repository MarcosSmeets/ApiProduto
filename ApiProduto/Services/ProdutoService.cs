using ApiProduto.Data;
using ApiProduto.Data.Dto;
using ApiProduto.Models;
using AutoMapper;
using FluentResults;

namespace ApiProduto.Services
{
    public class ProdutoService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public ProdutoService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadProdutoDto PostProduto(CreateProdutoDto dto)
        {
            Produto produto = _mapper.Map<Produto>(dto);
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return _mapper.Map<ReadProdutoDto>(produto);
        }

        public ReadProdutoDto GetProdutoById(int id)
        {
            Produto produto = _context.Produtos.FirstOrDefault(produto => produto.Id == id);
            if (produto != null)
            {
                ReadProdutoDto produtoDto = _mapper.Map<ReadProdutoDto>(produto);
                return produtoDto;
            }
            return null;
        }

        public List<ReadProdutoDto> GetProduto()
        {
            List<Produto> produto;
            produto = _context.Produtos.ToList();
            if (produto != null)
            {
                List<ReadProdutoDto> readDto = _mapper.Map<List<ReadProdutoDto>>(produto);
                return readDto;
            }
            return null;
        }

        public Result PutProduto(int id, UpdateProdutoDto dto)
        {
            Produto produto = _context.Produtos.FirstOrDefault(produto => produto.Id == id);
            if (produto == null)
                return Result.Fail("Not Found");

            _mapper.Map(dto, produto);
            _context.SaveChanges();
            return Result.Ok();
        }

        public Result DeleteProduto(int id)
        {
            Produto produto = _context.Produtos.FirstOrDefault(produto => produto.Id == id);
            if (produto == null)
                return Result.Fail("Not Found");

            _context.Produtos.Remove(produto);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
