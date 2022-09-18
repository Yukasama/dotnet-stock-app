using Microsoft.AspNetCore.Mvc;
using Obliviate.Data;
using Obliviate.Models.Stocks;
using Obliviate.Services;
using System.Drawing.Text;

namespace Obliviate.Controllers
{
    public class StocksController : Controller
    {
        private readonly StockManager _stockManager;
        private readonly ApplicationDbContext db;
        public IActionResult Symbol()
        {
            return View();
        }

        public IActionResult ManageStocks()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateStocks(StockManager stockManager)
        {
            IncomeStatement incomeStatement = _stockManager.GetFinancials();
            try
            {
                if (ModelState.IsValid)
                {
                    System.Diagnostics.Debug.WriteLine("####success");
                    db.IncomeStatement.Add(incomeStatement);
                    db.SaveChanges();
                }
            } catch
            {
                ModelState.AddModelError("", "Unable to save changes.");
            }

            return View(incomeStatement);
        }


        public IActionResult Details()
        {
            return View();
        }
    }
}
