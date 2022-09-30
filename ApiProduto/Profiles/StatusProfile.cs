using ApiProduto.Data.Dto.Status;
using ApiProduto.Models;
using AutoMapper;

namespace ApiProduto.Profiles
{
    public class StatusProfile : Profile
    {
        public StatusProfile()
        {
            CreateMap<CreateStatusDto, StatusProduto>();
            CreateMap<StatusProduto, ReadStatusDto>();         
        }
    }
}
