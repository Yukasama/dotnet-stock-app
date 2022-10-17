using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Obliviate.Models;
using System.Reflection;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Obliviate.Services
{
    public interface StockManager
    {
        Stock GetFinancials(string s);
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
        public dynamic? GetData(string symbol, string api="FMP")
        {
            //API Initialization
            string API_KEY = "";
            string baseUrl = "";
            if (api == "FMP")
            {
                API_KEY = _configuration.GetValue<string>("FMP_API_KEY");
                baseUrl = _configuration.GetValue<string>("FMP_API_URL");
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);

                HttpResponseMessage incomeStatement = client.GetAsync(
                    $"income-statement/{symbol}?limit=120&apikey=" + API_KEY).Result;
                HttpResponseMessage balanceSheet = client.GetAsync(
                    $"balance-sheet-statement/{symbol}?limit=120&apikey=" + API_KEY).Result;
                HttpResponseMessage cashFlow = client.GetAsync(
                    $"cash-flow-statement/{symbol}?limit=120&apikey=" + API_KEY).Result;
                HttpResponseMessage ratios = client.GetAsync(
                    $"ratios/{symbol}?apikey=" + API_KEY).Result;
                HttpResponseMessage keyMetrics = client.GetAsync(
                    $"key-metrics/{symbol}?apikey=" + API_KEY).Result;



                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;
                    dynamic? jsonObj = JsonConvert.DeserializeObject(result);
                    return jsonObj;
                }
                return null;
            }
        }

        public Stock GetFinancials(string symbol)
        {
            Stock stock = new Stock();
            dynamic? jsonObj = GetData(symbol);

            string[] keys = {};
            string[] nones = {"symbol", "reportedCurrency", "period", "cik", "finalLink"};

            int i = 0;
            if(jsonObj != null)
            {
                foreach (var obj in jsonObj)
                {
                    if(i == 0) {
                        JObject keysParsed = JObject.Parse(obj.ToString());
                        Dictionary<string, string>? keysObj = keysParsed.ToObject<Dictionary<string, string>>();
                        keys = keysObj.Keys.ToArray();
                    }

                    int j = 0;
                    foreach (PropertyInfo prop in stock.GetType().GetProperties())
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
                        ++j;
                    }
                    ++i;
                }
            } 
            else
            {
                return null;
            }

            return stock;
        }
    }
}
