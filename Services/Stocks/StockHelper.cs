using System;
using System.Globalization;

namespace Obliviate.Services.Stocks
{
    class StockHelper
    {
        private readonly CultureInfo _provider;
        public StockHelper(CultureInfo provider)
        {
            _provider = provider;
        }


        /// <summary>
        /// Returns Average from JSON String
        /// </summary>
        /// <param name="data">JSON String</param>
        /// <returns>Average (Decimal)</returns>
        public decimal Average(string data)
        {
            List<string> dataList = data.Split(",").ToList();
            List<decimal> averageList = new();
            foreach (string d in dataList)
            {
                try { averageList.Add(Decimal.Parse(d, _provider)); }
                catch { }
            }
            decimal average = averageList.Average();
            return average;
        }


        /// <summary>
        /// Limit Scale in two ranges
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="value"></param>
        /// <returns>Value scaled between to ranges</returns>
        public decimal LimitScale(decimal min, decimal max, decimal value)
        {
            return (value - min) / (max - min);
        }
    }
}