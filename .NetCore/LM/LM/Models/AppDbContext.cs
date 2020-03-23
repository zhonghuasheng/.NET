using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace LM.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContext)
            : base(dbContext)
        {
        }

        public DbSet<Noodle> Noodles {get;set;}

        public DbSet<FeedBack> FeedBacks { get; set; }
    }
}
