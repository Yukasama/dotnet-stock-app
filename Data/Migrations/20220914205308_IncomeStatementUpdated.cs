using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obliviate.Data.Migrations
{
    public partial class IncomeStatementUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.CreateTable(
                name: "IncomeStatement",
                columns: table => new
                {
                    Symbol = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportedCurrency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FillingDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcceptedDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CalendarYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Period = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Revenue = table.Column<double>(type: "float", nullable: false),
                    CostOfRevenue = table.Column<double>(type: "float", nullable: false),
                    GrossProfit = table.Column<double>(type: "float", nullable: false),
                    GrossProfitRatio = table.Column<double>(type: "float", nullable: false),
                    ResearchAndDevelopmentExpenses = table.Column<double>(type: "float", nullable: false),
                    GeneralAndAdministrativeExpenses = table.Column<double>(type: "float", nullable: false),
                    SellingAndMarketingExpenses = table.Column<double>(type: "float", nullable: false),
                    SellingGeneralAndAdministrativeExpenses = table.Column<double>(type: "float", nullable: false),
                    OtherExpenses = table.Column<double>(type: "float", nullable: false),
                    OperatingExpenses = table.Column<double>(type: "float", nullable: false),
                    InterestIncome = table.Column<double>(type: "float", nullable: false),
                    InterestExpense = table.Column<double>(type: "float", nullable: false),
                    DepreciationAndAmortization = table.Column<double>(type: "float", nullable: false),
                    Ebitda = table.Column<double>(type: "float", nullable: false),
                    Ebitdaratio = table.Column<double>(type: "float", nullable: false),
                    OperatingIncome = table.Column<double>(type: "float", nullable: false),
                    OperatingIncomeRatio = table.Column<double>(type: "float", nullable: false),
                    TotalOtherIncomeExpensesNet = table.Column<double>(type: "float", nullable: false),
                    IncomeBeforeTax = table.Column<double>(type: "float", nullable: false),
                    IncomeBeforeTaxRatio = table.Column<double>(type: "float", nullable: false),
                    IncomeTaxExpense = table.Column<double>(type: "float", nullable: false),
                    NetIncome = table.Column<double>(type: "float", nullable: false),
                    NetIncomeRatio = table.Column<double>(type: "float", nullable: false),
                    Eps = table.Column<double>(type: "float", nullable: false),
                    Epsdiluted = table.Column<double>(type: "float", nullable: false),
                    WeightedAverageShsOut = table.Column<double>(type: "float", nullable: false),
                    WeightedAverageShsOutDil = table.Column<double>(type: "float", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FinalLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeStatement", x => x.Symbol);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IncomeStatement");

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    peRatio = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.Id);
                });
        }
    }
}
