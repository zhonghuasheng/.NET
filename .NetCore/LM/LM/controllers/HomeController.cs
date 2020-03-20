using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LM.Models;
using Microsoft.AspNetCore.Mvc;
using LM.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LM.controllers
{
    public class HomeController : Controller
    {
        private INoodleRepository _noodleRepository;
        private IFeedBackRepository _feedBackRepository;

        public HomeController(INoodleRepository noodleRepository, IFeedBackRepository feedBackRepository)
        {
            _noodleRepository = noodleRepository;
            _feedBackRepository = feedBackRepository;
        }
        public ActionResult Index()
        {
            HomeViewModel viewModel = new HomeViewModel()
            {
                Noodles = _noodleRepository.GetAllNoodles().ToList(),
                FeedBacks = _feedBackRepository.GetAllFeedBacks().ToList()
            };
            return View(viewModel);
        }

        public ActionResult Detail(int id)
        {
            return View(_noodleRepository.GetNoodleById(id));
        }
    }
}
