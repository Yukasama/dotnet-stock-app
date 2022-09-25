using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Obliviate.Data;
using Obliviate.Models.Stocks;

namespace Obliviate.Controllers
{
    public class IncomeStatementsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IncomeStatementsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: IncomeStatements
        public async Task<IActionResult> Index()
        {
              return View(await _context.IncomeStatement.ToListAsync());
        }

        // GET: IncomeStatements/Details/5
        public async Task<IActionResult> Symbol(string id)
        {
            if (id == null || _context.IncomeStatement == null)
            {
                return NotFound();
            }

            var incomeStatement = await _context.IncomeStatement
                .FirstOrDefaultAsync(m => m.Symbol == id);
            if (incomeStatement == null)
            {
                return NotFound();
            }

            return View(incomeStatement);
        }

        // GET: IncomeStatements/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: IncomeStatements/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Date,Symbol,ReportedCurrency,Cik,FillingDate,AcceptedDate,CalendarYear,Period,Revenue,CostOfRevenue,GrossProfit,GrossProfitRatio,ResearchAndDevelopmentExpenses,GeneralAndAdministrativeExpenses,SellingAndMarketingExpenses,SellingGeneralAndAdministrativeExpenses,OtherExpenses,OperatingExpenses,InterestIncome,InterestExpense,DepreciationAndAmortization,Ebitda,Ebitdaratio,OperatingIncome,OperatingIncomeRatio,TotalOtherIncomeExpensesNet,IncomeBeforeTax,IncomeBeforeTaxRatio,IncomeTaxExpense,NetIncome,NetIncomeRatio,Eps,Epsdiluted,WeightedAverageShsOut,WeightedAverageShsOutDil,Link,FinalLink")] IncomeStatement incomeStatement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(incomeStatement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(incomeStatement);
        }

        // GET: IncomeStatements/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.IncomeStatement == null)
            {
                return NotFound();
            }

            var incomeStatement = await _context.IncomeStatement.FindAsync(id);
            if (incomeStatement == null)
            {
                return NotFound();
            }
            return View(incomeStatement);
        }

        // POST: IncomeStatements/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Date,Symbol,ReportedCurrency,Cik,FillingDate,AcceptedDate,CalendarYear,Period,Revenue,CostOfRevenue,GrossProfit,GrossProfitRatio,ResearchAndDevelopmentExpenses,GeneralAndAdministrativeExpenses,SellingAndMarketingExpenses,SellingGeneralAndAdministrativeExpenses,OtherExpenses,OperatingExpenses,InterestIncome,InterestExpense,DepreciationAndAmortization,Ebitda,Ebitdaratio,OperatingIncome,OperatingIncomeRatio,TotalOtherIncomeExpensesNet,IncomeBeforeTax,IncomeBeforeTaxRatio,IncomeTaxExpense,NetIncome,NetIncomeRatio,Eps,Epsdiluted,WeightedAverageShsOut,WeightedAverageShsOutDil,Link,FinalLink")] IncomeStatement incomeStatement)
        {
            if (id != incomeStatement.Symbol)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(incomeStatement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IncomeStatementExists(incomeStatement.Symbol))
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
            return View(incomeStatement);
        }

        // GET: IncomeStatements/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.IncomeStatement == null)
            {
                return NotFound();
            }

            var incomeStatement = await _context.IncomeStatement
                .FirstOrDefaultAsync(m => m.Symbol == id);
            if (incomeStatement == null)
            {
                return NotFound();
            }

            return View(incomeStatement);
        }

        // POST: IncomeStatements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.IncomeStatement == null)
            {
                return Problem("Entity set 'ApplicationDbContext.IncomeStatement'  is null.");
            }
            var incomeStatement = await _context.IncomeStatement.FindAsync(id);
            if (incomeStatement != null)
            {
                _context.IncomeStatement.Remove(incomeStatement);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IncomeStatementExists(string id)
        {
          return _context.IncomeStatement.Any(e => e.Symbol == id);
        }
    }
}
