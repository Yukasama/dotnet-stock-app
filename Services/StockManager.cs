using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Obliviate.Models;
using System.Reflection;
using System.Linq;
using Newtonsoft.Json.Linq;
using Azure;
using System.Diagnostics;
using System.Collections;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static IronPython.Modules._ast;

namespace Obliviate.Services
{
    public interface StockManager
    {
        Stock GetFinancials(string s);
        List<string> GetSymbols();
        List<JObject> GetJSON(string s, string a, string d);
    }


    public class StockData : StockManager
    {
        private readonly IConfiguration _configuration;

        public StockData(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Format JSON API Request
        /// </summary>
        /// <param name="symbol">Symbol of Stock (eg. AAPL)</param>
        /// <param name="api">Which API to use</param>
        /// <param name="data">Which Data to get</param>
        /// <returns>Formatted JSON List</returns>
        public List<JObject> GetJSON(string symbol, string api = "FMP", string data = "standard")
        {
            //API Initialization
            string API_KEY = "", baseUrl = "";
            if (api == "FMP")
            {
                API_KEY = _configuration.GetValue<string>("FMP_API_KEY");
                baseUrl = _configuration.GetValue<string>("FMP_API_URL");
            }

            //Where API Calls with {Name: URL} are stored
            List<string> apiCalls = new()
            {
                {$"v3/discounted-cash-flow/{symbol}?apikey={API_KEY}"},
                {$"v3/income-statement/{symbol}?apikey={API_KEY}"},
                {$"v3/balance-sheet-statement/{symbol}?apikey={API_KEY}"},
                {$"v3/cash-flow-statement/{symbol}?apikey={API_KEY}"},
                {$"v3/ratios/{symbol}?limit=120&apikey={API_KEY}"},
                {$"v3/key-metrics/{symbol}?limit=120&apikey={API_KEY}"},
                {$"v3/profile/{symbol}?&apikey={API_KEY}"},
                {$"v3/rating/{symbol}?&apikey={API_KEY}"},
            };

            //Where Stock Data will be stored
            Dictionary<int, JObject> stockData = new();

            //Getting Data from API
            using (var client = new HttpClient())
            {
                //Define Client Base Address
                client.BaseAddress = new Uri(baseUrl);

                //Make API Call for each Web Address in List
                foreach (string call in apiCalls)
                {
                    HttpResponseMessage apiCall = client.GetAsync($"{baseUrl}{call}").Result;
                    if (apiCall.IsSuccessStatusCode)
                    {
                        var result = apiCall.Content.ReadAsStringAsync().Result;
                        JArray jsonObj = JArray.Parse(result);

                        int i = 0;

                        //Format JSON
                        foreach (JObject obj in jsonObj)
                        {
                            //Merge JSON Objects
                            if (!stockData.ContainsKey(i))
                            {
                                JObject startObject = new() { };
                                startObject.Merge(obj);
                                stockData.Add(i, startObject);
                            }
                            else
                            {
                                stockData[i].Merge(obj);
                            }
                            ++i;
                        }
                    }
                }
            }

            //Make List from Dictionary to get rid of indeces as keys
            List<JObject> stockArray = new();
            foreach (KeyValuePair<int, JObject> obj in stockData)
            {
                stockArray.Add(obj.Value);
            }

            return stockArray;
        }



        public List<string> GetSymbols()
        {
            string API_KEY = "", baseUrl = "";
            API_KEY = _configuration.GetValue<string>("FMP_API_KEY");
            baseUrl = _configuration.GetValue<string>("FMP_API_URL");

            List<string> symbols = new();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                HttpResponseMessage apiCall = client.GetAsync($"{baseUrl}v3/stock/list?apikey={API_KEY}").Result;
                Debug.WriteLine(apiCall);
                if (apiCall.IsSuccessStatusCode)
                {
                    var result = apiCall.Content.ReadAsStringAsync().Result;
                    JArray jsonObj = JArray.Parse(result.ToString());
                    foreach(JObject obj in jsonObj)
                    {
                        symbols.Add(obj["symbol"].ToString());
                        Debug.WriteLine(obj["symbol"]);
                    }
                }
            }
            return symbols;
        }



        public Stock GetFinancials(string symbol)
        {
            Stock stock = new Stock();
            List<JObject> stockData = GetJSON(symbol);

            if (stockData.Count == 0)
            {
                return stock;
            }

            string[] keys = { };
            string[] nones = { "symbol", "reportedCurrency", "period", "cik" };

            int i = 0;
            foreach (var obj in stockData)
            {
                if (i == 0)
                {
                    JObject keysParsed = JObject.Parse(obj.ToString());
                    Dictionary<string, string>? keysObj = keysParsed.ToObject<Dictionary<string, string>>();
                    keys = keysObj.Keys.ToArray();
                }

                int j = 0;
                foreach (PropertyInfo prop in stock.GetType().GetProperties())
                {
                    try
                    {
                        if (i != 0 && !nones.Contains(keys[j]))
                        {
                            var prev = prop.GetValue(stock);
                            prop.SetValue(stock, $"{obj[keys[j]]},{prev}", null);
                        }
                        else
                        {
                            prop.SetValue(stock, $"{obj[keys[j]]}", null);
                        }
                    }
                    catch
                    {
                        prop.SetValue(stock, null, null);

                    }
                    j++;

                }
                ++i;
            }

            return stock;

        }
    }
}
