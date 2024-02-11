using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmptyBlazorApp2.Models
{
	public class Person
	{
		[Key]
		public int Id { get; set; }
		public string PersonName { get; set; }
	}


	public class PersonContext : DbContext
	{
		public DbSet<Person> People { get; set; }
		public PersonContext(DbContextOptions opt) : base(opt)
		{ }
	}
}

