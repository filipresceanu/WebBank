#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bank.Context;
using Bank.Models;
using Bank.Services.Interfaces;

namespace Bank.Controllers
{
    public class AdministratorsController : Controller
    {
        private readonly IAdministratorService _administratorService;

        public AdministratorsController(IAdministratorService administratorService)
        {
            _administratorService = administratorService;
        }

        // GET: AdministratorController
        public ActionResult Index()
        {
            var administrators = _administratorService.GetAdministrator();
            return View(administrators);
        }

        // GET: AdministratorController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var administrators =_administratorService.GetAdministrator().FirstOrDefault(m=>m.AdministratorID == id);
            if (administrators == null)
            {
                return NotFound();
            }

            return View(administrators);
        }

        // GET: Administrators/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdministratorController/Create
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("AdministratorID,AdministratorName,Password")] Administrator administrator)
        {
            if (ModelState.IsValid)
            {
                _administratorService.AddAdministrator(administrator);
                _administratorService.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(administrator);
        }

        // GET: AdministratorController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var administrator = _administratorService.GetAdministrator().FirstOrDefault(a => a.AdministratorID == id);
            if (administrator == null)
            {
                return NotFound();
            }
            return View(administrator);
        }

        // POST: AdministratorController/Edit/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  ActionResult Edit(int id, [Bind("AdministratorID,AdministratorName,Password")] Administrator administrator)
        {
            if (id != administrator.AdministratorID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
               _administratorService.UpdateAdministrator(administrator);
                _administratorService.Save();

                return RedirectToAction(nameof(Index));
            }
            return View(administrator);
        }

        // GET: AdministratorController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var administrator =  _administratorService.GetAdministrator().FirstOrDefault(m => m.AdministratorID == id);
            if (administrator == null)
            {
                return NotFound();
            }

            return View(administrator);
        }

        // POST: AdministratorController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var administrator =  _administratorService.GetAdministrator().FirstOrDefault(a=>a.AdministratorID==id);
            _administratorService.DeleteAdministrator(administrator);
            _administratorService.Save();
            return RedirectToAction(nameof(Index));
        }

       
    }
}
