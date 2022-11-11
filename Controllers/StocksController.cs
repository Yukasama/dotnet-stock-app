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
                return NotFound();
            var primaryStock = await _context.Stock
                .FirstOrDefaultAsync(m => m.Symbol == id);
            if (primaryStock == null)
                return NotFound();

            List<string> peers = primaryStock.peersList.Split(",").ToList();
            int peersLen = peers.Count < 6 ? peers.Count : 6;
            peers = peers.GetRange(0, peersLen);

            List<Stock>? stockList = new();
            stockList.Add(primaryStock);
            foreach(string p in peers) 
            {
                Stock? peer = _context.Stock.Find(p.Replace("[", "").Replace("]", "").Replace("\"", "").Trim());
                if(peer != null) {
                    stockList.Add(peer);
                }
            }

            return View(stockList);
        }

        // GET: Stocks/Manage
        [Route("Stocks/Manage")]
        public IActionResult Manage()
        {
            return View();
        }

        // POST: Stocks/Manage
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Stocks/Update")]
        public async Task<IActionResult> Update()
        {
            int status = 0;
            List<string> symbols = _stockManager.GetSymbols();
            //List<string> symbols = new(){"MSFT"};
            Stock stock = new();

            //Check if Symbols are already in Database
            List<string> already = new();
            List<Stock> currentSymbols = _context.Stock.ToList();
            foreach(Stock s in currentSymbols)
                already.Add(s.Symbol);

            if (ModelState.IsValid) 
            {
                string action = "all";
                Debug.WriteLine($"Initializing Database Update with Push Configuration '{action.ToUpper()}' ...");
                foreach(string s in symbols) 
                {
                    Stopwatch stopwatch2 = new();
                    stopwatch2.Start();

                    status = _stockManager.GetData(action, s, false, already);
                    if(status == 0) 
                    {
                        await _context.SaveChangesAsync();
                        stopwatch2.Stop();
                        Debug.WriteLine($"'{s}' Push executed in {stopwatch2.Elapsed.Seconds}.{stopwatch2.ElapsedMilliseconds.ToString().Substring(1)}s");
                    }
                }
            }

            return RedirectToAction(nameof(Manage));
        }


        //GET: Stocks/search?q=
        [Route("Stocks/search")]
        public async Task<IActionResult> Search(string q)
        {
            ViewBag.Message = q;

            var symbol = _context.Stock.Find(q);
            if(symbol != null)
                return RedirectToAction(q.ToUpper());

            if(q.Contains(":"))
                q = q.Replace(":", "");

            var stocks = from stock in _context.Stock select stock;
            stocks = stocks.Where(s => s.Symbol.StartsWith(q) || s.CompanyName.StartsWith(q));
            return View(await stocks.ToListAsync());
        }
    }
}
