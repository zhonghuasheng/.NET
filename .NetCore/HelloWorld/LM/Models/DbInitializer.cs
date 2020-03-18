using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LM.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (context.Noodles.Any())
            {
                return;
            }
            
            context.AddRange(
                new Noodle() { Name = "拉面1", Price = 15, ShotDescription = "拉面1好吃" },
                new Noodle() { Name = "拉面2", Price = 15, ShotDescription = "拉面2好吃" },
                new Noodle() { Name = "拉面3", Price = 15, ShotDescription = "拉面3好吃" },
                new Noodle() { Name = "拉面4", Price = 15, ShotDescription = "拉面4好吃" }
                );

            context.SaveChanges();
        }
    }
}
