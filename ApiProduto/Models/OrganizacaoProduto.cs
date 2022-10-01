using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApiProduto.Models
{
    public class OrganizacaoProduto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Categoria { get; set; }
        public virtual List<Produto> Produtos { get; set; }
    }
}
