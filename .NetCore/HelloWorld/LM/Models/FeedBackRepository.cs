using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LM.Models
{
    public class FeedBackRepository : IFeedBackRepository
    {
        private readonly AppDbContext dbContext;

        public FeedBackRepository(AppDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public void AddFeedBack(FeedBack feedBack)
        {
            dbContext.FeedBacks.Add(feedBack);
            dbContext.SaveChanges();
        }

        public IEnumerable<FeedBack> GetAllFeedBacks()
        {
            return dbContext.FeedBacks;
        }
    }
}
