using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LM.controllers
{
    
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IList<string> Index()
        {
            return new List<string>() { "1", "2", "3" };
        }

        [Route("admin/[controller]/[action]")]
        public string About()
        {
            return "About user";
        }
    }
}
