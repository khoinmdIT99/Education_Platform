using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationPlatform.Migrations.ApplicationDb
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FactorCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FactorCodeEnabled",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FactorCode",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FactorCodeEnabled",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);
        }
    }
}
