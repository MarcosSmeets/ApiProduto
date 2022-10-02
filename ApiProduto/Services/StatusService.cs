using ApiProduto.Data;
using ApiProduto.Data.Dto.Status;
using ApiProduto.Models;
using AutoMapper;
using FluentResults;

namespace ApiProduto.Services
{
    public class StatusService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public StatusService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadStatusDto PostProduto(CreateStatusDto dto)
        {
            StatusProduto status = _mapper.Map<StatusProduto>(dto);
            _context.Status.Add(status);
            _context.SaveChanges();
            return _mapper.Map<ReadStatusDto>(status);
        }

        public ReadStatusDto GetProdutoById(int id)
        {
            StatusProduto status = _context.Status.FirstOrDefault(status => status.Id == id);
            if (status != null)
            {
                ReadStatusDto statusDto = _mapper.Map<ReadStatusDto>(status);
                return statusDto;
            }
            return null;
        }

        public List<ReadStatusDto> GetProduto()
        {
            List<StatusProduto> status;
            status = _context.Status.ToList();
            if (status != null)
            {
                List<ReadStatusDto> readDto = _mapper.Map<List<ReadStatusDto>>(status);
                return readDto;
            }
            return null;
        }

        public Result PutStatus(int id, UpdateStatusDto dto)
        {
            StatusProduto status = _context.Status.FirstOrDefault(status => status.Id == id);
            if (status == null)
                return Result.Fail("Not Found");

            _mapper.Map(dto, status);
            _context.SaveChanges();
            return Result.Ok();
        }

        public Result DeleteProduto(int id)
        {
            StatusProduto status = _context.Status.FirstOrDefault(status => status.Id == id);
            if (status == null)
                return Result.Fail("Not Found");

            _context.Status.Remove(status);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
