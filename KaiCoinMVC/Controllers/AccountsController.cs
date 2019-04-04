using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KaiCoinMVC.Data;
using KaiCoinMVC.Models;
using Microsoft.AspNetCore.Authorization;

namespace KaiCoinMVC.Controllers
{
    [Authorize]
    public class AccountsController : Controller
    {
        private readonly BankDbContext _context;

        public AccountsController(BankDbContext context)
        {
            _context = context;
        }

        // GET: Accounts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Account.ToListAsync());
        }

        // GET: Accounts/Transactions/5
        public async Task<IActionResult> Transactions(int id)
        {
            var _account = await _context.Account
                .FirstOrDefaultAsync(m => m.AccountNumber == id);

            var _transaction = _context.Transaction
                .Where(m => m.AccountNumber == id)
                .OrderByDescending(d => d.TransactionDate)
                .Take(10);

            //var database = _context;
            //var listOfTransactions = database.Transactions;
            //var AllTransactionsWithID = listOfTransactions.Where(m => m.AccountNumber == id).OrderByDescending(d => d.TransactionDate).Take(10);

            if (_account == null)
            {
                return NotFound();
            }

            return View(_account);
        }

        // GET: Accounts/Create
        public IActionResult Create()
        {
            var __account = new Account();
            __account.AccountNumber = _context.Account.LastOrDefault().AccountNumber + 1;
            
            return View(__account);
        }

        // POST: Accounts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AccountNumber,Name,DOB,PhoneNo,Address,City,ZipCode,State,OpeningDate,Balance")] Account _account)
        {
            if (ModelState.IsValid)
            {
                _context.Add(_account);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(_account);
        }

        // GET: Accounts/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var _account = await _context.Account.FindAsync(id);
            if (_account == null)
            {
                return NotFound();
            }
            return View(_account);
        }

        // POST: Accounts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AccountNumber,Name,DOB,PhoneNo,Address,City,ZipCode,State,OpeningDate,Balance")] Account _account)
        {
            if (id != _account.AccountNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(_account);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(_account.AccountNumber))
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
            return View(_account);
        }

        // GET: Accounts/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var _account = await _context.Account
                .FirstOrDefaultAsync(m => m.AccountNumber == id);
            if (_account == null)
            {
                return NotFound();
            }

            return View(_account);
        }

        // POST: Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var _account = await _context.Account.FindAsync(id);
            _context.Account.Remove(_account);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountExists(int id)
        {
            return _context.Account.Any(e => e.AccountNumber == id);
        }
    }
}
