using ApiProduto.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApiProduto.Data.Dto
{
    public class ReadProdutoDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Disc { get; set; }
        [Required]
        public int preco { get; set; }
        [Required]
        public string img { get; set; }
        public StatusProduto Status { get; set; }
        public CategoriaProduto Organizacao { get; set; }
    }
}
