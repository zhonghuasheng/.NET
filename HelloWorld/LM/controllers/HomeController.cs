using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LM.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LM.controllers
{
    public class HomeController : Controller
    {
        private INoodleRepository _noodleRepository;

        public HomeController(INoodleRepository noodleRepository)
        {
            _noodleRepository = noodleRepository;
        }
        public ActionResult Index()
        {
            var noodels = _noodleRepository.GetAllNoodles();
            return View(noodels);
        }

        //[Route("About")]
        public string About()
        {
            return "hello about";
        }
    }
}
