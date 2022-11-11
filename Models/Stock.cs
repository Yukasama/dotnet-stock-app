using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Obliviate.Models
{
    public class Stock
    {
        [Key]
        [JsonProperty("symbol")]
        public string? Symbol { get; set; }

        [JsonProperty("date")]
        public string? Date { get; set; }

        [JsonProperty("dcf")]
        public string? Dcf { get; set; }

        [JsonProperty("Stock Price")]
        public string? StockPrice { get; set; }

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

        [JsonProperty("stringerestIncome")]
        public string? stringerestIncome { get; set; }

        [JsonProperty("stringerestExpense")]
        public string? stringerestExpense { get; set; }

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

        [JsonProperty("cashAndCashEquivalents")]
        public string? CashAndCashEquivalents { get; set; }

        [JsonProperty("shortTermInvestments")]
        public string? ShortTermInvestments { get; set; }

        [JsonProperty("cashAndShortTermInvestments")]
        public string? CashAndShortTermInvestments { get; set; }

        [JsonProperty("netReceivables")]
        public string? NetReceivables { get; set; }

        [JsonProperty("inventory")]
        public string? Inventory { get; set; }

        [JsonProperty("otherCurrentAssets")]
        public string? OtherCurrentAssets { get; set; }

        [JsonProperty("totalCurrentAssets")]
        public string? TotalCurrentAssets { get; set; }

        [JsonProperty("propertyPlantEquipmentNet")]
        public string? PropertyPlantEquipmentNet { get; set; }

        [JsonProperty("goodwill")]
        public string? Goodwill { get; set; }

        [JsonProperty("stringangibleAssets")]
        public string? stringangibleAssets { get; set; }

        [JsonProperty("goodwillAndstringangibleAssets")]
        public string? GoodwillAndstringangibleAssets { get; set; }

        [JsonProperty("stringTermInvestments")]
        public string? stringTermInvestments { get; set; }

        [JsonProperty("taxAssets")]
        public string? TaxAssets { get; set; }

        [JsonProperty("otherNonCurrentAssets")]
        public string? OtherNonCurrentAssets { get; set; }

        [JsonProperty("totalNonCurrentAssets")]
        public string? TotalNonCurrentAssets { get; set; }

        [JsonProperty("otherAssets")]
        public string? OtherAssets { get; set; }

        [JsonProperty("totalAssets")]
        public string? TotalAssets { get; set; }

        [JsonProperty("accountPayables")]
        public string? AccountPayables { get; set; }

        [JsonProperty("shortTermDebt")]
        public string? ShortTermDebt { get; set; }

        [JsonProperty("taxPayables")]
        public string? TaxPayables { get; set; }

        [JsonProperty("deferredRevenue")]
        public string? DeferredRevenue { get; set; }

        [JsonProperty("otherCurrentLiabilities")]
        public string? OtherCurrentLiabilities { get; set; }

        [JsonProperty("totalCurrentLiabilities")]
        public string? TotalCurrentLiabilities { get; set; }

        [JsonProperty("stringTermDebt")]
        public string? stringTermDebt { get; set; }

        [JsonProperty("deferredRevenueNonCurrent")]
        public string? DeferredRevenueNonCurrent { get; set; }

        [JsonProperty("deferredTaxLiabilitiesNonCurrent")]
        public string? DeferredTaxLiabilitiesNonCurrent { get; set; }

        [JsonProperty("otherNonCurrentLiabilities")]
        public string? OtherNonCurrentLiabilities { get; set; }

        [JsonProperty("totalNonCurrentLiabilities")]
        public string? TotalNonCurrentLiabilities { get; set; }

        [JsonProperty("otherLiabilities")]
        public string? OtherLiabilities { get; set; }

        [JsonProperty("capitalLeaseObligations")]
        public string? CapitalLeaseObligations { get; set; }

        [JsonProperty("totalLiabilities")]
        public string? TotalLiabilities { get; set; }

        [JsonProperty("preferredStock")]
        public string? PreferredStock { get; set; }

        [JsonProperty("commonStock")]
        public string? CommonStock { get; set; }

        [JsonProperty("retainedEarnings")]
        public string? RetainedEarnings { get; set; }

        [JsonProperty("accumulatedOtherComprehensiveIncomeLoss")]
        public string? AccumulatedOtherComprehensiveIncomeLoss { get; set; }

        [JsonProperty("othertotalStockholdersEquity")]
        public string? OthertotalStockholdersEquity { get; set; }

        [JsonProperty("totalStockholdersEquity")]
        public string? TotalStockholdersEquity { get; set; }

        [JsonProperty("totalLiabilitiesAndStockholdersEquity")]
        public string? TotalLiabilitiesAndStockholdersEquity { get; set; }

        [JsonProperty("minoritystringerest")]
        public string? Minoritystringerest { get; set; }

        [JsonProperty("totalEquity")]
        public string? TotalEquity { get; set; }

        [JsonProperty("totalLiabilitiesAndTotalEquity")]
        public string? TotalLiabilitiesAndTotalEquity { get; set; }

        [JsonProperty("totalInvestments")]
        public string? TotalInvestments { get; set; }

        [JsonProperty("totalDebt")]
        public string? TotalDebt { get; set; }

        [JsonProperty("netDebt")]
        public string? NetDebt { get; set; }

        [JsonProperty("deferredIncomeTax")]
        public string? DeferredIncomeTax { get; set; }

        [JsonProperty("stockBasedCompensation")]
        public string? StockBasedCompensation { get; set; }

        [JsonProperty("changeInWorkingCapital")]
        public string? ChangeInWorkingCapital { get; set; }

        [JsonProperty("accountsReceivables")]
        public string? AccountsReceivables { get; set; }

        [JsonProperty("accountsPayables")]
        public string? AccountsPayables { get; set; }

        [JsonProperty("otherWorkingCapital")]
        public string? OtherWorkingCapital { get; set; }

        [JsonProperty("otherNonCashItems")]
        public string? OtherNonCashItems { get; set; }

        [JsonProperty("netCashProvidedByOperatingActivities")]
        public string? NetCashProvidedByOperatingActivities { get; set; }

        [JsonProperty("investmentsInPropertyPlantAndEquipment")]
        public string? InvestmentsInPropertyPlantAndEquipment { get; set; }

        [JsonProperty("acquisitionsNet")]
        public string? AcquisitionsNet { get; set; }

        [JsonProperty("purchasesOfInvestments")]
        public string? PurchasesOfInvestments { get; set; }

        [JsonProperty("salesMaturitiesOfInvestments")]
        public string? SalesMaturitiesOfInvestments { get; set; }

        [JsonProperty("otherInvestingActivites")]
        public string? OtherInvestingActivites { get; set; }

        [JsonProperty("netCashUsedForInvestingActivites")]
        public string? NetCashUsedForInvestingActivites { get; set; }

        [JsonProperty("debtRepayment")]
        public string? DebtRepayment { get; set; }

        [JsonProperty("commonStockIssued")]
        public string? CommonStockIssued { get; set; }

        [JsonProperty("commonStockRepurchased")]
        public string? CommonStockRepurchased { get; set; }

        [JsonProperty("dividendsPaid")]
        public string? DividendsPaid { get; set; }

        [JsonProperty("otherFinancingActivites")]
        public string? OtherFinancingActivites { get; set; }

        [JsonProperty("netCashUsedProvidedByFinancingActivities")]
        public string? NetCashUsedProvidedByFinancingActivities { get; set; }

        [JsonProperty("effectOfForexChangesOnCash")]
        public string? EffectOfForexChangesOnCash { get; set; }

        [JsonProperty("netChangeInCash")]
        public string? NetChangeInCash { get; set; }

        [JsonProperty("cashAtEndOfPeriod")]
        public string? CashAtEndOfPeriod { get; set; }

        [JsonProperty("cashAtBeginningOfPeriod")]
        public string? CashAtBeginningOfPeriod { get; set; }

        [JsonProperty("operatingCashFlow")]
        public string? OperatingCashFlow { get; set; }

        [JsonProperty("capitalExpenditure")]
        public string? CapitalExpenditure { get; set; }

        [JsonProperty("freeCashFlow")]
        public string? FreeCashFlow { get; set; }

        [JsonProperty("currentRatio")]
        public string? CurrentRatio { get; set; }

        [JsonProperty("quickRatio")]
        public string? QuickRatio { get; set; }

        [JsonProperty("cashRatio")]
        public string? CashRatio { get; set; }

        [JsonProperty("daysOfSalesOutstanding")]
        public string? DaysOfSalesOutstanding { get; set; }

        [JsonProperty("daysOfInventoryOutstanding")]
        public string? DaysOfInventoryOutstanding { get; set; }

        [JsonProperty("operatingCycle")]
        public string? OperatingCycle { get; set; }

        [JsonProperty("daysOfPayablesOutstanding")]
        public string? DaysOfPayablesOutstanding { get; set; }

        [JsonProperty("cashConversionCycle")]
        public string? CashConversionCycle { get; set; }

        [JsonProperty("grossProfitMargin")]
        public string? GrossProfitMargin { get; set; }

        [JsonProperty("operatingProfitMargin")]
        public string? OperatingProfitMargin { get; set; }

        [JsonProperty("pretaxProfitMargin")]
        public string? PretaxProfitMargin { get; set; }

        [JsonProperty("netProfitMargin")]
        public string? NetProfitMargin { get; set; }

        [JsonProperty("effectiveTaxRate")]
        public string? EffectiveTaxRate { get; set; }

        [JsonProperty("returnOnAssets")]
        public string? ReturnOnAssets { get; set; }

        [JsonProperty("returnOnEquity")]
        public string? ReturnOnEquity { get; set; }

        [JsonProperty("returnOnCapitalEmployed")]
        public string? ReturnOnCapitalEmployed { get; set; }

        [JsonProperty("netIncomePerEBT")]
        public string? NetIncomePerEBT { get; set; }

        [JsonProperty("ebtPerEbit")]
        public string? EbtPerEbit { get; set; }

        [JsonProperty("ebitPerRevenue")]
        public string? EbitPerRevenue { get; set; }

        [JsonProperty("debtRatio")]
        public string? DebtRatio { get; set; }

        [JsonProperty("debtEquityRatio")]
        public string? DebtEquityRatio { get; set; }

        [JsonProperty("stringTermDebtToCapitalization")]
        public string? stringTermDebtToCapitalization { get; set; }

        [JsonProperty("totalDebtToCapitalization")]
        public string? TotalDebtToCapitalization { get; set; }

        [JsonProperty("stringerestCoverage")]
        public string? stringerestCoverage { get; set; }

        [JsonProperty("cashFlowToDebtRatio")]
        public string? CashFlowToDebtRatio { get; set; }

        [JsonProperty("companyEquityMultiplier")]
        public string? CompanyEquityMultiplier { get; set; }

        [JsonProperty("receivablesTurnover")]
        public string? ReceivablesTurnover { get; set; }

        [JsonProperty("payablesTurnover")]
        public string? PayablesTurnover { get; set; }

        [JsonProperty("inventoryTurnover")]
        public string? InventoryTurnover { get; set; }

        [JsonProperty("fixedAssetTurnover")]
        public string? FixedAssetTurnover { get; set; }

        [JsonProperty("assetTurnover")]
        public string? AssetTurnover { get; set; }

        [JsonProperty("operatingCashFlowPerShare")]
        public string? OperatingCashFlowPerShare { get; set; }

        [JsonProperty("freeCashFlowPerShare")]
        public string? FreeCashFlowPerShare { get; set; }

        [JsonProperty("cashPerShare")]
        public string? CashPerShare { get; set; }

        [JsonProperty("payoutRatio")]
        public string? PayoutRatio { get; set; }

        [JsonProperty("operatingCashFlowSalesRatio")]
        public string? OperatingCashFlowSalesRatio { get; set; }

        [JsonProperty("freeCashFlowOperatingCashFlowRatio")]
        public string? FreeCashFlowOperatingCashFlowRatio { get; set; }

        [JsonProperty("cashFlowCoverageRatios")]
        public string? CashFlowCoverageRatios { get; set; }

        [JsonProperty("shortTermCoverageRatios")]
        public string? ShortTermCoverageRatios { get; set; }

        [JsonProperty("capitalExpenditureCoverageRatio")]
        public string? CapitalExpenditureCoverageRatio { get; set; }

        [JsonProperty("dividendPaidAndCapexCoverageRatio")]
        public string? DividendPaidAndCapexCoverageRatio { get; set; }

        [JsonProperty("dividendPayoutRatio")]
        public string? DividendPayoutRatio { get; set; }

        [JsonProperty("priceBookValueRatio")]
        public string? PriceBookValueRatio { get; set; }

        [JsonProperty("priceToBookRatio")]
        public string? PriceToBookRatio { get; set; }

        [JsonProperty("priceToSalesRatio")]
        public string? PriceToSalesRatio { get; set; }

        [JsonProperty("priceEarningsRatio")]
        public string? PriceEarningsRatio { get; set; }

        [JsonProperty("priceToFreeCashFlowsRatio")]
        public string? PriceToFreeCashFlowsRatio { get; set; }

        [JsonProperty("priceToOperatingCashFlowsRatio")]
        public string? PriceToOperatingCashFlowsRatio { get; set; }

        [JsonProperty("priceCashFlowRatio")]
        public string? PriceCashFlowRatio { get; set; }

        [JsonProperty("priceEarningsToGrowthRatio")]
        public string? PriceEarningsToGrowthRatio { get; set; }

        [JsonProperty("priceSalesRatio")]
        public string? PriceSalesRatio { get; set; }

        [JsonProperty("dividendYield")]
        public string? DividendYield { get; set; }

        [JsonProperty("enterpriseValueMultiple")]
        public string? EnterpriseValueMultiple { get; set; }

        [JsonProperty("priceFairValue")]
        public string? PriceFairValue { get; set; }

        [JsonProperty("revenuePerShare")]
        public string? RevenuePerShare { get; set; }

        [JsonProperty("netIncomePerShare")]
        public string? NetIncomePerShare { get; set; }

        [JsonProperty("bookValuePerShare")]
        public string? BookValuePerShare { get; set; }

        [JsonProperty("tangibleBookValuePerShare")]
        public string? TangibleBookValuePerShare { get; set; }

        [JsonProperty("shareholdersEquityPerShare")]
        public string? ShareholdersEquityPerShare { get; set; }

        [JsonProperty("stringerestDebtPerShare")]
        public string? stringerestDebtPerShare { get; set; }

        [JsonProperty("marketCap")]
        public string? MarketCap { get; set; }

        [JsonProperty("enterpriseValue")]
        public string? EnterpriseValue { get; set; }

        [JsonProperty("peRatio")]
        public string? PeRatio { get; set; }

        [JsonProperty("pocfratio")]
        public string? Pocfratio { get; set; }

        [JsonProperty("pfcfRatio")]
        public string? PfcfRatio { get; set; }

        [JsonProperty("pbRatio")]
        public string? PbRatio { get; set; }

        [JsonProperty("ptbRatio")]
        public string? PtbRatio { get; set; }

        [JsonProperty("evToSales")]
        public string? EvToSales { get; set; }

        [JsonProperty("enterpriseValueOverEBITDA")]
        public string? EnterpriseValueOverEBITDA { get; set; }

        [JsonProperty("evToOperatingCashFlow")]
        public string? EvToOperatingCashFlow { get; set; }

        [JsonProperty("evToFreeCashFlow")]
        public string? EvToFreeCashFlow { get; set; }

        [JsonProperty("earningsYield")]
        public string? EarningsYield { get; set; }

        [JsonProperty("freeCashFlowYield")]
        public string? FreeCashFlowYield { get; set; }

        [JsonProperty("debtToEquity")]
        public string? DebtToEquity { get; set; }

        [JsonProperty("debtToAssets")]
        public string? DebtToAssets { get; set; }

        [JsonProperty("netDebtToEBITDA")]
        public string? NetDebtToEBITDA { get; set; }

        [JsonProperty("incomeQuality")]
        public string? IncomeQuality { get; set; }

        [JsonProperty("salesGeneralAndAdministrativeToRevenue")]
        public string? SalesGeneralAndAdministrativeToRevenue { get; set; }

        [JsonProperty("researchAndDdevelopementToRevenue")]
        public string? ResearchAndDdevelopementToRevenue { get; set; }

        [JsonProperty("stringangiblesToTotalAssets")]
        public string? stringangiblesToTotalAssets { get; set; }

        [JsonProperty("capexToOperatingCashFlow")]
        public string? CapexToOperatingCashFlow { get; set; }

        [JsonProperty("capexToRevenue")]
        public string? CapexToRevenue { get; set; }

        [JsonProperty("capexToDepreciation")]
        public string? CapexToDepreciation { get; set; }

        [JsonProperty("stockBasedCompensationToRevenue")]
        public string? StockBasedCompensationToRevenue { get; set; }

        [JsonProperty("grahamNumber")]
        public string? GrahamNumber { get; set; }

        [JsonProperty("roic")]
        public string? Roic { get; set; }

        [JsonProperty("returnOnTangibleAssets")]
        public string? ReturnOnTangibleAssets { get; set; }

        [JsonProperty("grahamNetNet")]
        public string? GrahamNetNet { get; set; }

        [JsonProperty("workingCapital")]
        public string? WorkingCapital { get; set; }

        [JsonProperty("tangibleAssetValue")]
        public string? TangibleAssetValue { get; set; }

        [JsonProperty("netCurrentAssetValue")]
        public string? NetCurrentAssetValue { get; set; }

        [JsonProperty("investedCapital")]
        public string? InvestedCapital { get; set; }

        [JsonProperty("averageReceivables")]
        public string? AverageReceivables { get; set; }

        [JsonProperty("averagePayables")]
        public string? AveragePayables { get; set; }

        [JsonProperty("averageInventory")]
        public string? AverageInventory { get; set; }

        [JsonProperty("daysSalesOutstanding")]
        public string? DaysSalesOutstanding { get; set; }

        [JsonProperty("daysPayablesOutstanding")]
        public string? DaysPayablesOutstanding { get; set; }

        [JsonProperty("daysOfInventoryOnHand")]
        public string? DaysOfInventoryOnHand { get; set; }

        [JsonProperty("roe")]
        public string? Roe { get; set; }

        [JsonProperty("capexPerShare")]
        public string? CapexPerShare { get; set; }

        [JsonProperty("price")]
        public string? Price { get; set; }

        [JsonProperty("beta")]
        public string? Beta { get; set; }

        [JsonProperty("volAvg")]
        public string? VolAvg { get; set; }

        [JsonProperty("mktCap")]
        public string? MktCap { get; set; }

        [JsonProperty("lastDiv")]
        public string? LastDiv { get; set; }

        [JsonProperty("range")]
        public string? Range { get; set; }

        [JsonProperty("changes")]
        public string? Changes { get; set; }

        [JsonProperty("companyName")]
        public string? CompanyName { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("isin")]
        public string? Isin { get; set; }

        [JsonProperty("cusip")]
        public string? Cusip { get; set; }

        [JsonProperty("exchange")]
        public string? Exchange { get; set; }

        [JsonProperty("exchangeShortName")]
        public string? ExchangeShortName { get; set; }

        [JsonProperty("industry")]
        public string? Industry { get; set; }

        [JsonProperty("website")]
        public string? Website { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("ceo")]
        public string? Ceo { get; set; }

        [JsonProperty("sector")]
        public string? Sector { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("fullTimeEmployees")]
        public string? FullTimeEmployees { get; set; }

        [JsonProperty("phone")]
        public string? Phone { get; set; }

        [JsonProperty("address")]
        public string? Address { get; set; }

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("zip")]
        public string? Zip { get; set; }

        [JsonProperty("dcfDiff")]
        public string? DcfDiff { get; set; }

        [JsonProperty("image")]
        public string? Image { get; set; }

        [JsonProperty("ipoDate")]
        public string? IpoDate { get; set; }

        [JsonProperty("defaultImage")]
        public string? DefaultImage { get; set; }

        [JsonProperty("isEtf")]
        public string? IsEtf { get; set; }

        [JsonProperty("isActivelyTrading")]
        public string? IsActivelyTrading { get; set; }

        [JsonProperty("isAdr")]
        public string? IsAdr { get; set; }

        [JsonProperty("isFund")]
        public string? IsFund { get; set; }

        [JsonProperty("rating")]
        public string? Rating { get; set; }

        [JsonProperty("ratingScore")]
        public string? RatingScore { get; set; }

        [JsonProperty("ratingRecommendation")]
        public string? RatingRecommendation { get; set; }

        [JsonProperty("ratingDetailsDCFScore")]
        public string? RatingDetailsDCFScore { get; set; }

        [JsonProperty("ratingDetailsDCFRecommendation")]
        public string? RatingDetailsDCFRecommendation { get; set; }

        [JsonProperty("ratingDetailsROEScore")]
        public string? RatingDetailsROEScore { get; set; }

        [JsonProperty("ratingDetailsROERecommendation")]
        public string? RatingDetailsROERecommendation { get; set; }

        [JsonProperty("ratingDetailsROAScore")]
        public string? RatingDetailsROAScore { get; set; }

        [JsonProperty("ratingDetailsROARecommendation")]
        public string? RatingDetailsROARecommendation { get; set; }

        [JsonProperty("ratingDetailsDEScore")]
        public string? RatingDetailsDEScore { get; set; }

        [JsonProperty("ratingDetailsDERecommendation")]
        public string? RatingDetailsDERecommendation { get; set; }

        [JsonProperty("ratingDetailsPEScore")]
        public string? RatingDetailsPEScore { get; set; }

        [JsonProperty("ratingDetailsPERecommendation")]
        public string? RatingDetailsPERecommendation { get; set; }

        [JsonProperty("ratingDetailsPBScore")]
        public string? RatingDetailsPBScore { get; set; }

        [JsonProperty("ratingDetailsPBRecommendation")]
        public string? RatingDetailsPBRecommendation { get; set; }

        [JsonProperty("peersList")]
        public string? peersList { get; set; }

        [JsonProperty("environmentalScore")]
        public string? environmentalScore { get; set; }

        [JsonProperty("socialScore")]
        public string? socialScore { get; set; }

        [JsonProperty("governanceScore")]
        public string? governanceScore { get; set; }

        [JsonProperty("ESGScore")]
        public string? ESGScore { get; set; }

        [JsonProperty("url")]
        public string? url { get; set; }

        [JsonProperty("targetHigh")]
        public string? targetHigh { get; set; }

        [JsonProperty("targetLow")]
        public string? targetLow { get; set; }

        [JsonProperty("targetConsensus")]
        public string? targetConsensus { get; set; }

        [JsonProperty("targetMedian")]
        public string? targetMedian { get; set; }

        [JsonProperty("estimatedRevenueLow")]
        public string? EstimatedRevenueLow { get; set; }

        [JsonProperty("estimatedRevenueHigh")]
        public string? EstimatedRevenueHigh { get; set; }

        [JsonProperty("estimatedRevenueAvg")]
        public string? EstimatedRevenueAvg { get; set; }

        [JsonProperty("estimatedEbitdaLow")]
        public string? EstimatedEbitdaLow { get; set; }

        [JsonProperty("estimatedEbitdaHigh")]
        public string? EstimatedEbitdaHigh { get; set; }

        [JsonProperty("estimatedEbitdaAvg")]
        public string? EstimatedEbitdaAvg { get; set; }

        [JsonProperty("estimatedEbitLow")]
        public string? EstimatedEbitLow { get; set; }

        [JsonProperty("estimatedEbitHigh")]
        public string? EstimatedEbitHigh { get; set; }

        [JsonProperty("estimatedEbitAvg")]
        public string? EstimatedEbitAvg { get; set; }

        [JsonProperty("estimatedNetIncomeLow")]
        public string? EstimatedNetIncomeLow { get; set; }

        [JsonProperty("estimatedNetIncomeHigh")]
        public string? EstimatedNetIncomeHigh { get; set; }

        [JsonProperty("estimatedNetIncomeAvg")]
        public string? EstimatedNetIncomeAvg { get; set; }

        [JsonProperty("estimatedSgaExpenseLow")]
        public string? EstimatedSgaExpenseLow { get; set; }

        [JsonProperty("estimatedSgaExpenseHigh")]
        public string? EstimatedSgaExpenseHigh { get; set; }

        [JsonProperty("estimatedSgaExpenseAvg")]
        public string? EstimatedSgaExpenseAvg { get; set; }

        [JsonProperty("estimatedEpsAvg")]
        public string? EstimatedEpsAvg { get; set; }

        [JsonProperty("estimatedEpsHigh")]
        public string? EstimatedEpsHigh { get; set; }

        [JsonProperty("estimatedEpsLow")]
        public string? EstimatedEpsLow { get; set; }

        [JsonProperty("numberAnalystEstimatedRevenue")]
        public string? NumberAnalystEstimatedRevenue { get; set; }

        [JsonProperty("numberAnalystsEstimatedEps")]
        public string? NumberAnalystsEstimatedEps { get; set; }

        [JsonProperty("historyDate")]
        public string? HistoryDate { get; set; }

        [JsonProperty("open")]
        public string? Open { get; set; }

        [JsonProperty("high")]
        public string? High { get; set; }

        [JsonProperty("low")]
        public string? Low { get; set; }

        [JsonProperty("adjClose")]
        public string? Close { get; set; }

        [JsonProperty("volume")]
        public string? Volume { get; set; }

        [JsonProperty("change")]
        public string? Change { get; set; }

        [JsonProperty("changePercent")]
        public string? ChangePercent { get; set; }

        [JsonProperty("vwap")]
        public string? Vwap { get; set; }

        [JsonProperty("label")]
        public string? Label { get; set; }

        [JsonProperty("changeOverTime")]
        public string? ChangeOverTime { get; set; }

        [JsonProperty("sma20")]
        public string? SMA20 { get; set; }

        [JsonProperty("sma50")]
        public string? SMA50 { get; set; }

        [JsonProperty("sma100")]
        public string? SMA100 { get; set; }

        [JsonProperty("sma200")]
        public string? SMA200 { get; set; }

        [JsonProperty("wpr")]
        public string? WPR { get; set; }

        [JsonProperty("rsi")]
        public string? RSI { get; set; }
    }
}
