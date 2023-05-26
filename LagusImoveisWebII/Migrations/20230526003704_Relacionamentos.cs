using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LagusImoveisWebII.Migrations
{
    /// <inheritdoc />
    public partial class Relacionamentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id_propriedade",
                table: "tipo_imovel",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_Tipo_situacao",
                table: "propriedade_tipo_situacao",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_propriedade",
                table: "propriedade_tipo_situacao",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_usuario",
                table: "propriedade",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_propriedade",
                table: "endereco",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tipo_imovel_id_propriedade",
                table: "tipo_imovel",
                column: "id_propriedade",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_propriedade_tipo_situacao_id_propriedade",
                table: "propriedade_tipo_situacao",
                column: "id_propriedade",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_propriedade_tipo_situacao_id_Tipo_situacao",
                table: "propriedade_tipo_situacao",
                column: "id_Tipo_situacao",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_propriedade_id_usuario",
                table: "propriedade",
                column: "id_usuario",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_endereco_id_propriedade",
                table: "endereco",
                column: "id_propriedade",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_endereco_propriedade_id_propriedade",
                table: "endereco",
                column: "id_propriedade",
                principalTable: "propriedade",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_propriedade_usuario_id_usuario",
                table: "propriedade",
                column: "id_usuario",
                principalTable: "usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_propriedade_tipo_situacao_propriedade_id_propriedade",
                table: "propriedade_tipo_situacao",
                column: "id_propriedade",
                principalTable: "propriedade",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_propriedade_tipo_situacao_tipo_situacao_id_Tipo_situacao",
                table: "propriedade_tipo_situacao",
                column: "id_Tipo_situacao",
                principalTable: "tipo_situacao",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tipo_imovel_propriedade_id_propriedade",
                table: "tipo_imovel",
                column: "id_propriedade",
                principalTable: "propriedade",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_endereco_propriedade_id_propriedade",
                table: "endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_propriedade_usuario_id_usuario",
                table: "propriedade");

            migrationBuilder.DropForeignKey(
                name: "FK_propriedade_tipo_situacao_propriedade_id_propriedade",
                table: "propriedade_tipo_situacao");

            migrationBuilder.DropForeignKey(
                name: "FK_propriedade_tipo_situacao_tipo_situacao_id_Tipo_situacao",
                table: "propriedade_tipo_situacao");

            migrationBuilder.DropForeignKey(
                name: "FK_tipo_imovel_propriedade_id_propriedade",
                table: "tipo_imovel");

            migrationBuilder.DropIndex(
                name: "IX_tipo_imovel_id_propriedade",
                table: "tipo_imovel");

            migrationBuilder.DropIndex(
                name: "IX_propriedade_tipo_situacao_id_propriedade",
                table: "propriedade_tipo_situacao");

            migrationBuilder.DropIndex(
                name: "IX_propriedade_tipo_situacao_id_Tipo_situacao",
                table: "propriedade_tipo_situacao");

            migrationBuilder.DropIndex(
                name: "IX_propriedade_id_usuario",
                table: "propriedade");

            migrationBuilder.DropIndex(
                name: "IX_endereco_id_propriedade",
                table: "endereco");

            migrationBuilder.DropColumn(
                name: "id_propriedade",
                table: "tipo_imovel");

            migrationBuilder.DropColumn(
                name: "id_Tipo_situacao",
                table: "propriedade_tipo_situacao");

            migrationBuilder.DropColumn(
                name: "id_propriedade",
                table: "propriedade_tipo_situacao");

            migrationBuilder.DropColumn(
                name: "id_usuario",
                table: "propriedade");

            migrationBuilder.DropColumn(
                name: "id_propriedade",
                table: "endereco");
        }
    }
}
