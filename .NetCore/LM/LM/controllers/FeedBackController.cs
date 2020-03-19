using LM.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LM.controllers
{
    public class FeedBackController : Controller
    {
        IFeedBackRepository _feedBackRepository;

        public FeedBackController(IFeedBackRepository feedBackRepository)
        {
            _feedBackRepository = feedBackRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(FeedBack feedBack)
        {
            if (ModelState.IsValid)
            {
                _feedBackRepository.AddFeedBack(feedBack);
                return RedirectToAction("ValidComplete");
            }
            return View();
        }

        public IActionResult ValidComplete()
        {
            return View();
        }
    }
}
