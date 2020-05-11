using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmoPieShop.Models;
using SmoPieShop.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmoPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;

        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = "Welcome to Smo's Pie Shop";

            var pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);
            var viewModels = new HomeViewModel()
            {
                Title = "Welcome to Smo's Pie Shop",
                Pies = pies.ToList()
            };

            return View(viewModels);
        }
    }
}
