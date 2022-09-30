using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiProduto.Migrations
{
    public partial class adicionandotabelastatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdStatus",
                table: "Produtos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrganizacaoProdutoId",
                table: "Produtos",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Organizacaos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Categoria = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizacaos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_IdStatus",
                table: "Produtos",
                column: "IdStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_OrganizacaoProdutoId",
                table: "Produtos",
                column: "OrganizacaoProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Organizacaos_OrganizacaoProdutoId",
                table: "Produtos",
                column: "OrganizacaoProdutoId",
                principalTable: "Organizacaos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Status_IdStatus",
                table: "Produtos",
                column: "IdStatus",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Organizacaos_OrganizacaoProdutoId",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Status_IdStatus",
                table: "Produtos");

            migrationBuilder.DropTable(
                name: "Organizacaos");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_IdStatus",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_OrganizacaoProdutoId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "IdStatus",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "OrganizacaoProdutoId",
                table: "Produtos");
        }
    }
}
