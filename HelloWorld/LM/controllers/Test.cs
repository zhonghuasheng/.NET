using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LM.controllers
{
    public class Test:Controller
    {
        public ActionResult Index()
        {
            return Content("hello index from test");
        }

        //[Route("About")]
        public string About()
        {
            return "hello about from test";
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
