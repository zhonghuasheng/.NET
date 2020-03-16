using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LM.Models
{
    public class MockFeedBackRepository : IFeedBackRepository
    {
        private List<FeedBack> feedBacks;

        public MockFeedBackRepository()
        {
            if (feedBacks == null)
            {
                InitialFeedBacks();
            }
        }

        private void InitialFeedBacks()
        {
            feedBacks = new List<FeedBack>()
            {
                new FeedBack(){ Id=1,Name="姓名1", Email="1@qq.com", Message="口感很好"},
                new FeedBack(){ Id=2,Name="姓名2", Email="2@qq.com", Message="牛肉多多"}
            };
        }
        public IEnumerable<FeedBack> GetAllFeedBacks()
        {
            return feedBacks;
        }

        public void AddFeedBack(FeedBack feedBack)
        {
            feedBacks.Add(feedBack);
        }
    }
}
