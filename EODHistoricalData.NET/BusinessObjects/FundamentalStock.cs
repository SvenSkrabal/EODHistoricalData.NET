﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using EODHistoricalData.NET;
//
//    var fundamentalStock = FundamentalStock.FromJson(jsonString);

namespace EODHistoricalData.NET
{
    using EODHistoricalData.NET.BusinessObjects;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public partial class FundamentalStock
    {
        [JsonProperty("General")]
        public FundamentalGeneral General { get; set; }

        [JsonProperty("Highlights")]
        public Highlights Highlights { get; set; }

        [JsonProperty("Valuation")]
        public Valuation Valuation { get; set; }

        [JsonProperty("SharesStats")]
        public SharesStats SharesStats { get; set; }

        [JsonProperty("Technicals")]
        public FundamentalTechnicals Technicals { get; set; }

        [JsonProperty("SplitsDividends")]
        public SplitsDividends SplitsDividends { get; set; }

        [JsonProperty("outstandingShares")]
        public OutstandingShares OutstandingShares { get; set; }

        [JsonProperty("Earnings")]
        public Earnings Earnings { get; set; }

        [JsonProperty("Financials")]
        public Financials Financials { get; set; }
    }

    public partial class Earnings
    {
        [JsonProperty("History")]
        public Dictionary<string, History> History { get; set; }

        [JsonProperty("Annual")]
        public Dictionary<string, Annual> Annual { get; set; }

        [JsonProperty("Trend")]
        public Dictionary<string, Dictionary<string, string>> Trend { get; set; }
    }

    public partial class EarningsDetailsBase
    {
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("epsActual")]
        public string EpsActual { get; set; }
    }

    public class Annual : EarningsDetailsBase
    {

    }

    public partial class History : EarningsDetailsBase
    {
        [JsonProperty("reportDate")]
        public DateTimeOffset? ReportDate { get; set; }

        [JsonProperty("epsEstimate")]
        public string EpsEstimate { get; set; }

        [JsonProperty("epsDifference")]
        public string EpsDifference { get; set; }

        [JsonProperty("surprisePercent")]
        public string SurprisePercent { get; set; }

        [JsonProperty("beforeAfterMarket")]
        public string BeforeAfterMarket { get; set; }
    }

    public partial class Financials
    {
        [JsonProperty("Balance_Sheet")]
        public BalanceSheet BalanceSheet { get; set; }

        [JsonProperty("Cash_Flow")]
        public CashFlow CashFlow { get; set; }

        [JsonProperty("Income_Statement")]
        public IncomeStatement IncomeStatement { get; set; }
    }

    public partial class BalanceSheet
    {
        [JsonProperty("currency_symbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("quarterly")]
        public Dictionary<string, BalanceSheetDetails> Quarterly { get; set; }

        [JsonProperty("yearly")]
        public Dictionary<string, BalanceSheetDetails> Yearly { get; set; }
    }

    public partial class CashFlow
    {
        [JsonProperty("currency_symbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("quarterly")]
        public Dictionary<string, Dictionary<string, string>> Quarterly { get; set; }

        [JsonProperty("yearly")]
        public Dictionary<string, Dictionary<string, string>> Yearly { get; set; }
    }

    public partial class IncomeStatement
    {
        [JsonProperty("currency_symbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("quarterly")]
        public Dictionary<string, Dictionary<string, string>> Quarterly { get; set; }

        [JsonProperty("yearly")]
        public Dictionary<string, Dictionary<string, string>> Yearly { get; set; }
    }

    public partial class BalanceSheetDetails
    {
        [JsonProperty("accountsPayable")]
        public decimal? AccountsPayable { get; set; }

        [JsonProperty("accumulatedAmortization")]
        public decimal? AccumulatedAmortization { get; set; }

        [JsonProperty("accumulatedDepreciation")]
        public decimal? AccumulatedDepreciation { get; set; }

        [JsonProperty("accumulatedOtherComprehensiveIncome")]
        public decimal? AccumulatedOtherComprehensiveIncome { get; set; }

        [JsonProperty("additionalPaidInCapital")]
        public decimal? AdditionalPaidInCapital { get; set; }

        [JsonProperty("capitalLeaseObligations")]
        public decimal? CapitalLeaseObligations { get; set; }

        [JsonProperty("capitalSurpluse")]
        public decimal? CapitalSurpluse { get; set; }

        [JsonProperty("cash")]
        public decimal? Cash { get; set; }

        [JsonProperty("cashAndShortTermInvestments")]
        public decimal? CashAndShortTermInvestments { get; set; }

        [JsonProperty("commonStock")]
        public decimal? CommonStock { get; set; }

        [JsonProperty("commonStockSharesOutstanding")]
        public decimal? CommonStockSharesOutstanding { get; set; }

        [JsonProperty("commonStockTotalEquity")]
        public decimal? CommonStockTotalEquity { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("deferredLongTermAssetCharges")]
        public decimal? DeferredLongTermAssetCharges { get; set; }

        [JsonProperty("deferredLongTermLiab")]
        public decimal? DeferredLongTermLiab { get; set; }

        [JsonProperty("filing_date")]
        public DateTime? FilingDate { get; set; }

        [JsonProperty("goodWill")]
        public decimal? GoodWill { get; set; }

        [JsonProperty("intangibleAssets")]
        public decimal? IntangibleAssets { get; set; }

        [JsonProperty("inventory")]
        public decimal? Inventory { get; set; }

        [JsonProperty("liabilitiesAndStockholdersEquity")]
        public decimal? LiabilitiesAndStockholdersEquity { get; set; }

        [JsonProperty("longTermDebt")]
        public decimal? LongTermDebt { get; set; }

        [JsonProperty("longTermDebtTotal")]
        public decimal? LongTermDebtTotal { get; set; }

        [JsonProperty("longTermInvestments")]
        public decimal? LongTermInvestments { get; set; }

        [JsonProperty("negativeGoodwill")]
        public decimal? NegativeGoodwill { get; set; }

        [JsonProperty("netReceivables")]
        public decimal? NetReceivables { get; set; }

        [JsonProperty("netTangibleAssets")]
        public decimal? NetTangibleAssets { get; set; }

        [JsonProperty("nonCurrentAssetsTotal")]
        public decimal? NonCurrentAssetsTotal { get; set; }

        [JsonProperty("nonCurrentLiabilitiesOther")]
        public decimal? NonCurrentLiabilitiesOther { get; set; }

        [JsonProperty("nonCurrentLiabilitiesTotal")]
        public decimal? NonCurrentLiabilitiesTotal { get; set; }

        [JsonProperty("nonCurrrentAssetsOther")]
        public decimal? NonCurrrentAssetsOther { get; set; }

        [JsonProperty("noncontrollingInterestInConsolidatedEntity")]
        public decimal? NoncontrollingInterestInConsolidatedEntity { get; set; }

        [JsonProperty("otherAssets")]
        public decimal? OtherAssets { get; set; }

        [JsonProperty("otherCurrentAssets")]
        public decimal? OtherCurrentAssets { get; set; }

        [JsonProperty("otherCurrentLiab")]
        public decimal? OtherCurrentLiab { get; set; }

        [JsonProperty("otherLiab")]
        public decimal? OtherLiab { get; set; }

        [JsonProperty("otherStockholderEquity")]
        public decimal? OtherStockholderEquity { get; set; }

        [JsonProperty("preferredStockRedeemable")]
        public decimal? PreferredStockRedeemable { get; set; }

        [JsonProperty("preferredStockTotalEquity")]
        public decimal? PreferredStockTotalEquity { get; set; }

        [JsonProperty("propertyPlantAndEquipmentGross")]
        public decimal? PropertyPlantAndEquipmentGross { get; set; }

        [JsonProperty("propertyPlantEquipment")]
        public decimal? PropertyPlantEquipment { get; set; }

        [JsonProperty("retainedEarnings")]
        public decimal? RetainedEarnings { get; set; }

        [JsonProperty("retainedEarningsTotalEquity")]
        public decimal? RetainedEarningsTotalEquity { get; set; }

        [JsonProperty("shortLongTermDebt")]
        public decimal? ShortLongTermDebt { get; set; }

        [JsonProperty("shortTermDebt")]
        public decimal? ShortTermDebt { get; set; }

        [JsonProperty("shortTermInvestments")]
        public decimal? ShortTermInvestments { get; set; }

        [JsonProperty("temporaryEquityRedeemableNoncontrollingInterests")]
        public decimal? TemporaryEquityRedeemableNoncontrollingInterests { get; set; }

        [JsonProperty("totalAssets")]
        public decimal? TotalAssets { get; set; }

        [JsonProperty("totalCurrentAssets")]
        public decimal? TotalCurrentAssets { get; set; }

        [JsonProperty("totalCurrentLiabilities")]
        public decimal? TotalCurrentLiabilities { get; set; }

        [JsonProperty("totalLiab")]
        public decimal? TotalLiab { get; set; }

        [JsonProperty("totalPermanentEquity")]
        public decimal? TotalPermanentEquity { get; set; }

        [JsonProperty("totalStockholderEquity")]
        public decimal? TotalStockholderEquity { get; set; }

        [JsonProperty("treasuryStock")]
        public decimal? TreasuryStock { get; set; }

        [JsonProperty("warrants")]
        public decimal? Warrants { get; set; }
    }

    public partial class Highlights
    {
        [JsonProperty("MarketCapitalization")]
        public long MarketCapitalization { get; set; }

        [JsonProperty("MarketCapitalizationMln")]
        public string MarketCapitalizationMln { get; set; }

        [JsonProperty("EBITDA")]
        public long Ebitda { get; set; }

        [JsonProperty("PERatio")]
        public string PeRatio { get; set; }

        [JsonProperty("PEGRatio")]
        public decimal? PegRatio { get; set; }

        [JsonProperty("WallStreetTargetPrice")]
        public decimal? WallStreetTargetPrice { get; set; }

        [JsonProperty("BookValue")]
        public decimal? BookValue { get; set; }

        [JsonProperty("DividendShare")]
        public decimal? DividendShare { get; set; }

        [JsonProperty("DividendYield")]
        public decimal? DividendYield { get; set; }

        [JsonProperty("EarningsShare")]
        public decimal? EarningsShare { get; set; }

        [JsonProperty("EPSEstimateCurrentYear")]
        public decimal? EpsEstimateCurrentYear { get; set; }

        [JsonProperty("EPSEstimateNextYear")]
        public decimal? EpsEstimateNextYear { get; set; }

        [JsonProperty("EPSEstimateNextQuarter")]
        public string EpsEstimateNextQuarter { get; set; }

        [JsonProperty("EPSEstimateCurrentQuarter")]
        public decimal? EpsEstimateCurrentQuarter { get; set; }

        [JsonProperty("MostRecentQuarter")]
        public DateTimeOffset? MostRecentQuarter { get; set; }

        [JsonProperty("ProfitMargin")]
        public decimal? ProfitMargin { get; set; }

        [JsonProperty("OperatingMarginTTM")]
        public decimal? OperatingMarginTtm { get; set; }

        [JsonProperty("ReturnOnAssetsTTM")]
        public decimal? ReturnOnAssetsTtm { get; set; }

        [JsonProperty("ReturnOnEquityTTM")]
        public decimal? ReturnOnEquityTtm { get; set; }

        [JsonProperty("RevenueTTM")]
        public decimal? RevenueTtm { get; set; }

        [JsonProperty("RevenuePerShareTTM")]
        public decimal? RevenuePerShareTtm { get; set; }

        [JsonProperty("QuarterlyRevenueGrowthYOY")]
        public decimal? QuarterlyRevenueGrowthYoy { get; set; }

        [JsonProperty("GrossProfitTTM")]
        public decimal? GrossProfitTtm { get; set; }

        [JsonProperty("DilutedEpsTTM")]
        public decimal? DilutedEpsTtm { get; set; }

        [JsonProperty("QuarterlyEarningsGrowthYOY")]
        public decimal? QuarterlyEarningsGrowthYoy { get; set; }
    }

    public partial class OutstandingShares
    {
        [JsonProperty("annual")]
        public Dictionary<string, EarningAnnual> Annual { get; set; }

        [JsonProperty("quarterly")]
        public Dictionary<string, EarningAnnual> Quarterly { get; set; }
    }

    public partial class EarningAnnual
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("sharesMln")]
        public string SharesMln { get; set; }
    }

    public partial class SharesStats
    {
        [JsonProperty("SharesOutstanding")]
        public decimal? SharesOutstanding { get; set; }

        [JsonProperty("SharesFloat")]
        public decimal? SharesFloat { get; set; }

        [JsonProperty("PercentInsiders")]
        public decimal? PercentInsiders { get; set; }

        [JsonProperty("PercentInstitutions")]
        public decimal? PercentInstitutions { get; set; }

        [JsonProperty("SharesShort")]
        public decimal? SharesShort { get; set; }

        [JsonProperty("SharesShortPriorMonth")]
        public decimal? SharesShortPriorMonth { get; set; }

        [JsonProperty("ShortRatio")]
        public decimal? ShortRatio { get; set; }

        [JsonProperty("ShortPercentOutstanding")]
        public decimal? ShortPercentOutstanding { get; set; }

        [JsonProperty("ShortPercentFloat")]
        public decimal? ShortPercentFloat { get; set; }
    }

    public partial class SplitsDividends
    {
        [JsonProperty("ForwardAnnualDividendRate")]
        public decimal? ForwardAnnualDividendRate { get; set; }

        [JsonProperty("ForwardAnnualDividendYield")]
        public decimal? ForwardAnnualDividendYield { get; set; }

        [JsonProperty("PayoutRatio")]
        public decimal? PayoutRatio { get; set; }

        [JsonProperty("DividendDate")]
        public DateTimeOffset? DividendDate { get; set; }

        [JsonProperty("ExDividendDate")]
        public DateTimeOffset? ExDividendDate { get; set; }

        [JsonProperty("LastSplitFactor")]
        public string LastSplitFactor { get; set; }

        [JsonProperty("LastSplitDate")]
        public DateTimeOffset? LastSplitDate { get; set; }

        [JsonProperty("NumberDividendsByYear")]
        public Dictionary<string, NumberDividendsByYear> NumberDividendsByYear { get; set; }
    }

    public partial class NumberDividendsByYear
    {
        [JsonProperty("Year")]
        public long Year { get; set; }

        [JsonProperty("Count")]
        public long Count { get; set; }
    }

    public partial class Valuation
    {
        [JsonProperty("TrailingPE")]
        public decimal? TrailingPe { get; set; }

        [JsonProperty("ForwardPE")]
        public decimal? ForwardPe { get; set; }

        [JsonProperty("PriceSalesTTM")]
        public decimal? PriceSalesTtm { get; set; }

        [JsonProperty("PriceBookMRQ")]
        public decimal? PriceBookMrq { get; set; }

        [JsonProperty("EnterpriseValueRevenue")]
        public decimal? EnterpriseValueRevenue { get; set; }

        [JsonProperty("EnterpriseValueEbitda")]
        public decimal? EnterpriseValueEbitda { get; set; }
    }

    public partial class FundamentalStock
    {
        public static FundamentalStock FromJson(string json)
        {
            json = json.Replace("\"0000-00-00\"", "null");
            return JsonConvert.DeserializeObject<FundamentalStock>(json, EODHistoricalData.NET.ConverterFundamentalStock.Settings);
        }
    }

    public static class SerializeFundamentalStock
    {
        public static string ToJson(this FundamentalStock self) => JsonConvert.SerializeObject(self, EODHistoricalData.NET.ConverterFundamentalStock.Settings);
    }

    internal static class ConverterFundamentalStock
    {
        public static List<string> Errors = new List<string>();
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal },
                new NullConverter(),
            },
            Error = delegate (object sender, Newtonsoft.Json.Serialization.ErrorEventArgs args)
            {
                Errors.Add(args.ErrorContext.Error.Message);
                args.ErrorContext.Handled = true;
            },
        };
    }
}
