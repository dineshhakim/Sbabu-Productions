using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Sbabu.Web.Models;
using Sbabu.Web.Services.Abstract;

namespace Sbabu.Web.Controllers
{
    public class PortfoliosController : Controller
    {
        public readonly IPortfolioService Service;

        public PortfoliosController(IPortfolioService _service)
        {
            Service = _service;
        }

        // GET: Portfolios
        public IActionResult Index()
        {
            return View(Service.GetAll());
        }

        // GET: Portfolios/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var portfolio = Service.GetById((long)id);
            if (portfolio == null)
            {
                return HttpNotFound();
            }

            return View(portfolio);
        }

        // GET: Portfolios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Portfolios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Portfolio portfolio)
        {
            if (ModelState.IsValid)
            {
                Service.Add(portfolio);
                return RedirectToAction("Index");
            }
            return View(portfolio);
        }

        // GET: Portfolios/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var portfolio = Service.GetById((long)id);
            if (portfolio == null)
            {
                return HttpNotFound();
            }
            return View(portfolio);
        }

        // POST: Portfolios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Portfolio portfolio)
        {
            if (ModelState.IsValid)
            {
                Service.Update(portfolio);
                return RedirectToAction("Index");
            }
            return View(portfolio);
        }

        // GET: Portfolios/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var portfolio = Service.GetById((long)id);
            if (portfolio == null)
            {
                return HttpNotFound();
            }

            return View(portfolio);
        }

        // POST: Portfolios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var portfolio = Service.GetById((long)id);
            Service.Delete(portfolio);
            return RedirectToAction("Index");
        }
    }
}
