using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmoPieShop.Models
{
    public interface IFeedBackRepository
    {
        void AddFeedBack(FeedBack feedBack);
    }
}
