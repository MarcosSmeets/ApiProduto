using ApiProduto.Models;

namespace ApiProduto.Data.Dto.Status
{
    public class ReadStatusDto
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public Produto Produtos { get; set; }
    }
}
