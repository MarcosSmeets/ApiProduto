﻿using System.ComponentModel.DataAnnotations;

namespace ApiProduto.Data.Dto
{
    public class UpdateProdutoDto
    {
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Disc { get; set; }
        [Required]
        public int preco { get; set; }
        [Required]
        public string img { get; set; }
    }
}
