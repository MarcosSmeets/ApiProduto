using ApiProduto.Models;

namespace ApiProduto.Data.Dto.Organizacao
{
    public class ReadOrganizacaoDto
    {
        public int Id { get; set; }
        public string Categoria { get; set; }
        public Produto Produtos { get; set; }
    }
}
