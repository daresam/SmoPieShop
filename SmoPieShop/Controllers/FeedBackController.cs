using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmoPieShop.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmoPieShop.Controllers
{
    [Authorize]
    public class FeedBackController : Controller
    {
        private readonly IFeedBackRepository _feedBackRepo;

        public FeedBackController(IFeedBackRepository feedBackRepository)
        {
            _feedBackRepo = feedBackRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(FeedBack feedback)
        {
            if (ModelState.IsValid)
            {
                _feedBackRepo.AddFeedBack(feedback);
                return RedirectToAction("FeedBackComplete");
            }
            return View(feedback);
        }

        public IActionResult FeedBackComplete()
        {
            return View();
        }
    }
}
