using Microsoft.EntityFrameworkCore.Migrations;

namespace EveVoid.Migrations
{
    public partial class SystemTypeColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "SystemTypes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "SystemTypes");
        }
    }
}
