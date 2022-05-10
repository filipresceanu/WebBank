using Microsoft.AspNetCore.Mvc;
using Bank.Models;
using Bank.Services.Interfaces;
namespace Bank.Controllers
{
    public class AccountTypesController : Controller
    {
        private readonly IAccountTypeService _accountTypeService;

        public AccountTypesController(IAccountTypeService accountTypeService)
        {
            _accountTypeService = accountTypeService;
        }

        // GET: AccountTypeController
        public ActionResult Index()
        {
            var accountTypeService = _accountTypeService.GetAccountType();
            return View(accountTypeService);
        }

        // GET: AccountTypeController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountTypeService = _accountTypeService.GetAccountType().FirstOrDefault(m => m.AccountTypeId == id);
            if (accountTypeService == null)
            {
                return NotFound();
            }

            return View(accountTypeService);
        }

        // GET: AccountTypeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountTypeController/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Nume,Email,Age")] AccountType accountTypeService)
        {
            if (ModelState.IsValid)
            {
                _accountTypeService.AddAccountType(accountTypeService);
                _accountTypeService.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(accountTypeService);
        }

        // GET: AccountTypeController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountTypeService = _accountTypeService.GetAccountType().FirstOrDefault(m => m.AccountTypeId == id);
            if (accountTypeService == null)
            {
                return NotFound();
            }
            return View(accountTypeService);
        }

        // POST: AccountTypeController/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("Nume,Email,Age")] AccountType accountTypeService)
        {
            if (id != accountTypeService.AccountTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _accountTypeService.UpdateAccountType(accountTypeService);
                _accountTypeService.Save();

                return RedirectToAction(nameof(Index));
            }
            return View(accountTypeService);
        }

        // GET: AccountTypeController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountTypeService = _accountTypeService.GetAccountType().FirstOrDefault(m => m.AccountTypeId == id);
            if (accountTypeService == null)
            {
                return NotFound();
            }

            return View(accountTypeService);
        }

        // POST: AccountTypeController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var accountTypeService = _accountTypeService.GetAccountType().FirstOrDefault(m => m.AccountTypeId == id);
            _accountTypeService.DeleteAccountType(accountTypeService);
            _accountTypeService.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}
