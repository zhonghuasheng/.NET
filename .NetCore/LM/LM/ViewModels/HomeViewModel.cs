using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LM.Models;

namespace LM.ViewModels
{
    public class HomeViewModel
    {
        public IList<Noodle> Noodles { get; set; }

        public IList<FeedBack> FeedBacks { get; set; }
    }
}
