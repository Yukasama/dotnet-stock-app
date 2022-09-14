using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Obliviate.Models.Stocks
{
    public class IncomeStatement
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [Key]
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("reportedCurrency")]
        public string ReportedCurrency { get; set; }

        [JsonProperty("cik")]
        public string Cik { get; set; }

        [JsonProperty("fillingDate")]
        public string FillingDate { get; set; }

        [JsonProperty("acceptedDate")]
        public string AcceptedDate { get; set; }

        [JsonProperty("calendarYear")]
        public string CalendarYear { get; set; }

        [JsonProperty("period")]
        public string Period { get; set; }

        [JsonProperty("revenue")]
        public double Revenue { get; set; }

        [JsonProperty("costOfRevenue")]
        public double CostOfRevenue { get; set; }

        [JsonProperty("grossProfit")]
        public double GrossProfit { get; set; }

        [JsonProperty("grossProfitRatio")]
        public double GrossProfitRatio { get; set; }

        [JsonProperty("researchAndDevelopmentExpenses")]
        public double ResearchAndDevelopmentExpenses { get; set; }

        [JsonProperty("generalAndAdministrativeExpenses")]
        public double GeneralAndAdministrativeExpenses { get; set; }

        [JsonProperty("sellingAndMarketingExpenses")]
        public double SellingAndMarketingExpenses { get; set; }

        [JsonProperty("sellingGeneralAndAdministrativeExpenses")]
        public double SellingGeneralAndAdministrativeExpenses { get; set; }

        [JsonProperty("otherExpenses")]
        public double OtherExpenses { get; set; }

        [JsonProperty("operatingExpenses")]
        public double OperatingExpenses { get; set; }

        [JsonProperty("costAndExpenses")]
        [NotMapped]
        public double CostAndExpenses { get; set; }

        [JsonProperty("interestIncome")]
        public double InterestIncome { get; set; }

        [JsonProperty("interestExpense")]
        public double InterestExpense { get; set; }

        [JsonProperty("depreciationAndAmortization")]
        public double DepreciationAndAmortization { get; set; }

        [JsonProperty("ebitda")]
        public double Ebitda { get; set; }

        [JsonProperty("ebitdaratio")]
        public double Ebitdaratio { get; set; }

        [JsonProperty("operatingIncome")]
        public double OperatingIncome { get; set; }

        [JsonProperty("operatingIncomeRatio")]
        public double OperatingIncomeRatio { get; set; }

        [JsonProperty("totalOtherIncomeExpensesNet")]
        public double TotalOtherIncomeExpensesNet { get; set; }

        [JsonProperty("incomeBeforeTax")]
        public double IncomeBeforeTax { get; set; }

        [JsonProperty("incomeBeforeTaxRatio")]
        public double IncomeBeforeTaxRatio { get; set; }

        [JsonProperty("incomeTaxExpense")]
        public double IncomeTaxExpense { get; set; }

        [JsonProperty("netIncome")]
        public double NetIncome { get; set; }

        [JsonProperty("netIncomeRatio")]
        public double NetIncomeRatio { get; set; }

        [JsonProperty("eps")]
        public double Eps { get; set; }

        [JsonProperty("epsdiluted")]
        public double Epsdiluted { get; set; }

        [JsonProperty("weightedAverageShsOut")]
        public double WeightedAverageShsOut { get; set; }

        [JsonProperty("weightedAverageShsOutDil")]
        public double WeightedAverageShsOutDil { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("finalLink")]
        public string FinalLink { get; set; }

    }
}
