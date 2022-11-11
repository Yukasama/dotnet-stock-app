using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obliviate.Migrations
{
    public partial class apiUpgradeRevert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstimatedEbitAvg",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EstimatedEbitHigh",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EstimatedEbitLow",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EstimatedEbitdaAvg",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EstimatedEbitdaHigh",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EstimatedEbitdaLow",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EstimatedEpsAvg",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EstimatedEpsHigh",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EstimatedEpsLow",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EstimatedNetIncomeAvg",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EstimatedNetIncomeHigh",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EstimatedNetIncomeLow",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EstimatedRevenueAvg",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EstimatedRevenueHigh",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EstimatedRevenueLow",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EstimatedSgaExpenseAvg",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EstimatedSgaExpenseHigh",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EstimatedSgaExpenseLow",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "NumberAnalystEstimatedRevenue",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "NumberAnalystsEstimatedEps",
                table: "Stock");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EstimatedEbitAvg",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstimatedEbitHigh",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstimatedEbitLow",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstimatedEbitdaAvg",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstimatedEbitdaHigh",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstimatedEbitdaLow",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstimatedEpsAvg",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstimatedEpsHigh",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstimatedEpsLow",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstimatedNetIncomeAvg",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstimatedNetIncomeHigh",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstimatedNetIncomeLow",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstimatedRevenueAvg",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstimatedRevenueHigh",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstimatedRevenueLow",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstimatedSgaExpenseAvg",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstimatedSgaExpenseHigh",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstimatedSgaExpenseLow",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumberAnalystEstimatedRevenue",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumberAnalystsEstimatedEps",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
