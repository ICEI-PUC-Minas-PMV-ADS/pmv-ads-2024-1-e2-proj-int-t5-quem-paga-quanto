using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuemPagaQuanto.Migrations
{
    public partial class Atualizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: -1,
                column: "Senha",
                value: "$2a$11$.kmPcQbhN1.Jg0Zi4OOAe.zJxB6p8vW7Rg4fQ6Uifeal2ztBnRaFq");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: -1,
                column: "Senha",
                value: "$2a$11$o1kvW9VtkL/KpMUwfkcBVu8udhUqfMwpVb9DZEawctoEkJCP5D7MG");
        }
    }
}
