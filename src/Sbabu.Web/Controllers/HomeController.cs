using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Sbabu.Web.Models;
using Sbabu.Web.Services.Abstract;
using Sbabu.Web.ViewModels;

namespace Sbabu.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPortfolioService _portfolioService;
        // private IPortfolioService _portfolioService;
        public HomeController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }
        public IActionResult Index()
        {
            var portfolios = _portfolioService.GetAll();

            var enumerable = portfolios as Portfolio[] ?? portfolios.ToArray();
            var vm = new HomeViewModel
            {
                Photos = enumerable.Where(x => x.PortfolioType == 1),
                Videos = enumerable.Where(x => x.PortfolioType == 2),
                DJs = enumerable.Where(x => x.PortfolioType == 3)
            };
            return View(vm);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
