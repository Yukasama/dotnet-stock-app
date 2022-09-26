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
        public string Symbol { get; set; }

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
        public long Revenue { get; set; }

        [JsonProperty("costOfRevenue")]
        public long CostOfRevenue { get; set; }

        [JsonProperty("grossProfit")]
        public long GrossProfit { get; set; }

        [JsonProperty("grossProfitRatio")]
        public double GrossProfitRatio { get; set; }

        [JsonProperty("researchAndDevelopmentExpenses")]
        public long ResearchAndDevelopmentExpenses { get; set; }

        [JsonProperty("generalAndAdministrativeExpenses")]
        public double GeneralAndAdministrativeExpenses { get; set; }

        [JsonProperty("sellingAndMarketingExpenses")]
        public double SellingAndMarketingExpenses { get; set; }

        [JsonProperty("sellingGeneralAndAdministrativeExpenses")]
        public long SellingGeneralAndAdministrativeExpenses { get; set; }

        [JsonProperty("otherExpenses")]
        public double OtherExpenses { get; set; }

        [JsonProperty("operatingExpenses")]
        public long OperatingExpenses { get; set; }

        [JsonProperty("costAndExpenses")]
        public long CostAndExpenses { get; set; }

        [JsonProperty("interestIncome")]
        public long InterestIncome { get; set; }

        [JsonProperty("interestExpense")]
        public long InterestExpense { get; set; }

        [JsonProperty("depreciationAndAmortization")]
        public long DepreciationAndAmortization { get; set; }

        [JsonProperty("ebitda")]
        public long Ebitda { get; set; }

        [JsonProperty("ebitdaratio")]
        public double Ebitdaratio { get; set; }

        [JsonProperty("operatingIncome")]
        public long OperatingIncome { get; set; }

        [JsonProperty("operatingIncomeRatio")]
        public double OperatingIncomeRatio { get; set; }

        [JsonProperty("totalOtherIncomeExpensesNet")]
        public int TotalOtherIncomeExpensesNet { get; set; }

        [JsonProperty("incomeBeforeTax")]
        public long IncomeBeforeTax { get; set; }

        [JsonProperty("incomeBeforeTaxRatio")]
        public double IncomeBeforeTaxRatio { get; set; }

        [JsonProperty("incomeTaxExpense")]
        public long IncomeTaxExpense { get; set; }

        [JsonProperty("netIncome")]
        public long NetIncome { get; set; }

        [JsonProperty("netIncomeRatio")]
        public double NetIncomeRatio { get; set; }

        [JsonProperty("eps")]
        public double Eps { get; set; }

        [JsonProperty("epsdiluted")]
        public double Epsdiluted { get; set; }

        [JsonProperty("weightedAverageShsOut")]
        public long WeightedAverageShsOut { get; set; }

        [JsonProperty("weightedAverageShsOutDil")]
        public long WeightedAverageShsOutDil { get; set; }

        [JsonProperty("link")]
        public string? Link { get; set; }

        [JsonProperty("finalLink")]
        public string? FinalLink { get; set; }
    }
}
