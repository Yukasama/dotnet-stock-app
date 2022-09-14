using Obliviate.Models.Stocks;
using Newtonsoft.Json;

namespace Obliviate.Services
{
    public interface StockManager
    {
        IncomeStatement GetFinancials();
    }


    public class StockData : StockManager
    {
        private readonly IConfiguration _configuration;

        public StockData(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IncomeStatement GetFinancials()
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

                    return JsonConvert.DeserializeObject<IncomeStatement>(result);

                } else
                {
                    return new IncomeStatement(){};
                }
            }

        }
    }
}
