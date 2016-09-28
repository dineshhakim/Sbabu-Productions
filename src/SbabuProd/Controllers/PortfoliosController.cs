using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
 
using Sbabu.Web.Models;
using Sbabu.Web.Services.Impl;
using Sbabu.Web.Services.Abstract;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.Net.Http.Headers;
using Sbabu.Web.Utility;
using Sbabu.Web.ViewModels;

namespace Sbabu.Web.Controllers
{
    public class PortfoliosController : Controller
    {
        public IPortfolioService service;
        private IHostingEnvironment _environment;
        private string imagesfolder = @"\Images\photos\";

        public PortfoliosController(IPortfolioService serv, IHostingEnvironment environment)
        {
            service = serv;
            _environment = environment;
        }


        // GET: Portfolios
        public IActionResult Index()
        {
            return View(service.GetAll().ToList());
        }

        // GET: Portfolios/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Portfolio portfolio = service.GetById((long)id);
            if (portfolio == null)
            {
                return NotFound();
            }

            return View(portfolio);
        }

        // GET: Portfolios/Create
        public IActionResult Create()
        {
            return View();
        }
        //http://corediaries.blogspot.com/2016/03/aspnet-core-mvc-6-uploading-files.html
        // POST: Portfolios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PortfolioViewModel portfolio, IFormFile Image)
        {

            if (ModelState.IsValid)
            {
                if (Image != null && Image.Length > 0)
                {
                    var imagename = FormFileHelpers.Save(Image, _environment.WebRootPath + imagesfolder);
                    portfolio.Url = imagename;
                }
                var portfolioentity = new Portfolio { PortfolioName = portfolio.PortfolioName, PortfolioDescription = portfolio.PortfolioDescription, Url = portfolio.Url };
                service.Add(portfolioentity);
                return RedirectToAction("Index");
            }
            return View(portfolio);
        }

        // GET: Portfolios/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Portfolio portfolio = service.GetById((long)id);
            if (portfolio == null)
            {
                return NotFound();
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
                service.Update(portfolio);
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
                return NotFound();
            }

            Portfolio portfolio = service.GetById((long)id);
            if (portfolio == null)
            {
                return NotFound();
            }

            return View(portfolio);
        }

        // POST: Portfolios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Portfolio portfolio = service.GetById(id);
            service.Delete(portfolio);
            return RedirectToAction("Index");
        }
    }
}
