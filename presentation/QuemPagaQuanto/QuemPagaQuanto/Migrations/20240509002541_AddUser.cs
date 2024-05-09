using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuemPagaQuanto.Migrations
{
    public partial class AddUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Email", "Nome", "Perfil", "Senha" },
                values: new object[] { -1, "admin@admin.com", "Administrador", 0, "$2a$11$o1kvW9VtkL/KpMUwfkcBVu8udhUqfMwpVb9DZEawctoEkJCP5D7MG" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
