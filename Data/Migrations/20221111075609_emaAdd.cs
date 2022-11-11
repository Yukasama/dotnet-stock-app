using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obliviate.Migrations
{
    public partial class emaAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EMA",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EMA",
                table: "Stock");
        }
    }
}
