using ApiProduto.Data.Dto;
using ApiProduto.Models;
using AutoMapper;

namespace ApiProduto.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<CreateProdutoDto, Produto>();
            CreateMap<UpdateProdutoDto, Produto>().ReverseMap();
            CreateMap<Produto, ReadProdutoDto>();
        }
    }
}
