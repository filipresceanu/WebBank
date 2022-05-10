using Microsoft.AspNetCore.Mvc;
using Bank.Models;
using Bank.Services.Interfaces;
namespace Bank.Controllers
{
    public class TranzactionsController : Controller
    {
        private readonly ITranzactionService _tranzactionService;

        public TranzactionsController(ITranzactionService tranzactionService)
        {
            _tranzactionService = tranzactionService;
        }

        // GET: TranzactionController
        public ActionResult Index()
        {
            var tranzaction = _tranzactionService.GetTranzaction();
            return View(tranzaction);
        }

        // GET: TranzactionController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tranzaction = _tranzactionService.GetTranzaction().FirstOrDefault(m => m.TranzactionID == id);
            if (tranzaction == null)
            {
                return NotFound();
            }

            return View(tranzaction);
        }

        // GET: TranzactionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TranzactionController/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("TranzactionID,Operation,Amount")] Tranzaction tranzaction)
        {
            if (ModelState.IsValid)
            {
                _tranzactionService.AddTranzaction(tranzaction);
                _tranzactionService.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(tranzaction);
        }

        // GET: TranzactionController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tranzaction = _tranzactionService.GetTranzaction().FirstOrDefault(m => m.TranzactionID == id);
            if (tranzaction == null)
            {
                return NotFound();
            }
            return View(tranzaction);
        }

        // POST: TranzactionController/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("TranzactionID,Operation,Amount")] Tranzaction tranzaction)
        {
            if (id != tranzaction.TranzactionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _tranzactionService.UpdateTranzaction(tranzaction);
                _tranzactionService.Save();

                return RedirectToAction(nameof(Index));
            }
            return View(tranzaction);
        }

        // GET: TranzactionController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tranzaction = _tranzactionService.GetTranzaction().FirstOrDefault(m => m.TranzactionID == id);
            if (tranzaction == null)
            {
                return NotFound();
            }

            return View(tranzaction);
        }

        // POST: TranzactionController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var tranzaction = _tranzactionService.GetTranzaction().FirstOrDefault(m => m.TranzactionID == id);
            _tranzactionService.DeleteTranzaction(tranzaction);
            _tranzactionService.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}
