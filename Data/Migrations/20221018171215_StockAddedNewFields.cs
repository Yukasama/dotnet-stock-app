using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Obliviate.Migrations
{
    public partial class StockAddedNewFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountPayables",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccountsPayables",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccountsReceivables",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccumulatedOtherComprehensiveIncomeLoss",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AcquisitionsNet",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssetTurnover",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AverageInventory",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AveragePayables",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AverageReceivables",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BookValuePerShare",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CapexPerShare",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CapexToDepreciation",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CapexToOperatingCashFlow",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CapexToRevenue",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CapitalExpenditure",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CapitalExpenditureCoverageRatio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CapitalLeaseObligations",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CashAndCashEquivalents",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CashAndShortTermInvestments",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CashAtBeginningOfPeriod",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CashAtEndOfPeriod",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CashConversionCycle",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CashFlowCoverageRatios",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CashFlowToDebtRatio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CashPerShare",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CashRatio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChangeInWorkingCapital",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommonStock",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommonStockIssued",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommonStockRepurchased",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyEquityMultiplier",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentRatio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DaysOfInventoryOnHand",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DaysOfInventoryOutstanding",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DaysOfPayablesOutstanding",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DaysOfSalesOutstanding",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DaysPayablesOutstanding",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DaysSalesOutstanding",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DebtEquityRatio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DebtRatio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DebtRepayment",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DebtToAssets",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DebtToEquity",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeferredIncomeTax",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeferredRevenue",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeferredRevenueNonCurrent",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeferredTaxLiabilitiesNonCurrent",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DividendPaidAndCapexCoverageRatio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DividendPayoutRatio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DividendYield",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DividendsPaid",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EarningsYield",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EbitPerRevenue",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EbtPerEbit",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EffectOfForexChangesOnCash",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EffectiveTaxRate",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnterpriseValue",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnterpriseValueMultiple",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnterpriseValueOverEBITDA",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EvToFreeCashFlow",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EvToOperatingCashFlow",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EvToSales",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FixedAssetTurnover",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FreeCashFlow",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FreeCashFlowOperatingCashFlowRatio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FreeCashFlowPerShare",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FreeCashFlowYield",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Goodwill",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GoodwillAndIntangibleAssets",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GrahamNetNet",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GrahamNumber",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GrossProfitMargin",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IncomeQuality",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IntangibleAssets",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IntangiblesToTotalAssets",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InterestCoverage",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InterestDebtPerShare",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Inventory",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InventoryTurnover",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvestedCapital",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvestmentsInPropertyPlantAndEquipment",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LongTermDebt",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LongTermDebtToCapitalization",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LongTermInvestments",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MarketCap",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MinorityInterest",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NetCashProvidedByOperatingActivities",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NetCashUsedForInvestingActivites",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NetCashUsedProvidedByFinancingActivities",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NetChangeInCash",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NetCurrentAssetValue",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NetDebt",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NetDebtToEBITDA",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NetIncomePerEBT",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NetIncomePerShare",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NetProfitMargin",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NetReceivables",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OperatingCashFlow",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OperatingCashFlowPerShare",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OperatingCashFlowSalesRatio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OperatingCycle",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OperatingProfitMargin",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherAssets",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherCurrentAssets",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherCurrentLiabilities",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherFinancingActivites",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherInvestingActivites",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherLiabilities",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherNonCashItems",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherNonCurrentAssets",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherNonCurrentLiabilities",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherWorkingCapital",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OthertotalStockholdersEquity",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PayablesTurnover",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PayoutRatio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PbRatio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PeRatio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PfcfRatio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pocfratio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreferredStock",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PretaxProfitMargin",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PriceBookValueRatio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PriceCashFlowRatio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PriceEarningsRatio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PriceEarningsToGrowthRatio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PriceFairValue",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PriceSalesRatio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PriceToBookRatio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PriceToFreeCashFlowsRatio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PriceToOperatingCashFlowsRatio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PriceToSalesRatio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PropertyPlantEquipmentNet",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PtbRatio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PurchasesOfInvestments",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QuickRatio",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceivablesTurnover",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResearchAndDdevelopementToRevenue",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RetainedEarnings",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReturnOnAssets",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReturnOnCapitalEmployed",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReturnOnEquity",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReturnOnTangibleAssets",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevenuePerShare",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Roe",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Roic",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SalesGeneralAndAdministrativeToRevenue",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SalesMaturitiesOfInvestments",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShareholdersEquityPerShare",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShortTermCoverageRatios",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShortTermDebt",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShortTermInvestments",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StockBasedCompensation",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StockBasedCompensationToRevenue",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TangibleAssetValue",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TangibleBookValuePerShare",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaxAssets",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaxPayables",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalAssets",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalCurrentAssets",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalCurrentLiabilities",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalDebt",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalDebtToCapitalization",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalEquity",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalInvestments",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalLiabilities",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalLiabilitiesAndStockholdersEquity",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalLiabilitiesAndTotalEquity",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalNonCurrentAssets",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalNonCurrentLiabilities",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TotalStockholdersEquity",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkingCapital",
                table: "Stock",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountPayables",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "AccountsPayables",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "AccountsReceivables",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "AccumulatedOtherComprehensiveIncomeLoss",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "AcquisitionsNet",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "AssetTurnover",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "AverageInventory",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "AveragePayables",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "AverageReceivables",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "BookValuePerShare",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CapexPerShare",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CapexToDepreciation",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CapexToOperatingCashFlow",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CapexToRevenue",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CapitalExpenditure",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CapitalExpenditureCoverageRatio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CapitalLeaseObligations",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CashAndCashEquivalents",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CashAndShortTermInvestments",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CashAtBeginningOfPeriod",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CashAtEndOfPeriod",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CashConversionCycle",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CashFlowCoverageRatios",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CashFlowToDebtRatio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CashPerShare",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CashRatio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "ChangeInWorkingCapital",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CommonStock",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CommonStockIssued",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CommonStockRepurchased",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CompanyEquityMultiplier",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CurrentRatio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "DaysOfInventoryOnHand",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "DaysOfInventoryOutstanding",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "DaysOfPayablesOutstanding",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "DaysOfSalesOutstanding",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "DaysPayablesOutstanding",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "DaysSalesOutstanding",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "DebtEquityRatio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "DebtRatio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "DebtRepayment",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "DebtToAssets",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "DebtToEquity",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "DeferredIncomeTax",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "DeferredRevenue",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "DeferredRevenueNonCurrent",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "DeferredTaxLiabilitiesNonCurrent",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "DividendPaidAndCapexCoverageRatio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "DividendPayoutRatio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "DividendYield",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "DividendsPaid",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EarningsYield",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EbitPerRevenue",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EbtPerEbit",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EffectOfForexChangesOnCash",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EffectiveTaxRate",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EnterpriseValue",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EnterpriseValueMultiple",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EnterpriseValueOverEBITDA",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EvToFreeCashFlow",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EvToOperatingCashFlow",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "EvToSales",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "FixedAssetTurnover",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "FreeCashFlow",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "FreeCashFlowOperatingCashFlowRatio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "FreeCashFlowPerShare",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "FreeCashFlowYield",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Goodwill",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "GoodwillAndIntangibleAssets",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "GrahamNetNet",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "GrahamNumber",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "GrossProfitMargin",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "IncomeQuality",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "IntangibleAssets",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "IntangiblesToTotalAssets",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "InterestCoverage",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "InterestDebtPerShare",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Inventory",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "InventoryTurnover",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "InvestedCapital",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "InvestmentsInPropertyPlantAndEquipment",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "LongTermDebt",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "LongTermDebtToCapitalization",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "LongTermInvestments",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "MarketCap",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "MinorityInterest",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "NetCashProvidedByOperatingActivities",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "NetCashUsedForInvestingActivites",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "NetCashUsedProvidedByFinancingActivities",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "NetChangeInCash",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "NetCurrentAssetValue",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "NetDebt",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "NetDebtToEBITDA",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "NetIncomePerEBT",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "NetIncomePerShare",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "NetProfitMargin",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "NetReceivables",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "OperatingCashFlow",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "OperatingCashFlowPerShare",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "OperatingCashFlowSalesRatio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "OperatingCycle",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "OperatingProfitMargin",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "OtherAssets",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "OtherCurrentAssets",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "OtherCurrentLiabilities",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "OtherFinancingActivites",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "OtherInvestingActivites",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "OtherLiabilities",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "OtherNonCashItems",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "OtherNonCurrentAssets",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "OtherNonCurrentLiabilities",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "OtherWorkingCapital",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "OthertotalStockholdersEquity",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "PayablesTurnover",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "PayoutRatio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "PbRatio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "PeRatio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "PfcfRatio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Pocfratio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "PreferredStock",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "PretaxProfitMargin",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "PriceBookValueRatio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "PriceCashFlowRatio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "PriceEarningsRatio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "PriceEarningsToGrowthRatio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "PriceFairValue",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "PriceSalesRatio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "PriceToBookRatio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "PriceToFreeCashFlowsRatio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "PriceToOperatingCashFlowsRatio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "PriceToSalesRatio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "PropertyPlantEquipmentNet",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "PtbRatio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "PurchasesOfInvestments",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "QuickRatio",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "ReceivablesTurnover",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "ResearchAndDdevelopementToRevenue",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "RetainedEarnings",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "ReturnOnAssets",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "ReturnOnCapitalEmployed",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "ReturnOnEquity",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "ReturnOnTangibleAssets",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "RevenuePerShare",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Roe",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "Roic",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "SalesGeneralAndAdministrativeToRevenue",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "SalesMaturitiesOfInvestments",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "ShareholdersEquityPerShare",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "ShortTermCoverageRatios",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "ShortTermDebt",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "ShortTermInvestments",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "StockBasedCompensation",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "StockBasedCompensationToRevenue",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "TangibleAssetValue",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "TangibleBookValuePerShare",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "TaxAssets",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "TaxPayables",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "TotalAssets",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "TotalCurrentAssets",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "TotalCurrentLiabilities",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "TotalDebt",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "TotalDebtToCapitalization",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "TotalEquity",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "TotalInvestments",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "TotalLiabilities",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "TotalLiabilitiesAndStockholdersEquity",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "TotalLiabilitiesAndTotalEquity",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "TotalNonCurrentAssets",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "TotalNonCurrentLiabilities",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "TotalStockholdersEquity",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "WorkingCapital",
                table: "Stock");
        }
    }
}
