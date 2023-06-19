using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LagusImoveisWebII.Migrations
{
    /// <inheritdoc />
    public partial class teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tipoImovel",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoImovel", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tipoSituacao",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricao = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoSituacao", x => x.id);
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
                    telefone = table.Column<string>(type: "varchar(11)", nullable: false),
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
                    idUsuario = table.Column<int>(type: "integer", nullable: false),
                    idTipoImovel = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_propriedade", x => x.id);
                    table.ForeignKey(
                        name: "FK_propriedade_tipoImovel_idTipoImovel",
                        column: x => x.idTipoImovel,
                        principalTable: "tipoImovel",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_propriedade_usuario_idUsuario",
                        column: x => x.idUsuario,
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
                    numero = table.Column<string>(type: "varchar(11)", nullable: false),
                    cep = table.Column<string>(type: "varchar(8)", nullable: false),
                    bairro = table.Column<string>(type: "varchar(30)", nullable: false),
                    estado = table.Column<string>(type: "varchar(20)", nullable: false),
                    cidade = table.Column<string>(type: "varchar(20)", nullable: false),
                    idPropriedade = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_endereco", x => x.id);
                    table.ForeignKey(
                        name: "FK_endereco_propriedade_idPropriedade",
                        column: x => x.idPropriedade,
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
                    idPropriedade = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imagem", x => x.id);
                    table.ForeignKey(
                        name: "FK_imagem_propriedade_idPropriedade",
                        column: x => x.idPropriedade,
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
                    idpropriedade = table.Column<int>(type: "integer", nullable: false),
                    idTipoSituacao = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_propriedade_tipo_situacao", x => x.id);
                    table.ForeignKey(
                        name: "FK_propriedade_tipo_situacao_propriedade_idpropriedade",
                        column: x => x.idpropriedade,
                        principalTable: "propriedade",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_propriedade_tipo_situacao_tipoSituacao_idTipoSituacao",
                        column: x => x.idTipoSituacao,
                        principalTable: "tipoSituacao",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_endereco_idPropriedade",
                table: "endereco",
                column: "idPropriedade",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_imagem_idPropriedade",
                table: "imagem",
                column: "idPropriedade");

            migrationBuilder.CreateIndex(
                name: "IX_propriedade_idTipoImovel",
                table: "propriedade",
                column: "idTipoImovel");

            migrationBuilder.CreateIndex(
                name: "IX_propriedade_idUsuario",
                table: "propriedade",
                column: "idUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_propriedade_tipo_situacao_idpropriedade",
                table: "propriedade_tipo_situacao",
                column: "idpropriedade");

            migrationBuilder.CreateIndex(
                name: "IX_propriedade_tipo_situacao_idTipoSituacao",
                table: "propriedade_tipo_situacao",
                column: "idTipoSituacao");
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
                name: "propriedade");

            migrationBuilder.DropTable(
                name: "tipoSituacao");

            migrationBuilder.DropTable(
                name: "tipoImovel");

            migrationBuilder.DropTable(
                name: "usuario");
        }
    }
}
