using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LM.Models
{
    public class MockNoodleRepository : INoodleRepository
    {
        private List<Noodle> noodles;

        public MockNoodleRepository()
        {
            if (noodles == null)
            {
                InitialNoodles();
            }
        }

        private void InitialNoodles()
        {
            noodles = new List<Noodle>()
            {
                new Noodle(){ Id=1, Name="鸡蛋拉面", Price=15, ShotDescription="好吃不贵"},
                new Noodle(){ Id=2,Name="招牌拉面",Price=12,ShotDescription="真正好吃的拉面"},
                new Noodle{ Id=3,Name="牛肉拉面", Price=20,ShotDescription="牛肉多多"}
            };
        }

        public IEnumerable<Noodle> GetAllNoodles()
        {
            return noodles;
        }

        public Noodle GetNoodleById(int id)
        {
            return noodles.FirstOrDefault(n => n.Id == id);
        }
    }
}
