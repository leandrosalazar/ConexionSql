using Microsoft.EntityFrameworkCore.Migrations;

namespace Conexionsql34.Migrations
{
    public partial class prueba_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SegundoNombre",
                table: "Cliente",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SegundoNombre",
                table: "Cliente");
        }
    }
}
