using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Obliviate.Models;
using System.Reflection;

namespace Obliviate.Services
{
    public interface StockManager
    {
        Stock GetFinancials();
    }


    public class StockData : StockManager
    {
        private readonly IConfiguration _configuration;

        public StockData(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Stock GetFinancials()
        {
            string API_KEY = _configuration.GetValue<string>("FMP_API_KEY");
            string baseUrl = _configuration.GetValue<string>("FMP_API_URL");

            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);

                HttpResponseMessage response = client.GetAsync("income-statement/MSFT?limit=120&apikey=" + API_KEY).Result;
            
                if (response.IsSuccessStatusCode)
                {
                    Stock stock = new Stock();
                    var result = response.Content.ReadAsStringAsync().Result;
                    dynamic? jsonObj = JsonConvert.DeserializeObject(result);

                    int i = 0;
                    foreach(var obj in jsonObj)
                    {
                        foreach(PropertyInfo prop in stock.GetType().GetProperties())
                        {
                            if(prop.CanWrite)
                            {
                                if (i != 0 && prop.Name.ToLower() != "symbol")
                                {
                                    var prev = prop.GetValue(stock);
                                    prop.SetValue(stock, $"{obj[prop.Name.ToLower()]},{prev}", null);
                                } else
                                {
                                    prop.SetValue(stock, $"{obj[prop.Name.ToLower()]}", null);
                                }
                            }
                        }
                        ++i;
                    }

                    return stock;

                } else
                {
                    return new Stock();
                }
            }

        }
    }
}
