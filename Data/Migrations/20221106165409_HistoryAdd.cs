using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obliviate.Migrations
{
    public partial class HistoryAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Change",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChangeOverTime",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChangePercent",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Close",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "High",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HistoryDate",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Label",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Low",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Open",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Volume",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vwap",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Change",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "ChangeOverTime",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "ChangePercent",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Close",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "High",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "HistoryDate",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Label",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Low",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Open",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Volume",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Vwap",
                table: "Stock");
        }
    }
}
