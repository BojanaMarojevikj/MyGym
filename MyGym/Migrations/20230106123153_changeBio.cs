using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGym.Migrations
{
    public partial class changeBio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Bio",
                table: "Equipments",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Equipments",
                newName: "Bio");
        }
    }
}
