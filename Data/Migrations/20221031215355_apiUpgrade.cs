using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obliviate.Migrations
{
    public partial class apiUpgrade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MinorityInterest",
                table: "Stock",
                newName: "stringerestIncome");

            migrationBuilder.RenameColumn(
                name: "LongTermInvestments",
                table: "Stock",
                newName: "stringerestExpense");

            migrationBuilder.RenameColumn(
                name: "LongTermDebtToCapitalization",
                table: "Stock",
                newName: "stringerestDebtPerShare");

            migrationBuilder.RenameColumn(
                name: "LongTermDebt",
                table: "Stock",
                newName: "stringerestCoverage");

            migrationBuilder.RenameColumn(
                name: "InterestIncome",
                table: "Stock",
                newName: "stringangiblesToTotalAssets");

            migrationBuilder.RenameColumn(
                name: "InterestExpense",
                table: "Stock",
                newName: "stringangibleAssets");

            migrationBuilder.RenameColumn(
                name: "InterestDebtPerShare",
                table: "Stock",
                newName: "stringTermInvestments");

            migrationBuilder.RenameColumn(
                name: "InterestCoverage",
                table: "Stock",
                newName: "stringTermDebtToCapitalization");

            migrationBuilder.RenameColumn(
                name: "IntangiblesToTotalAssets",
                table: "Stock",
                newName: "stringTermDebt");

            migrationBuilder.RenameColumn(
                name: "IntangibleAssets",
                table: "Stock",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "GoodwillAndIntangibleAssets",
                table: "Stock",
                newName: "SocialScore");

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
                name: "FormType",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GoodwillAndstringangibleAssets",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GovernanceScore",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Minoritystringerest",
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

            migrationBuilder.AddColumn<string>(
                name: "PeersList",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ESGScore",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EnvironmentalScore",
                table: "Stock");

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
                name: "FormType",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "GoodwillAndstringangibleAssets",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "GovernanceScore",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Minoritystringerest",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "NumberAnalystEstimatedRevenue",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "NumberAnalystsEstimatedEps",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "PeersList",
                table: "Stock");

            migrationBuilder.RenameColumn(
                name: "stringerestIncome",
                table: "Stock",
                newName: "MinorityInterest");

            migrationBuilder.RenameColumn(
                name: "stringerestExpense",
                table: "Stock",
                newName: "LongTermInvestments");

            migrationBuilder.RenameColumn(
                name: "stringerestDebtPerShare",
                table: "Stock",
                newName: "LongTermDebtToCapitalization");

            migrationBuilder.RenameColumn(
                name: "stringerestCoverage",
                table: "Stock",
                newName: "LongTermDebt");

            migrationBuilder.RenameColumn(
                name: "stringangiblesToTotalAssets",
                table: "Stock",
                newName: "InterestIncome");

            migrationBuilder.RenameColumn(
                name: "stringangibleAssets",
                table: "Stock",
                newName: "InterestExpense");

            migrationBuilder.RenameColumn(
                name: "stringTermInvestments",
                table: "Stock",
                newName: "InterestDebtPerShare");

            migrationBuilder.RenameColumn(
                name: "stringTermDebtToCapitalization",
                table: "Stock",
                newName: "InterestCoverage");

            migrationBuilder.RenameColumn(
                name: "stringTermDebt",
                table: "Stock",
                newName: "IntangiblesToTotalAssets");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Stock",
                newName: "IntangibleAssets");

            migrationBuilder.RenameColumn(
                name: "SocialScore",
                table: "Stock",
                newName: "GoodwillAndIntangibleAssets");
        }
    }
}
