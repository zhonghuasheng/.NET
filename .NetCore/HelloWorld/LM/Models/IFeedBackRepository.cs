using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LM.Models
{
    public interface IFeedBackRepository
    {
        IEnumerable<FeedBack> GetAllFeedBacks();

        void AddFeedBack(FeedBack feedBack);
    }
}
