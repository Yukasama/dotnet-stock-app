using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Obliviate.Models;
using System.Reflection;
using System.Linq;
using Newtonsoft.Json.Linq;
using Obliviate.Data;
using System.Diagnostics;
using System.Collections;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Obliviate.Services.Stocks
{
    public class StockManager
    {
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _context;
        private readonly string? _apiKey;
        private readonly string? _baseUrl;
        private readonly HttpClient _client;
        private readonly StockCalculator _calculator;

        public StockManager(IConfiguration configuration, ApplicationDbContext context)
        {
            _configuration = configuration;
            _context = context;
            _apiKey = _configuration.GetValue<string>("FMP_API_KEY");
            _baseUrl = _configuration.GetValue<string>("FMP_API_URL");

            //Configuring Client
            _client = new HttpClient();
            _client.BaseAddress = new Uri(_baseUrl);
            _client.DefaultRequestHeaders.TryAddWithoutValidation
                ("Content-Type", "application/json; charset=utf-8");

            _calculator = new StockCalculator(configuration);
        }


        /// <summary>
        /// Make Call to API, getting a HttpResponse and turning it into
        /// a JSON String.
        /// </summary>
        /// <param name="url"></param>
        /// <returns>JSON String</returns>
        private string MakeCall(string url)
        {
            HttpResponseMessage apiCall = _client.GetAsync(url).Result;
            if (apiCall.IsSuccessStatusCode)
            {
                string result = apiCall.Content.ReadAsStringAsync().Result;
                return result;
            }
            return null;
        }


        /// <summary>
        /// Get Symbol List containing Tickers of almost every stock.
        /// </summary>
        /// <returns>Symbol List</returns>
        public List<string> GetSymbols()
        {
            JArray jsonArr = JArray.Parse(MakeCall($"{_baseUrl}v3/stock/list?apikey={_apiKey}"));
            List<string> symbols = new();
            foreach (JObject obj in jsonArr)
                symbols.Add(obj["symbol"].ToString());
            return symbols;
        }


        /// <summary>
        /// Format JSON API Request.
        /// </summary>
        /// <param name="symbol">Symbol of Stock (eg. AAPL)</param>
        /// <param name="api">Which API to use</param>
        /// <param name="data">Which Data to get</param>
        /// <returns>Formatted/Merged JSON List</returns>
        private List<JObject> FormatJson(string symbol, string api = "FMP", string data = "standard")
        {
            //Where API Calls with {Name: URL} are stored
            string[] calls = new string[]
            {
                //API PREMIUM
                //$"v4/esg-environmental-social-governance-data?symbol={symbol}&apikey={_apiKey}",
                //$"v4/price-target-consensus?symbol={symbol}&apikey={_apiKey}",
                //$"v4/stock_peers?symbol={symbol}&apikey={_apiKey}",

                $"v3/analyst-estimates/{symbol}?&apikey={_apiKey}",
                $"v3/historical-discounted-cash-flow-statement/{symbol}?apikey={_apiKey}",
                $"v3/income-statement/{symbol}?apikey={_apiKey}",
                $"v3/balance-sheet-statement/{symbol}?apikey={_apiKey}",
                $"v3/cash-flow-statement/{symbol}?apikey={_apiKey}",
                $"v3/ratios/{symbol}?limit=120&apikey={_apiKey}",
                $"v3/key-metrics/{symbol}?limit=120&apikey={_apiKey}",
                $"v3/profile/{symbol}?&apikey={_apiKey}",
                $"v3/rating/{symbol}?&apikey={_apiKey}"
            };

            //Where Stock Data will be stored
            Dictionary<int, JObject> stockData = new();
            JArray jsonArr = new();

            //Make API Call for each Web Address in List
            int count = 0, otherCount = 0, errors = 0;
            foreach (string call in calls)
            {
                try
                {
                    jsonArr = JArray.Parse(MakeCall(call));
                }
                catch (System.ArgumentNullException)
                {
                    ++errors;
                }
                if (errors > 3)
                    return null;

                //Individual Changes
                JArray tempJsonArr = new();
                if (call.Contains("environmental"))
                {
                    otherCount = 0;
                    foreach (JObject j in jsonArr)
                    {
                        if (otherCount % 4 == 0)
                            tempJsonArr.Add(j);
                        ++otherCount;
                    }
                    jsonArr = tempJsonArr;
                }

                //Format JSON
                count = 0;
                foreach (JObject obj in jsonArr)
                {
                    //Merge JSON Objects
                    if (!stockData.ContainsKey(count))
                    {
                        JObject startObject = new();
                        startObject.Merge(obj);
                        stockData.Add(count, startObject);
                    }
                    else
                        stockData[count].Merge(obj);
                    ++count;
                }
            }

            //Make List from Dictionary to get rid of indeces as keys
            List<JObject> stockArray = new();
            foreach (KeyValuePair<int, JObject> obj in stockData)
                stockArray.Add(obj.Value);

            return stockArray;
        }


        /// <summary>
        /// Adds Financials to Stock Instance
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns>Stock</returns>
        private Stock GetFinancials(string symbol)
        {
            Stock stock = new();
            List<JObject> stockData = FormatJson(symbol);
            if (stockData.Count == 0 || stockData == null)
                return null;

            string[] singles =
            {
                "symbol", "reportedCurrency", "period", "cik",
                "stockPrice", "companyName", "currency", "isin", "cusip", "exchange", "exchangeShortName", "industry",
                "website", "description", "ceo", "beta", "changes", "dcfDiff", "price", "mktCap",
                "sector", "country", "fullTimeEmployees", "phone", "address", "city", "range", "capexPerShare",
                "state", "zip", "dcfdiff", "image", "ipoDate", "defaultImage", "lastDiv", "volAvg",
                "isEtf", "isActivelyTrading", "isAdr", "isFund", "rating", "ratingScore",
                "ratingRecommendation", "ratingDetailsDCFScore",
                "ratingDetailsDCFRecommendation", "ratingDetailsROEScore",
                "ratingDetailsROERecommendation", "ratingDetailsROAScore",
                "ratingDetailsROARecommendation", "ratingDetailsDEScore",
                "ratingDetailsDERecommendation", "ratingDetailsPEScore",
                "ratingDetailsPERecommendation", "ratingDetailsPBScore",
                "ratingDetailsPBRecommendation", "peersList", "targetHigh",
                "targetLow", "targetConsensus", "targetMedian"
            };
            string[] noDots =
            {
                "symbol", "companyName", "description", "ceo", "address",
                "state", "county", "city", "peersList"
            };

            int i = 0, j = 0;
            object? prev = new();
            string name = "";
            string convert = "";
            foreach (JObject obj in stockData)
            {
                foreach (PropertyInfo prop in stock.GetType().GetProperties())
                {
                    try
                    {
                        name = Char.ToLower(prop.Name[0]) + prop.Name.Substring(1);
                        prev = prop.GetValue(stock);
                        if (!noDots.Contains(name))
                            convert = $"{obj[name]}".Replace(",", ".");
                        else
                            convert = $"{obj[name]}";

                        if (i == 0)
                            prop.SetValue(stock, convert, null);
                        else if (i != 0 && singles.Contains(name))
                            prop.SetValue(stock, prev, null);
                        else
                            prop.SetValue(stock, convert + $", {prev}", null);
                        ++j;
                    }
                    catch
                    {
                        prop.SetValue(stock, null, null);
                    }
                }
                ++i;
            }

            return stock;
        }


        /// <summary>
        /// Adds History Data to Stock
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns>Stock</returns>
        private Stock GetHistory(Stock stock)
        {
            string symbol = stock.Symbol;
            Dictionary<string, string> history = new()
            {
                {"date", ""},
                {"open", ""},
                {"high", ""},
                {"low", ""},
                {"adjClose", ""},
                {"volume", ""},
                {"change", ""},
                {"changePercent", ""},
                {"vwap", ""},
                {"label", ""},
                {"changeOverTime", ""},
                {"sma20", ""},
                {"sma50", ""},
                {"sma100", ""},
                {"sma200", ""},
                {"williams14", ""},
                {"rsi14", ""}
            };

            JArray? jsonObj = JArray.Parse(JToken.Parse(MakeCall
                ($"{_baseUrl}v3/historical-price-full/{symbol}?apikey={_apiKey}"))["historical"].ToString());
            jsonObj = JArray.FromObject(jsonObj.Reverse());

            JArray jArr = new();
            string[] names = { "sma", "sma", "sma", "sma", "williams", "rsi" };
            int[] periods = { 20, 50, 100, 200, 14, 14 };

            string index = "";
            for (int i = 0; i < names.Length; ++i)
            {
                jArr = JArray.Parse(MakeCall(
                    $"{_baseUrl}v3/technical_indicator/daily/{symbol}?period={periods[i]}&type={names[i]}&apikey={_apiKey}"));

                try { jArr = JArray.FromObject(jArr.Reverse()); }
                catch (System.ArgumentNullException) { continue; }

                index = $"{names[i]}{periods[i]}";
                foreach (JObject j in jArr)
                    history[index] += $"{j[names[i]]}".Replace(",", ".") + ",";
            }


            //Combine Data to giant Strings
            foreach (JObject obj in jsonObj)
            {
                history["date"] += $"\"{obj["date"]}\"" + ",";
                history["open"] += $"{obj["open"]}".Replace(",", ".") + ",";
                history["high"] += $"{obj["high"]}".Replace(",", ".") + ",";
                history["low"] += $"{obj["low"]}".Replace(",", ".") + ",";
                history["adjClose"] += $"{obj["adjClose"]}".Replace(",", ".") + ",";
                history["volume"] += $"{obj["volume"]}".Replace(",", ".") + ",";
                history["change"] += $"{obj["change"]}".Replace(",", ".") + ",";
                history["changePercent"] += $"{obj["changePercent"]}".Replace(",", ".") + ",";
                history["vwap"] += $"{obj["vwap"]}".Replace(",", ".") + ",";
                history["label"] += obj["label"] + ",";
                history["changeOverTime"] += $"{obj["changeOverTime"]}".Replace(",", ".") + ",";
            }

            //Add Data to Stock Members
            stock.HistoryDate = history["date"].Substring(0, history["date"].Length - 1);
            stock.Open = history["open"].Substring(0, history["open"].Length - 1);
            stock.High = history["high"].Substring(0, history["high"].Length - 1);
            stock.Low = history["low"].Substring(0, history["low"].Length - 1);
            stock.Close = history["adjClose"].Substring(0, history["adjClose"].Length - 1);
            stock.Volume = history["volume"].Substring(0, history["volume"].Length - 1);
            stock.Change = history["change"].Substring(0, history["change"].Length - 1);
            stock.ChangePercent = history["changePercent"].Substring(0, history["changePercent"].Length - 1);
            stock.Vwap = history["vwap"].Substring(0, history["vwap"].Length - 1);
            stock.Label = history["label"].Substring(0, history["label"].Length - 1);
            stock.ChangeOverTime = history["changeOverTime"].Substring(0, history["changeOverTime"].Length - 1);
            stock.SMA20 = history["sma20"].Substring(0, history["sma20"].Length - 1);
            stock.SMA50 = history["sma50"].Substring(0, history["sma50"].Length - 1);
            stock.SMA100 = history["sma100"].Substring(0, history["sma100"].Length - 1);
            stock.SMA200 = history["sma200"].Substring(0, history["sma200"].Length - 1);
            stock.WPR = history["williams14"].Substring(0, history["williams14"].Length - 1);
            stock.RSI = history["rsi14"].Substring(0, history["rsi14"].Length - 1);

            return stock;
        }


        /// <summary>
        /// Adds Calculations to Stock Object
        /// </summary>
        /// <param name="stock"></param>
        /// <returns>Stock</returns>
        private Stock GetCalculations(Stock stock)
        {
            try { stock.FAR = _calculator.FAR(stock); }
            catch (Exception e) { Debug.WriteLine($"'{stock.Symbol}' FAR Push Error ocurred: " + e.Message); }

            try { stock.TAR = _calculator.TAR(stock); }
            catch (Exception e) { Debug.WriteLine($"'{stock.Symbol}' FAR Push Error ocurred: " + e.Message); }

            try { stock.EYE = ""; }
            catch (Exception e) { Debug.WriteLine($"'{stock.Symbol}' FAR Push Error ocurred: " + e.Message); }

            return stock;
        }


        /// <summary>
        /// Pushes one Stock into Database
        /// </summary>
        /// <param name="action">Push Configuration</param>
        /// <param name="symbol">Symbol to push to Database</param>
        /// <param name="skip">Skip Stock if it's already in the Database</param>
        /// <param name="already">List with already contained Stocks</param>
        /// <returns></returns>
        public int GetData(string action, string symbol = "", bool skip = true, List<string> already = null)
        {
            Stock stock = new Stock();
            if (action == "history")
            {
                if (already.Contains(symbol))
                {
                    stock = _context.Stock.Find(symbol);
                    stock = GetHistory(stock);
                    stock = GetCalculations(stock);
                    _context.Update(stock);
                }
                else
                {
                    Debug.WriteLine($"'{symbol}' History Push skipped.");
                    return 1;
                }
                return 0;
            }
            else if (action == "all")
            {
                if (skip == true)
                    if (already.Contains(symbol))
                    {
                        Debug.WriteLine($"'{symbol}' Push skipped.");
                        return 1;
                    }

                stock = GetFinancials(symbol);
                if (stock == null || stock.IsEtf == "true" || stock.IsEtf == null)
                    return 1;

                stock = GetHistory(stock);
                stock = GetCalculations(stock);

                _context.Remove(_context.Stock.Find(symbol));
                _context.SaveChanges();
                _context.Add(stock);

                return 0;
            }
            return 1;
        }
    }
}
