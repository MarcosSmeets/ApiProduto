using System.ComponentModel.DataAnnotations;

namespace ApiProduto.Data.Dto
{
    public class UpdateProdutoDto
    {
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Disc { get; set; }
        [Required]
        public int precoreco { get; set; }
        [Required]
        public string img { get; set; }
    }
}
