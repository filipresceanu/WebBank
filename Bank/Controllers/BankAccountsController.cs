using Microsoft.AspNetCore.Mvc;
using Bank.Models;
using Bank.Services.Interfaces;

namespace Bank.Controllers
{
    public class BankAccountsController : Controller
    {
        private readonly IBankAccountService _bankAccountService;

        public BankAccountsController(IBankAccountService bankAccountService)
        {
            _bankAccountService = bankAccountService;
        }

        // GET: BankAccountController
        public ActionResult Index()
        {
            var bankaccount = _bankAccountService.GetBankAccount();
            return View(bankaccount);
        }

        // GET: BankAccountController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankaccount = _bankAccountService.GetBankAccount().FirstOrDefault(m => m.BankAccountID == id);
            if (bankaccount == null)
            {
                return NotFound();
            }

            return View(bankaccount);
        }

        // GET: BankAccountController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BankAccountController/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("BankAccountID,PIN,Sold,Currency")] BankAccount bankaccount)
        {
            if (ModelState.IsValid)
            {
                _bankAccountService.AddBankAccount(bankaccount);
                _bankAccountService.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(bankaccount);
        }

        // GET: BankAccountController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankaccount = _bankAccountService.GetBankAccount().FirstOrDefault(m => m.BankAccountID == id);
            if (bankaccount == null)
            {
                return NotFound();
            }
            return View(bankaccount);
        }

        // POST: BankAccountController/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("BankAccountID,PIN,Sold,Currency")] BankAccount bankaccount)
        {
            if (id != bankaccount.BankAccountID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _bankAccountService.UpdateBankAccount(bankaccount);
                _bankAccountService.Save();

                return RedirectToAction(nameof(Index));
            }
            return View(bankaccount);
        }

        // GET: BankAccountController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankaccount = _bankAccountService.GetBankAccount().FirstOrDefault(m => m.BankAccountID == id);
            if (bankaccount == null)
            {
                return NotFound();
            }

            return View(bankaccount);
        }

        // POST: BankAccountController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var bankaccount = _bankAccountService.GetBankAccount().FirstOrDefault(m => m.BankAccountID == id);
            _bankAccountService.DeleteBankAccount(bankaccount);
            _bankAccountService.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}
