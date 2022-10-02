using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApiProduto.Models
{
    public class Produto
    {
        [Key]
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
        [JsonIgnore]
        public virtual StatusProduto Status { get; set; }
        [JsonIgnore]
        public int IdStatus { get; set; }
        [JsonIgnore]
        public virtual CategoriaProduto Organizacao { get; set; }
        [JsonIgnore]
        public int IdOrganizacao { get; set; }
    }
}
