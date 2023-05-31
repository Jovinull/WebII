using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LagusImoveisWebII.Migrations
{
    /// <inheritdoc />
    public partial class T : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "propriedade",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "varchar(300)", nullable: false),
                    id_usuario = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_propriedade", x => x.id);
                    table.ForeignKey(
                        name: "FK_propriedade_usuario_id_usuario",
                        column: x => x.id_usuario,
                        principalTable: "usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    cidade = table.Column<string>(type: "varchar(20)", nullable: false),
                    id_propriedade = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_endereco", x => x.id);
                    table.ForeignKey(
                        name: "FK_endereco_propriedade_id_propriedade",
                        column: x => x.id_propriedade,
                        principalTable: "propriedade",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "imagem",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    imagem = table.Column<byte[]>(type: "bytea", nullable: false),
                    id_Propriedade = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imagem", x => x.id);
                    table.ForeignKey(
                        name: "FK_imagem_propriedade_id_Propriedade",
                        column: x => x.id_Propriedade,
                        principalTable: "propriedade",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "propriedade_tipo_situacao",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    valor = table.Column<decimal>(type: "numeric(7,2)", precision: 7, scale: 2, nullable: false),
                    id_propriedade = table.Column<int>(type: "integer", nullable: false),
                    id_Tipo_situacao = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_propriedade_tipo_situacao", x => x.id);
                    table.ForeignKey(
                        name: "FK_propriedade_tipo_situacao_propriedade_id_propriedade",
                        column: x => x.id_propriedade,
                        principalTable: "propriedade",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_propriedade_tipo_situacao_tipo_situacao_id_Tipo_situacao",
                        column: x => x.id_Tipo_situacao,
                        principalTable: "tipo_situacao",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tipo_imovel",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "varchar(20)", nullable: false),
                    id_propriedade = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_imovel", x => x.id);
                    table.ForeignKey(
                        name: "FK_tipo_imovel_propriedade_id_propriedade",
                        column: x => x.id_propriedade,
                        principalTable: "propriedade",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_endereco_id_propriedade",
                table: "endereco",
                column: "id_propriedade",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_imagem_id_Propriedade",
                table: "imagem",
                column: "id_Propriedade");

            migrationBuilder.CreateIndex(
                name: "IX_propriedade_id_usuario",
                table: "propriedade",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_propriedade_tipo_situacao_id_propriedade",
                table: "propriedade_tipo_situacao",
                column: "id_propriedade");

            migrationBuilder.CreateIndex(
                name: "IX_propriedade_tipo_situacao_id_Tipo_situacao",
                table: "propriedade_tipo_situacao",
                column: "id_Tipo_situacao");

            migrationBuilder.CreateIndex(
                name: "IX_tipo_imovel_id_propriedade",
                table: "tipo_imovel",
                column: "id_propriedade",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "endereco");

            migrationBuilder.DropTable(
                name: "imagem");

            migrationBuilder.DropTable(
                name: "propriedade_tipo_situacao");

            migrationBuilder.DropTable(
                name: "tipo_imovel");

            migrationBuilder.DropTable(
                name: "tipo_situacao");

            migrationBuilder.DropTable(
                name: "propriedade");

            migrationBuilder.DropTable(
                name: "usuario");
        }
    }
}
