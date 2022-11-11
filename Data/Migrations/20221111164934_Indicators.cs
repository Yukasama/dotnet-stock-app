using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obliviate.Migrations
{
    public partial class Indicators : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EMA",
                table: "Stock",
                newName: "WPR");

            migrationBuilder.AddColumn<string>(
                name: "RSI",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SMA100",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SMA20",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SMA200",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SMA50",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RSI",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "SMA100",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "SMA20",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "SMA200",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "SMA50",
                table: "Stock");

            migrationBuilder.RenameColumn(
                name: "WPR",
                table: "Stock",
                newName: "EMA");
        }
    }
}
