using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApiProduto.Models
{
    public class StatusProduto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Status { get; set; }
        public virtual List<Produto> Produtos { get; set; }
    }
}
