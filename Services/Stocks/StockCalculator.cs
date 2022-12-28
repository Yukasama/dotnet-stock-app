using System;
using System.Diagnostics;
using Obliviate.Services;
using Obliviate.Models;
using System.Globalization;

namespace Obliviate.Services.Stocks
{
    public class StockCalculator
    {
        private readonly CultureInfo _provider = new CultureInfo("en-US");
        private readonly StockHelper _helper;
        public StockCalculator(IConfiguration configuration)
        {
            _helper = new StockHelper(_provider);
        }


        /// <summary>
        /// Returns Technical-Asset-Rating (TAR) from Stock Data (0 - 1)
        /// </summary>
        /// <param name="stock"></param>
        /// <returns>decimal</returns>
        public string TAR(Stock stock)
        {
            List<string> closePrices = stock.Close.Split(",").ToList();
            decimal close = Decimal.Parse(closePrices.Last(), _provider);
            int len = closePrices.Count;
            int len30d = len >= 21 ? 21 : len;
            int len1y = len >= 252 ? 252 : len;
            int len3y = len >= 756 ? 756 : len;

            //Store all Data to calculate
            Dictionary<string, List<decimal>> series = new()
            {
                {"low52", new(){0, 1, close / Decimal.Parse(stock.High.Split(",").ToList().GetRange(len - len1y, len1y).Max(), _provider)}},
                {"high52", new(){0, 1, Decimal.Parse(stock.Low.Split(",").ToList().GetRange(len - len1y, len1y).Min(), _provider) / close}},
                {"sma20", new(){-0.15M, 0.10M, Decimal.Parse(stock.SMA20.Split(",").Last(), _provider) / close - 1}},
                {"sma50", new(){-0.25M, 0.15M, Decimal.Parse(stock.SMA50.Split(",").Last(), _provider) / close - 1}},
                {"sma100", new(){-0.30M, 0.25M, Decimal.Parse(stock.SMA100.Split(",").Last(), _provider) / close - 1}},
                {"sma200", new(){-0.40M, 0.35M, Decimal.Parse(stock.SMA200.Split(",").Last(), _provider) / close - 1}},
                {"30d%", new(){-0.2M, 0.15M, Decimal.Parse(stock.Close.Split(",").ElementAt(len - len30d), _provider) / close - 1}},
                {"1y%", new(){-0.3M, 0.4M, Decimal.Parse(stock.Close.Split(",").ElementAt(len - len1y), _provider) / close - 1}},
                {"3y%", new(){-0.3M, 0.4M, Decimal.Parse(stock.Close.Split(",").ElementAt(len - len3y), _provider) / close - 1}},
            };

            decimal result = 0, tar = 0;
            foreach (KeyValuePair<string, List<decimal>> s in series)
                result += _helper.LimitScale(s.Value[1], s.Value[0], s.Value[2]);
            try { tar = result / series.Count; }
            catch { tar = 0; }
            return $"{tar}";
        }


        /// <summary>
        /// Returns Fundamental-Asset-Rating (FAR) from Stock Data (0 - 1)
        /// </summary>
        /// <param name="stock"></param>
        /// <returns>FAR (decimal)</returns>
        public string FAR(Stock stock)
        {
            decimal peRatioAvg = _helper.Average(stock.PeRatio);
            return $"{peRatioAvg}";
        }
    }
}