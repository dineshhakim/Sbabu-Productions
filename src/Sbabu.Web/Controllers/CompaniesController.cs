using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Sbabu.Web.Models;
using Sbabu.Web.Repository.Infrastructure;
using Sbabu.Web.Services.Abstract;

namespace Sbabu.Web.Controllers
{
    public class CompaniesController : Controller
    {
        private ICompanyService _context;

        public CompaniesController(ICompanyService context)
        {
            _context = context;
        }

        // GET: Companies
        public IActionResult Index()
        {
            return View(_context.GetAll().ToList());
        }

        // GET: Companies/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Company company = _context.GetById((long)id);
            if (company == null)
            {
                return HttpNotFound();
            }

            return View(company);
        }

        // GET: Companies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Companies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Company company)
        {
            if (ModelState.IsValid)
            {
                _context.Add(company);
                return RedirectToAction("Index");
            }
            return View(company);
        }

        // GET: Companies/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Company company = _context.GetById((long)id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return View(company);
        }

        // POST: Companies/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Company company)
        {
            if (ModelState.IsValid)
            {
                _context.Update(company);
                return RedirectToAction("Index");
            }
            return View(company);
        }

        // GET: Companies/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Company company = _context.GetById((long)id);
            if (company == null)
            {
                return HttpNotFound();
            }

            return View(company);
        }

        // POST: Companies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Company company = _context.GetById((long)id);
            _context.Delete(company);

            return RedirectToAction("Index");
        }
    }
}
