using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.FacetedBuilderPattern
{
	//can be private class of the facade to not expose outside;
	public class PersonJobBuilder : PersonBuilderFacade
	{
		public PersonJobBuilder(Person person)
		{
			this.Person = person;
		}

		public PersonJobBuilder As(string position)
		{
			Person.Position = position;
			return this;
		}

		public PersonJobBuilder Experience(int years)
		{
			Person.YearsExpirience = years;
			return this;
		}

		public PersonJobBuilder Earning(decimal salary)
		{
			Person.Salary = salary;
			return this;
		}
	}
}
