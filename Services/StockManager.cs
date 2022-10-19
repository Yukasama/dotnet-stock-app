using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Obliviate.Models;
using System.Reflection;
using System.Linq;
using Newtonsoft.Json.Linq;
using Azure;
using System.Collections;

namespace Obliviate.Services
{
    public interface StockManager
    {
        Stock GetFinancials(string s);
        dynamic[] GetData(string s, string a);
    }


    public class StockData : StockManager
    {
        private readonly IConfiguration _configuration;

        public StockData(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// JSON Response from a specified API 
        /// </summary>
        /// <param name="symbol">Symbol of Stock (eg. AAPL)</param>
        /// <param name="api">Which API to use</param>
        /// <returns>JSON Array</returns>
        public dynamic[] GetData(string symbol, string api="FMP")
        {
            //API Initialization
            string API_KEY = "", baseUrl = "";
            if (api == "FMP")
            {
                API_KEY = _configuration.GetValue<string>("FMP_API_KEY");
                baseUrl = _configuration.GetValue<string>("FMP_API_URL");
            }

            //Where API Calls with {Name: URL} are stored
            Dictionary<string, string> apiCalls = new()
            {
                {"incomeStatement", $"income-statement/{symbol}?apikey={API_KEY}"},
                {"balanceSheet", $"balance-sheet-statement/{symbol}?apikey={API_KEY}"},
                {"cashFlow", $"cash-flow-statement/{symbol}?apikey={API_KEY}"},
                {"ratios", $"ratios/{symbol}?limit=120&apikey={API_KEY}"},
                {"key-metrics", $"key-metrics/{symbol}?limit=120&apikey={API_KEY}"},
            };

            //Where Stock Data will be stored
            Dictionary<int, JObject> stockData = new();

            //Getting Data from API
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);

                foreach (KeyValuePair<string, string> call in apiCalls)
                {
                    HttpResponseMessage apiCall = client.GetAsync($"{baseUrl}{call.Value}").Result;
                    if (apiCall.IsSuccessStatusCode)
                    {
                        var result = apiCall.Content.ReadAsStringAsync().Result;
                        JArray jsonObj = JArray.Parse(result);

                        int i = 0;
                        foreach (JObject obj in jsonObj)
                        {
                            if (!stockData.ContainsKey(i))
                            {
                                JObject startObject = new() { };
                                startObject.Merge(obj);
                                stockData.Add(i, startObject);
                            } else
                            {
                                stockData[i].Merge(obj);
                            }
                            ++i;
                        }
                    }
                }
            }

            //Make Array from Dictionary to get rid of indeces as keys
            dynamic[] stockArray = { };
            foreach(KeyValuePair<int, JObject> obj in stockData)
            {
                stockArray.Append(obj.Value);
            }

            return stockArray;
        }

        public Stock GetFinancials(string symbol)
        {
            Stock stock = new Stock();  
            dynamic[] stockData = GetData(symbol);
            
            string[] keys = {};
            string[] nones = {"symbol", "reportedCurrency", "period", "cik", "finalLink"};

            int i = 0;
            foreach (var obj in stockData)
            {
                if(i == 0) {
                    JObject keysParsed = JObject.Parse(obj.ToString());
                    Dictionary<string, string>? keysObj = keysParsed.ToObject<Dictionary<string, string>>();
                    keys = keysObj.Keys.ToArray();
                    foreach(string key in keys) {
                        Console.WriteLine(key);
                        System.Diagnostics.Debug.WriteLine(key);
                    }
                }

                int j = 0;
                foreach (PropertyInfo prop in stock.GetType().GetProperties())
                {
                    if (i != 0 && !nones.Contains(keys[j]))
                    {
                        var prev = prop.GetValue(stock);
                        prop.SetValue(stock, $"{keys[j]},{prev}", null);
                    }
                    else
                    {
                        prop.SetValue(stock, $"{keys[j]}", null);
                    }
                    ++j;
                }
                ++i;
            }
            
            return stock;
            
        }
    }
}
