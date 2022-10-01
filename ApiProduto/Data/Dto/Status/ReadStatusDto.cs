using ApiProduto.Models;
using System.Text.Json.Serialization;

namespace ApiProduto.Data.Dto.Status
{
    public class ReadStatusDto
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
