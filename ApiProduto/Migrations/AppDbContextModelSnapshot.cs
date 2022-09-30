﻿// <auto-generated />
using System;
using ApiProduto.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiProduto.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ApiProduto.Models.OrganizacaoProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Organizacaos");
                });

            modelBuilder.Entity("ApiProduto.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Disc")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("IdStatus")
                        .HasColumnType("integer");

                    b.Property<int?>("OrganizacaoProdutoId")
                        .HasColumnType("integer");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("preco")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IdStatus");

                    b.HasIndex("OrganizacaoProdutoId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("ApiProduto.Models.StatusProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("ApiProduto.Models.Produto", b =>
                {
                    b.HasOne("ApiProduto.Models.StatusProduto", "Status")
                        .WithMany("Produtos")
                        .HasForeignKey("IdStatus")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiProduto.Models.OrganizacaoProduto", null)
                        .WithMany("Produtos")
                        .HasForeignKey("OrganizacaoProdutoId");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("ApiProduto.Models.OrganizacaoProduto", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("ApiProduto.Models.StatusProduto", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
