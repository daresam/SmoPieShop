using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmoPieShop.Models
{
    public class PieRepository: IPieRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public PieRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _applicationDbContext.Pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _applicationDbContext.Pies.FirstOrDefault(pie => pie.Id == pieId);
        }
    }
}
