using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LM.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContext)
            : base(dbContext)
        {
        }

        public DbSet<Noodle> Noodles {get;set;}

        public DbSet<FeedBack> FeedBacks { get; set; }
    }
}
