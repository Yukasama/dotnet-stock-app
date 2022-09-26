using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Obliviate.Models;

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

                HttpResponseMessage response = client.GetAsync("income-statement/AAPL?limit=120&apikey=" + API_KEY).Result;
            
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;

                    return JsonConvert.DeserializeObject<Stock>(result);

                } else
                {
                    return new Stock(){};
                }
            }

        }
    }
}
