using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Obliviate.Data;
using Obliviate.Models;

namespace Obliviate.Controllers
{
    public class StocksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StocksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Stocks/{AAPL}
        public IActionResult Symbol(string symbol)
        {
              return View();
        }

        // GET: Stocks/<Symbol>
        [Route("Stocks/{id}")]
        public async Task<IActionResult> Symbol(string id)
        {
            if (id == null || _context.Stock == null)
            {
                return NotFound();
            }

            var stock = await _context.Stock
                .FirstOrDefaultAsync(m => m.Symbol == id);
            if (stock == null)
            {
                return NotFound();
            }

            return View(stock);
        }

        // GET: Stocks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Stocks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Date,Symbol,ReportedCurrency,Cik,FillingDate,AcceptedDate,CalendarYear,Period,Revenue,CostOfRevenue,GrossProfit,GrossProfitRatio,ResearchAndDevelopmentExpenses,GeneralAndAdministrativeExpenses,SellingAndMarketingExpenses,SellingGeneralAndAdministrativeExpenses,OtherExpenses,OperatingExpenses,CostAndExpenses,InterestIncome,InterestExpense,DepreciationAndAmortization,Ebitda,Ebitdaratio,OperatingIncome,OperatingIncomeRatio,TotalOtherIncomeExpensesNet,IncomeBeforeTax,IncomeBeforeTaxRatio,IncomeTaxExpense,NetIncome,NetIncomeRatio,Eps,Epsdiluted,WeightedAverageShsOut,WeightedAverageShsOutDil,Link,FinalLink")] Stock stock)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stock);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stock);
        }

        // GET: Stocks/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Stock == null)
            {
                return NotFound();
            }

            var stock = await _context.Stock.FindAsync(id);
            if (stock == null)
            {
                return NotFound();
            }
            return View(stock);
        }

        // POST: Stocks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Date,Symbol,ReportedCurrency,Cik,FillingDate,AcceptedDate,CalendarYear,Period,Revenue,CostOfRevenue,GrossProfit,GrossProfitRatio,ResearchAndDevelopmentExpenses,GeneralAndAdministrativeExpenses,SellingAndMarketingExpenses,SellingGeneralAndAdministrativeExpenses,OtherExpenses,OperatingExpenses,CostAndExpenses,InterestIncome,InterestExpense,DepreciationAndAmortization,Ebitda,Ebitdaratio,OperatingIncome,OperatingIncomeRatio,TotalOtherIncomeExpensesNet,IncomeBeforeTax,IncomeBeforeTaxRatio,IncomeTaxExpense,NetIncome,NetIncomeRatio,Eps,Epsdiluted,WeightedAverageShsOut,WeightedAverageShsOutDil,Link,FinalLink")] Stock stock)
        {
            if (id != stock.Symbol)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stock);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StockExists(stock.Symbol))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(stock);
        }

        // GET: Stocks/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Stock == null)
            {
                return NotFound();
            }

            var stock = await _context.Stock
                .FirstOrDefaultAsync(m => m.Symbol == id);
            if (stock == null)
            {
                return NotFound();
            }

            return View(stock);
        }

        // POST: Stocks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Stock == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Stock'  is null.");
            }
            var stock = await _context.Stock.FindAsync(id);
            if (stock != null)
            {
                _context.Stock.Remove(stock);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StockExists(string id)
        {
          return _context.Stock.Any(e => e.Symbol == id);
        }
    }
}
