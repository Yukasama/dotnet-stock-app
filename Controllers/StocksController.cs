using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Obliviate.Data;
using Obliviate.Models;
using Obliviate.Services;

namespace Obliviate.Controllers
{
    public class StocksController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly StockManager _stockManager;

        public StocksController(ApplicationDbContext context, StockManager stockManager)
        {
            _context = context;
            _stockManager = stockManager;
        }

        // GET: Stocks
        public async Task<IActionResult> Index()
        {
              return View(await _context.Stock.ToListAsync());
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

        // GET: Stocks/Manage
        [Route("Stocks/Manage")]
        public async Task<IActionResult> Manage()
        {
            return View(await _context.Stock.ToListAsync());
        }

        // POST: Stocks/Manage
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Stocks/Update")]
        public async Task<IActionResult> Update()
        {
            bool skip = false;
            List<string> stockList = _stockManager.GetSymbols();
            foreach (string s in stockList)
            {
                Stock stock = _stockManager.GetFinancials(s);
                if (ModelState.IsValid)
                {
                    var testPK = stock.Symbol;
                    if (stock.IsEtf == "False")
                    {
                        if (skip == true)
                        {
                            continue;
                        }
                        else
                        {
                            if(_context.Stock.Find(testPK) != null)
                            {
                                _context.Remove(_context.Stock.Find(testPK));
                                _context.SaveChanges();
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }

                    _context.Add(stock);
                    await _context.SaveChangesAsync();
                    System.Diagnostics.Debug.WriteLine($"'{testPK}' successfully pushed.");
                }
            }
            return RedirectToAction(nameof(Index));
        }


        //GET: Stocks/search?q=
        [Route("Stocks/search")]
        public async Task<IActionResult> Search(string q)
        {
            ViewBag.Message = q;

            var stocks = from stock in _context.Stock select stock;

            stocks = stocks.Where(s => s.Symbol.StartsWith(q) || s.CompanyName.StartsWith(q));

            return View(await stocks.ToListAsync());
        }
    }
}
