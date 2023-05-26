using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LagusImoveisWebII.Migrations
{
    /// <inheritdoc />
    public partial class jdhdj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "endereco",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    rua = table.Column<string>(type: "varchar(30)", nullable: false),
                    numero = table.Column<int>(type: "integer", nullable: false),
                    cep = table.Column<int>(type: "integer", nullable: false),
                    bairro = table.Column<string>(type: "varchar(30)", nullable: false),
                    estado = table.Column<string>(type: "varchar(20)", nullable: false),
                    cidade = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_endereco", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "imagem",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    imagem = table.Column<byte[]>(type: "bytea", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imagem", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "propriedade",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "varchar(300)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_propriedade", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "propriedade_tipo_situacao",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    valor = table.Column<decimal>(type: "numeric(7,2)", precision: 7, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_propriedade_tipo_situacao", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tipo_imovel",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_imovel", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tipo_situacao",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_situacao", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "varchar(20)", nullable: false),
                    sobrenome = table.Column<string>(type: "varchar(30)", nullable: false),
                    email = table.Column<string>(type: "varchar(40)", nullable: false),
                    telefone = table.Column<int>(type: "integer", nullable: false),
                    senha = table.Column<string>(type: "varchar(8)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "endereco");

            migrationBuilder.DropTable(
                name: "imagem");

            migrationBuilder.DropTable(
                name: "propriedade");

            migrationBuilder.DropTable(
                name: "propriedade_tipo_situacao");

            migrationBuilder.DropTable(
                name: "tipo_imovel");

            migrationBuilder.DropTable(
                name: "tipo_situacao");

            migrationBuilder.DropTable(
                name: "usuario");
        }
    }
}
