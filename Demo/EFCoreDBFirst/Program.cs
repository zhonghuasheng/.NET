using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreDBFirst
{
	class Program
	{
		static void Main(string[] args)
		{
			using (BloggingContext bloggingContext = new BloggingContext())
			{
				bloggingContext.blog.Add(new Blog { Id = 2, Name = "Name2", Url="www.baidu.com2" });
				int count = bloggingContext.SaveChanges();
				Console.WriteLine("{0} count record saved in the database", count);

				List<Blog> blogs = bloggingContext.blog.Where(x => x.Id == 1).ToList();
			}
		}
	}
}
