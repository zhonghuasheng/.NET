using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
	public class DataContext : DbContext
	{
		public DbSet<User> User { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
		{
			dbContextOptionsBuilder.UseSqlServer("Server=172.20.16.65;Database=cassietest;User ID=sa;password=abc123_");
		}
	}
}
