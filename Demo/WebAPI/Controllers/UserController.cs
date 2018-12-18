using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
	[Route("[controller]")]
	public class UserController : Controller
	{
		public DataContext dataContext;
		public UserController(DataContext dataContext)
		{
			this.dataContext = dataContext;
		}

		// GET: api/<controller>
		[HttpGet]
		public IActionResult Get()
		{
			return Ok(dataContext.User.ToList());
		}

		// GET api/<controller>/5
		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			var user = Ok(dataContext.User.FirstOrDefault(x => x.Id == id));
			if (user == null)
			{
				return NotFound();
			}
			return Ok(user);
		}

		// POST api/<controller>
		[HttpPost]
		public IActionResult Post([FromBody]User user)
		{
			dataContext.User.Add(user);
			dataContext.SaveChanges();
			return Ok(user);
		}

		// PUT api/<controller>/5
		[HttpPut("{id}")]
		public IActionResult Put(int id, [FromBody]User newUser)
		{
			var user = dataContext.User.FirstOrDefault(x => x.Id == id);
			if (user == null)
			{
				return NotFound();
			}
			user.Name = newUser.Name;
			user.Password = newUser.Password;
			dataContext.User.Update(user);
			dataContext.SaveChanges();
			return Created($"api/user/{newUser.Id}", newUser);
		}

		// DELETE api/<controller>/5
		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			var user = dataContext.User.FirstOrDefault(x => x.Id == id);
			if (user == null)
			{
				return NotFound();
			}
			dataContext.User.Remove(user);
			dataContext.SaveChanges();
			return NoContent();
		}
	}
}
