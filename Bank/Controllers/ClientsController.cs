using Microsoft.AspNetCore.Mvc;
using Bank.Models;
using Bank.Services.Interfaces;
namespace Bank.Controllers
{
    public class ClientsController : Controller
    {
        private readonly IClientService _clientService;

        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }

        // GET: ClientController
        public ActionResult Index()
        {
            var clinets = _clientService.GetClient();
            return View(clinets);
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clients = _clientService.GetClient().FirstOrDefault(m => m.ClientId == id);
            if (clients == null)
            {
                return NotFound();
            }

            return View(clients);
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Nume,Email,Age")] Client client)
        {
            if (ModelState.IsValid)
            {
                _clientService.AddClient(client);
                _clientService.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = _clientService.GetClient().FirstOrDefault(a => a.ClientId == id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        // POST: ClientController/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("Nume,Email,Age")] Client client)
        {
            if (id != client.ClientId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _clientService.UpdateClient(client);
                _clientService.Save();

                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }

        // GET: ClientController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = _clientService.GetClient().FirstOrDefault(a => a.ClientId == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // POST: ClientController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var client = _clientService.GetClient().FirstOrDefault(a => a.ClientId == id);
            _clientService.DeleteClient(client);
            _clientService.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}
