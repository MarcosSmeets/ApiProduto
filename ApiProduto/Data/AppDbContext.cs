using ApiProduto.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProduto.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Produto>()
                .HasOne(produto => produto.Status)
                .WithMany(status => status.Produtos)
                .HasForeignKey(produto => produto.IdStatus);

            builder.Entity<Produto>()
                .HasOne(produto => produto.Organizacao)
                .WithMany(organizacao => organizacao.Produtos)
                .HasForeignKey(produto => produto.IdOrganizacao);
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<OrganizacaoProduto> Organizacaos { get; set; }
        public DbSet<StatusProduto> Status { get; set; }
    }
}
