using ApiProduto.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProduto.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasOne(p => p.Organizacao)
                .WithMany(o => o.Produtos)
                .HasForeignKey(p => p.IdOrganizacao);
            modelBuilder.Entity<Produto>()
                .HasOne(p => p.Status)
                .WithMany(s => s.Produtos)
                .HasForeignKey(p => p.IdStatus);
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<CategoriaProduto> Categorias { get; set; }
        public DbSet<StatusProduto> Status { get; set; }
    }
}
