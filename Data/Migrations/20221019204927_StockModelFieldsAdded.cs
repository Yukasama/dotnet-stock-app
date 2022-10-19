using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obliviate.Migrations
{
    public partial class StockModelFieldsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Beta",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ceo",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Changes",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cusip",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dcf",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DcfDiff",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DefaultImage",
                table: "Stock",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Exchange",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExchangeShortName",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullTimeEmployees",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Industry",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IpoDate",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActivelyTrading",
                table: "Stock",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAdr",
                table: "Stock",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEtf",
                table: "Stock",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsFund",
                table: "Stock",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Isin",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastDiv",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MktCap",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Range",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RatingDetailsDCFRecommendation",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RatingDetailsDCFScore",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RatingDetailsDERecommendation",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RatingDetailsDEScore",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RatingDetailsPBRecommendation",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RatingDetailsPBScore",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RatingDetailsPERecommendation",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RatingDetailsPEScore",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RatingDetailsROARecommendation",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RatingDetailsROAScore",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RatingDetailsROERecommendation",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RatingDetailsROEScore",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RatingRecommendation",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RatingScore",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sector",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StockPrice",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VolAvg",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Zip",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Beta",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Ceo",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Changes",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Cusip",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Dcf",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "DcfDiff",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "DefaultImage",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Exchange",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "ExchangeShortName",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "FullTimeEmployees",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Industry",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "IpoDate",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "IsActivelyTrading",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "IsAdr",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "IsEtf",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "IsFund",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Isin",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "LastDiv",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "MktCap",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Range",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "RatingDetailsDCFRecommendation",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "RatingDetailsDCFScore",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "RatingDetailsDERecommendation",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "RatingDetailsDEScore",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "RatingDetailsPBRecommendation",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "RatingDetailsPBScore",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "RatingDetailsPERecommendation",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "RatingDetailsPEScore",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "RatingDetailsROARecommendation",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "RatingDetailsROAScore",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "RatingDetailsROERecommendation",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "RatingDetailsROEScore",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "RatingRecommendation",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "RatingScore",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Sector",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "StockPrice",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "VolAvg",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "Stock");
        }
    }
}
