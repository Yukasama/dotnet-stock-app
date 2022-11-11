using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obliviate.Migrations
{
    public partial class StockPeersRevert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ESGScore",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "environmentalScore",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "governanceScore",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "peersList",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "socialScore",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "url",
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
                name: "environmentalScore",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "governanceScore",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "peersList",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "socialScore",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "url",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
