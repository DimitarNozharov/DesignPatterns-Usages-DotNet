using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.FacetedBuilderPattern
{
	//can be internal class of the facade to not expose outside;
	public class PersonAddressBuilder : PersonBuilderFacade
	{
		public PersonAddressBuilder(Person person)
		{
			this.Person = person;
		}

		public PersonAddressBuilder UnderName(string name)
		{
			Person.Name = name;
			return this;
		}

		public PersonAddressBuilder In(string city)
		{
			Person.City = city;
			return this;
		}

		public PersonAddressBuilder InCountry(string country)
		{
			Person.Country = country;
			return this;
		}
	}
}
