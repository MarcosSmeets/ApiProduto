using System.ComponentModel.DataAnnotations;

namespace ApiProduto.Data.Dto
{
    public class CreateProdutoDto
    {
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Disc { get; set; }
        [Required]
        public int preco { get; set; }
        [Required]
        public string img { get; set; }
        public int StatusId { get; set; }
        public int OrganizacaoId { get; set; }
    }
}
