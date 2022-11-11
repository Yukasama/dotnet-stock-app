using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obliviate.Migrations
{
    public partial class apiUpgrade2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ESGScore",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EnvironmentalScore",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "FormType",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "GovernanceScore",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "SocialScore",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Stock");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ESGScore",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnvironmentalScore",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormType",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GovernanceScore",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SocialScore",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
