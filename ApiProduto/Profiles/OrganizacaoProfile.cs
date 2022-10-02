using ApiProduto.Data.Dto.Organizacao;
using ApiProduto.Models;
using AutoMapper;

namespace ApiProduto.Profiles
{
    public class OrganizacaoProfile : Profile
    {
        public OrganizacaoProfile()
        {
            CreateMap<CreateCategoriaDto, CategoriaProduto>();
            CreateMap<CategoriaProduto, ReadCategoriaDto>();
            CreateMap<UpdateCategoriaDto, CategoriaProduto>();
        }
    }
}
