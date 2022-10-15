using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Obliviate.Models
{
    public class Stock
    {
        [JsonProperty("date")]
        public string? Date { get; set; }

        [Key]
        [JsonProperty("symbol")]
        public string? Symbol { get; set; }

        [JsonProperty("reportedCurrency")]
        public string? ReportedCurrency { get; set; }

        [JsonProperty("cik")]
        public string? Cik { get; set; }

        [JsonProperty("fillingDate")]
        public string? FillingDate { get; set; }
        
        [JsonProperty("acceptedDate")]
        public string? AcceptedDate { get; set; }

        [JsonProperty("calendarYear")]
        public string? CalendarYear { get; set; }

        [JsonProperty("period")]
        public string? Period { get; set; }

        [JsonProperty("revenue")]
        public string? Revenue { get; set; }

        [JsonProperty("costOfRevenue")]
        public string? CostOfRevenue { get; set; }

        [JsonProperty("grossProfit")]
        public string? GrossProfit { get; set; }

        [JsonProperty("grossProfitRatio")]
        public string? GrossProfitRatio { get; set; }

        [JsonProperty("researchAndDevelopmentExpenses")]
        public string? ResearchAndDevelopmentExpenses { get; set; }

        [JsonProperty("generalAndAdministrativeExpenses")]
        public string? GeneralAndAdministrativeExpenses { get; set; }

        [JsonProperty("sellingAndMarketingExpenses")]
        public string? SellingAndMarketingExpenses { get; set; }

        [JsonProperty("sellingGeneralAndAdministrativeExpenses")]
        public string? SellingGeneralAndAdministrativeExpenses { get; set; }

        [JsonProperty("otherExpenses")]
        public string? OtherExpenses { get; set; }

        [JsonProperty("operatingExpenses")]
        public string? OperatingExpenses { get; set; }

        [JsonProperty("costAndExpenses")]
        public string? CostAndExpenses { get; set; }

        [JsonProperty("interestIncome")]
        public string? InterestIncome { get; set; }

        [JsonProperty("interestExpense")]
        public string? InterestExpense { get; set; }

        [JsonProperty("depreciationAndAmortization")]
        public string? DepreciationAndAmortization { get; set; }

        [JsonProperty("ebitda")]
        public string? Ebitda { get; set; }

        [JsonProperty("ebitdaratio")]
        public string? Ebitdaratio { get; set; }

        [JsonProperty("operatingIncome")]
        public string? OperatingIncome { get; set; }

        [JsonProperty("operatingIncomeRatio")]
        public string? OperatingIncomeRatio { get; set; }

        [JsonProperty("totalOtherIncomeExpensesNet")]
        public string? TotalOtherIncomeExpensesNet { get; set; }

        [JsonProperty("incomeBeforeTax")]
        public string? IncomeBeforeTax { get; set; }

        [JsonProperty("incomeBeforeTaxRatio")]
        public string? IncomeBeforeTaxRatio { get; set; }

        [JsonProperty("incomeTaxExpense")]
        public string? IncomeTaxExpense { get; set; }

        [JsonProperty("netIncome")]
        public string? NetIncome { get; set; }

        [JsonProperty("netIncomeRatio")]
        public string? NetIncomeRatio { get; set; }

        [JsonProperty("eps")]
        public string? Eps { get; set; }

        [JsonProperty("epsdiluted")]
        public string? Epsdiluted { get; set; }

        [JsonProperty("weightedAverageShsOut")]
        public string? WeightedAverageShsOut { get; set; }

        [JsonProperty("weightedAverageShsOutDil")]
        public string? WeightedAverageShsOutDil { get; set; }

        [JsonProperty("link")]
        public string? Link { get; set; }

        [JsonProperty("finalLink")]
        public string? FinalLink { get; set; }
    }
}
