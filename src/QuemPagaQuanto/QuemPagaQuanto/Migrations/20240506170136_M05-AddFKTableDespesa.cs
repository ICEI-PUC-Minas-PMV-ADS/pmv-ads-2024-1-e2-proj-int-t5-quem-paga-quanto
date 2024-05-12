using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuemPagaQuanto.Migrations
{
    public partial class M05AddFKTableDespesa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GrupoId",
                table: "Despesas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Despesas_GrupoId",
                table: "Despesas",
                column: "GrupoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Despesas_Grupos_GrupoId",
                table: "Despesas",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Despesas_Grupos_GrupoId",
                table: "Despesas");

            migrationBuilder.DropIndex(
                name: "IX_Despesas_GrupoId",
                table: "Despesas");

            migrationBuilder.DropColumn(
                name: "GrupoId",
                table: "Despesas");
        }
    }
}
