using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDBFirst
{
	public class BloggingContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
	{
		//public BloggingContext() : base()
		//{ }
		public DbSet<Blog> blog { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=172.20.16.65;Database=cassietest;User ID=sa;password=abc123_;");
		}
	}
}
