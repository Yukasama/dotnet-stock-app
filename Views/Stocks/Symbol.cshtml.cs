using Obliviate.Models.Stocks;
using Obliviate.Services;

namespace Obliviate.Views.Stocks
{
    public class Symbol
    {
        public IncomeStatement data;

        private readonly StockManager _stockManager;

        public Symbol(StockManager stockManager)
        {
            _stockManager = stockManager;
        }

        public void OnGet()
        {
            data = _stockManager.GetFinancials();
        }
    }
}
