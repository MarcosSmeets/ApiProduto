using ApiProduto.Data;
using ApiProduto.Data.Dto.Organizacao;
using ApiProduto.Models;
using AutoMapper;
using FluentResults;

namespace ApiProduto.Services
{
    public class OrganizacaoService
    {
        private AppDbContext _context;
        private IMapper _mapper;
        public OrganizacaoService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadOrganizacaoDto PostOrganizacao(CreateOrganizacaoDto dto)
        {
            OrganizacaoProduto organizacao = _mapper.Map<OrganizacaoProduto>(dto);
            _context.Organizacaos.Add(organizacao);
            _context.SaveChanges();
            return _mapper.Map<ReadOrganizacaoDto>(organizacao);
        }

        public ReadOrganizacaoDto GetOrganizcaoById(int id)
        {
            OrganizacaoProduto organizacao = _context.Organizacaos.FirstOrDefault(organizacao => organizacao.Id == id);
            if (organizacao != null)
            {
                ReadOrganizacaoDto produtoDto = _mapper.Map<ReadOrganizacaoDto>(organizacao);
                return produtoDto;
            }
            return null;
        }

        public List<ReadOrganizacaoDto> GetProduto()
        {
            List<OrganizacaoProduto> organizacaos;
            organizacaos = _context.Organizacaos.ToList();
            if (organizacaos != null)
            {
                List<ReadOrganizacaoDto> readDto = _mapper.Map<List<ReadOrganizacaoDto>>(organizacaos);
                return readDto;
            }
            return null;
        }

        public Result DeleteOrganizacao(int id)
        {
            OrganizacaoProduto organizacao = _context.Organizacaos.FirstOrDefault(organizacao => organizacao.Id == id);
            if (organizacao == null)
                return Result.Fail("Not Found");

            _context.Organizacaos.Remove(organizacao);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
