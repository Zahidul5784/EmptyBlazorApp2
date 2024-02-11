using EmptyBlazorApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyBlazorApp2.Services
{
	public class PersonService : IPersonService
	{
		private readonly PersonContext db;

		public PersonService(PersonContext db)
		{

			this.db = db;
		}

		public void AddPerson(Person person)
		{
			this.db.People.Add(person);
			this.db.SaveChanges();
		}
		public List<Person> GetPerson()
		{
			return this.db.People.ToList();
		}

		public Person? GetPersonById(int id)
		{
			return this.db.People.FirstOrDefault(x => x.Id == id);
		}
		public void UpdatePerson(Person person)
		{

			this.db.Entry(person).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			this.db.SaveChanges();

		}


		public void DeletePerson(int id)
		{

			var p = GetPersonById(id);
			if (p is null) return;
			this.db.People.Remove(p);
			this.db.SaveChanges();

		}

	}
}
