using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreTest.Migrations
{
    public partial class LegsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Legs",
                table: "Lizards",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Legs",
                table: "Lizards");
        }
    }
}
