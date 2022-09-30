using ApiProduto.Data.Dto.Organizacao;
using ApiProduto.Models;
using AutoMapper;

namespace ApiProduto.Profiles
{
    public class OrganizacaoProfile : Profile
    {
        public OrganizacaoProfile()
        {
            CreateMap<CreateOrganizacaoDto, OrganizacaoProduto>();
            CreateMap<OrganizacaoProduto, ReadOrganizacaoDto>();
        }
    }
}
