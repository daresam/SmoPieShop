using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmoPieShop.Models
{
    public class FeedBackRepository: IFeedBackRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public FeedBackRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddFeedBack(FeedBack feedBack)
        {
            _dbContext.Add(feedBack);
            _dbContext.SaveChanges();
        }
    }
}
