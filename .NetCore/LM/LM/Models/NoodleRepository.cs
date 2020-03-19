using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LM.Models
{
    public class NoodleRepository : INoodleRepository
    {
        private readonly AppDbContext appDbContext;

        public NoodleRepository(AppDbContext _appDbContext)
        {
            appDbContext = _appDbContext;
        }

        public IEnumerable<Noodle> GetAllNoodles()
        {
            return appDbContext.Noodles;
        }

        public Noodle GetNoodleById(int id)
        {
            return appDbContext.Noodles.FirstOrDefault(n => n.Id == id);
        }
    }
}
