﻿using ApiProduto.Models;
using System.Text.Json.Serialization;

namespace ApiProduto.Data.Dto.Organizacao
{
    public class ReadOrganizacaoDto
    {
        public int Id { get; set; }
        public string Categoria { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
